using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinobu.Graphics.Primitives
{
    public struct Quad : IConvexPolygon, IEquatable<Quad>
    {
        public Vector2 TopLeft;
        public Vector2 TopRight;
        public Vector2 BottomLeft;
        public Vector2 BottomRight;

        public Quad(Vector2 topleft, Vector2 topright, Vector2 bottomleft, Vector2 bottomright)
        {
            TopLeft = topleft;
            TopRight = topright;
            BottomLeft = bottomleft;
            BottomRight = bottomright;
        }
    }
}
