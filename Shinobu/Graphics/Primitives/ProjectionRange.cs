using OpenTK;

namespace Shinobu.Graphics.Primitives
{
    /// <summary>
    /// Une structure qui permet de dire "jusqu'où" la projection des vertices s'étendra sur un axe.
    /// </summary>
    internal struct ProjectionRange
    {
        /// <summary>
        /// La projection min
        /// </summary>
        public float Min { get; }

        /// <summary>
        /// La projection max
        /// </summary>
        public float Max { get; }

        public ProjectionRange(Vector2 axis, Vector2[] vertices)
        {
            Min = 0;
            Max = 0;

            if (vertices.Length == 0)
                return;

            Min = Vector2.Dot(axis, vertices[0]);
            Max = Min;

            for (int i = 1; i < vertices.Length; i++)
            {
                float val = Vector2.Dot(axis, vertices[1]);
                if (val < Min)
                    Min = val;
                if (val > Max)
                    Max = val;
            }
        }

        /// <summary>
        /// Vérifier si la projection actuelle chevauche d'autres projections.
        /// </summary>
        /// <param name="other">Les autres projections à comparer</param>
        /// <returns>Si les deux projections se chevauchent ou non</returns>
        public bool Overlaps(ProjectionRange other)
        {
            return Min <= other.Max && Max >= other.Min;
        }
    }
}