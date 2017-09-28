using OpenTK;
using System;

namespace Shinobu.Graphics
{
    public static class Vector2Extensions
    {
        /// <summary>Transformer une Position par une Matrice donnée</summary>
        /// <param name="pos">La position à transformer</param>
        /// <param name="mat">La transformation désirée</param>
        /// <returns>La position transformée</returns>
        public static Vector2 Transform(Vector2 pos, Matrix3 mat)
        {
            Vector2 result;
            Transform(ref pos, ref mat, out result);
            return result;
        }

        /// <summary>Transformer une Position par une Matrice donnée</summary>
        /// <param name="pos">La position à transformer</param>
        /// <param name="mat">La transformation désirée</param>
        /// <param name="result">Le vecteur transformé</param>
        public static void Transform(ref Vector2 pos, ref Matrix3 mat, out Vector2 result)
        {
            result.X = mat.Row0.X * pos.X + mat.Row1.X * pos.Y + mat.Row2.X;
            result.Y = mat.Row0.Y * pos.Y + mat.Row1.Y * pos.Y + mat.Row2.Y;
        }

        /// <summary>
        /// Calculer la distance euclidienne entre deux vecteurs
        /// </summary>
        /// <param name="vec1">Le premier Vecteur</param>
        /// <param name="vec2">Le deuxième Vecteur</param>
        /// <returns>La distance</returns>
        public static float Distance(Vector2 vec1, Vector2 vec2)
        {
            float result;
            Distance(ref vec1, ref vec2, out result);
            return result;
        }

        public static void Distance(ref Vector2 vec1, ref Vector2 vec2, out float result)
        {
            result = (float)Math.Sqrt((vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y));
        }

        /// <summary>
        /// Calculer la distance euclidienne au carré entre deux vecteurs
        /// </summary>
        /// <param name="vec1">Le premier Vecteur</param>
        /// <param name="vec2">Le deuxième Vecteur</param>
        /// <returns>La distance au carré</returns>
        public static float DistanceSquared(Vector2 vec1, Vector2 vec2)
        {
            float result;
            DistanceSquared(ref vec1, ref vec2, out result);
            return result;
        }

        /// <summary>
        /// Calculer la distance euclidienne au carré entre deux vecteurs
        /// </summary>
        /// <param name="vec1">Le premier Vecteur</param>
        /// <param name="vec2">Le deuxième Vecteur</param>
        /// <param name="result">La distance au carré</param>
        public static void DistanceSquared(ref Vector2 vec1, ref Vector2 vec2, out float result)
        {
            result = (vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y);
        }
    }

    ///<remarks>
    /// -- Les Tranformations --
    /// Exemple de transformation : Translation, Rotation, Homothétie (agrandir ou réduire une forme géométrique).
    /// Les Transformations permettent de placer les objets (Un arbre, une maison, un cube, un rectangle, etc...)
    /// Les Transformations s'utilisent à l'aide d'un repère.
    /// 
    /// -- Les Matrices --
    /// Une Matrice est un tableau de nombres ordonnés en lignes et en colonnes entourés par des parenthèses. La synthaxe est proche de celle d'un vecteur mais avec plus de nombres.
    /// ( 7 3 10 )
    /// ( 6 0 6  )
    /// ( 4 8 12 )
    /// Cependant, une matrice n'est pas forcément un tableau de 9 cases, elle peut en contenir jusqu'à l'infini.
    /// Les matrices permettent de transformer des données géométriques en données numériques.
    /// 
    /// OpenGL (et donc OpenTK) utilise donc les Matrices pour : 
    /// - La projection : Permet de transformer un monde 3D en monde 2D (car un écran ne possède que 2 dimensions).
    /// - Les transformations : Voir les transformations ci-dessus.
    /// 
    /// Les deux Matrices principales sont donc :
    /// La Matrice de projection et la matrice de modelview.
    /// </remarks>

    ///<remarks>
    /// Distance Euclidienne : Si d1 et d2 sont respectivement des distances sur E1 et E2 et si F est le produit E1×E2, alors l'application d : F×F → ℝ+ définie par
    /// d1(a1, b1) + d2(a2, b2)
    /// Formule de départ. Version adaptée trouvée sur internet.
    /// </remarks>
}