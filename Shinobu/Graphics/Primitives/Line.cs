using OpenTK;
using System;

namespace Shinobu.Graphics.Primitives
{
    /// <summary>
    /// Représente un simple segment. Le création du dessin est supporté par la classe LineManager
    /// </summary>
    public class Line : ICloneable
    {
        ///<summary>
        /// Le point de départ de la Ligne.
        /// </summary>
        public Vector2 StartPoint;

        /// <summary>
        /// Le point de fin de la Ligne.
        /// </summary>
        public Vector2 EndPoint;

        /// <summary>
        /// La longueur de la Ligne.
        /// </summary>
        public float Rho => (EndPoint - StartPoint).Length;

        /// <summary>
        /// La direction du second point par rapport au premier.
        /// </summary>
        public float Theta => (float)Math.Atan2(EndPoint.Y - StartPoint.Y, EndPoint.X - StartPoint.X);

        public Vector2 Direction => (EndPoint - StartPoint).Normalized();

        public Vector2 OrthogonalDirection
        {
            get
            {
                Vector2 dir = Direction;
                return new Vector2(-dir.Y, dir.X);
            }
        }

        public Line(Vector2 p1, Vector2 p2)
        {
            StartPoint = p1;
            EndPoint = p2;
        }

        /// <summary>
        /// La distance au carré d'un point arbitraire p de la Ligne.
        /// </summary>
        public float DistanceSquaredToPoint(Vector2 p)
        {
            return Vector2Extensions.DistanceSquared(p, ClosestPointTo(p));
        }

        /// <summary>
        /// La distance d'un point arbitraire p de la Ligne.
        /// </summary>
        public float DistanceToPoint(Vector2 p)
        {
            return Vector2Extensions.Distance(p, ClosestPointTo(p));
        }

        /// <summary>
        /// Trouver le point le plus proche par rapport à un point donné de la Ligne.
        /// </summary>
        /// <remarks>
        /// Voir : http://geometryalgorithms.com/Archive/algorithm_0102/algorithm_0102.htm | Vers la fin.
        /// </remarks>
        public Vector2 ClosestPointTo(Vector2 p)
        {
            Vector2 v = EndPoint - StartPoint; //Vecteur des points de la ligne p1 à p2
            Vector2 w = p - StartPoint; // Vector des points de la ligne p1 à p

            // Vérifier si p est plus proche de p1 que du segment (p1, p2)
            float c1 = Vector2.Dot(w, v);
            if (c1 <= 0)
                return StartPoint;

            // Vérifier si p est plus proche de p2 que du sugment (p1, p2)
            float c2 = Vector2.Dot(v, v);
            if (c2 <= c1)
                return EndPoint;

            // Si p est plus proche du point b que du segment (p1, p2)
            float b = c1 / c2;
            Vector2 pB = StartPoint + b * v;

            return pB;             
        }

        /// <summary>
        /// Création des Matrices en fonctions des points et vecteurs.
        /// </summary>
        public Matrix4 WorldMatrix()
        {
            return Matrix4.CreateRotationZ(Theta) * Matrix4.CreateTranslation(StartPoint.X, StartPoint.Y, 0);
        }

        public Matrix4 EndWorldMatrix()
        {
            return Matrix4.CreateRotationZ(Theta) * Matrix4.CreateTranslation(EndPoint.X, EndPoint.Y, 0);
        }

        /// <summary>
        /// Permet de cloner la classe Line afin d'en préserver le modèle d'origine.
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
