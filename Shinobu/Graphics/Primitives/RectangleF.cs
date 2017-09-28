using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shinobu.Graphics.Primitives
{
    /// <summary>Stocke un groupe de 4 points flotant qui représentent la position et la taille du rectangle. Pour des fonctions plus avancées, voir <see cref="T:System.Drawing.Region"/></summary>
    /// <filterpriority>1</filterpriority>
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct RectangleF : IEquatable<RectangleF>
    {
        /// <summary>Représente une instance de classe, issue de <see cref="T:System.Drawing.RectangleF"/> avec ses membres non initialisés</summary>
        /// <filterpriority>1</filterpriority>
        public static readonly RectangleF Empty;

        public float X;
        public float Y;

        public float Width;
        public float Height;

        /// <summary>Initialise une nouvelle instance de classe, issue de <see cref="T:System.Drawing.RectangleF"/> avec une position et une taille spécifiées.</summary>
        /// <param name="x">La coordonnée X du côté haut-gauche du rectangle.</param>
        /// <param name="y">La coordonée Y du côté haut-gauche du rectangle.</param>
        /// <param name="width">La largeur du rectangle.</param>
        /// <param name="height">La hauteur du rectangle.</param>
        public RectangleF(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>Initialise une nouvelle instance de classe, issue de <see cref="T:System.Drawing.RectangleF"/> avec une position et une taille spécifiées.</summary>
        /// <param name="location">Un <see cref="Vector2"/> qui représente le côté haut-gauche de la zone rectangulaire.</param>
        /// <param name="size">Un <see cref="Vector2"/> qui représente la largeur et la longueur de la zone rectangulaire.</param>
        public RectangleF(Vector2 location, Vector2 size)
        {
            X = location.X;
            Y = location.Y;
            Width = size.X;
            Height = size.Y;
        }

        /// <summary>Récupérer ou définir la taille de <see cref="T:System.Drawing.RectangleF"/></summary>
        /// <returns>Un <see cref="OpenTK.Vector2"/> qui représente la largeur et la longueur de la structure de <see cref="T:System.Drawing.RectangleF"/></returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public Vector2 Size
        {
            get { return new Vector2(Width, Height); }
            set
            {
                Width = value.X;
                Height = value.Y;
            }
        }

        /// <summary>Récupérer la coordonnée X du bord supérieur de la structure <see cref="T:System.Drawing.RectangleF"/></summary>
        /// <returns>La coordonnée X du bord supérieur de la structure <see cref="T:System.Drawing.RectangleF"/></returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public float Left => X;

        /// <summary>Récupérer la coordonnée Y du bord supérieur de la structure <see cref="T:System.Drawing.RectangleF"/></summary>
        /// <returns>La coordonnée Y du bord supérieur de la structure <see cref="T:System.Drawing.RectangleF"/></returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public float Top => Y;

        /// <summary>Récupérer la coordonnée X qui est la somme de <see cref="P:System.Drawing.RectangleF.X"/> et <see cref="P:System.Drawing.RectangleF.Width"/> du <see cref="T:System.Drawing.RectangleF"/></summary>
        /// <returns>La coordonnée X qui est la somme de <see cref="P:System.Drawing.RectangleF.X"/> et <see cref="P:System.Drawing.RectangleF.Width"/> du <see cref="T:System.Drawing.RectangleF"/></returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public float Right => X + Width;

        /// <summary>Récupérer la coordonnée X qui est la somme de <see cref="P:System.Drawing.RectangleF.Y"/> et <see cref="P:System.Drawing.RectangleF.Height"/> du <see cref="T:System.Drawing.RectangleF"/></summary>
        /// <returns>La coordonnée X qui est la somme de <see cref="P:System.Drawing.RectangleF.Y"/> et <see cref="P:System.Drawing.RectangleF.Height"/> du <see cref="T:System.Drawing.RectangleF"/></returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public float Bottom => Y + Height;


        [Browsable(false)]
        public Vector2 TopLeft => new Vector2(Left, Top);

        [Browsable(false)]
        public Vector2 TopRight => new Vector2(Right, Top);

        [Browsable(false)]
        public Vector2 BottomLeft => new Vector2(Left, Bottom);

        [Browsable(false)]
        public Vector2 BottomRight => new Vector2(Right, Bottom);

        [Browsable(false)]
        public Vector2 Centre => new Vector2(X + Width / 2, Y + Height / 2);

        /// <summary>Tester si <see cref="P:System.Drawing.RectangleF.Width"></see> ou <see cref="P:System.Drawing.RectangleF.Height"></see> du <see cref="T:System.Drawing.RectangleF"></see> à une valeur égale à 0.</summary>
        /// <returns>Retourne vrai si <see cref="P:System.Drawing.RectangleF.Width"></see> ou <see cref="P:System.Drawing.RectangleF.Height"></see> du <see cref="T:System.Drawing.RectangleF"></see> est égal à 0; sinon, faux.</returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public bool IsEmpty => Width <= 0 || Height <= 0;


    }
}
