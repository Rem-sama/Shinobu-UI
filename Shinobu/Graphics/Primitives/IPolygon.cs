using OpenTK;

namespace Shinobu.Graphics.Primitives
{
    public interface IPolygon
    {
        /// <summary>
        /// Les vertices du Polygone.
        /// </summary>
        Vector2[] Vertices { get; }

        /// <summary>
        /// Les vertices du Polygone qui sont utilisées pour calculer les axes du Polygone.
        /// <para>
        /// Optimisation : Les bords du Polygone qui possèdent les mêmes normales que les autres bords
        /// n'ont pas besoin d'avoir leurs Vertices dans cet Array.
        /// </para>
        /// </summary>
        Vector2[] AxisVertices { get; }
    }


    /// <remarks>
    /// Vertex : Ce sont les sommets (Points d'intersections entre deux ou plusieurs segments dans une construction en 2D ou 3D)
    /// Normal Vertex : Normale à un sommet, permet de réaliser le lissage de Gouraud. (Effets de lumière)
    /// </remarks>
}
