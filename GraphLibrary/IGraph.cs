using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    /// <summary>
    /// C# Graph Library
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public interface IGraph<T, K>
    {
        /// <summary>
        /// Adds a new vertex to a graph
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
        bool AddVertex(T vertex);
        void AddVertices(IEnumerable<T> vertices);

        bool DeleteVertex(T vertex);
        void DeleteVertices(IEnumerable<T> vertices);

        bool AddEdge(T v1, T v2, K weight);

        K GetWeight(T v1, T v2);

        bool DeleteEdge(T v1, T v2);

        bool AreAdjacent(T v1, T v2);

        int Degree(T vertex);

        int InDegree(T vertex);

        int OutDegree(T vertex);

        int GetVerticesCount();

        int GetEdgesCount();
        /// <summary>
        /// Returns a set of adjacent vertices to the one specified as argument
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
        IEnumerable<T> GetAdjacentVertices(T vertex);
        /// <summary>
        /// Returns an IEnumerable containing the vertex set of the graph
        /// </summary>
        /// <returns>IEnumerable</returns>
        IEnumerable<T> GetVertices();

        IEnumerable<IPairValue<T>> GetEdges();
    }
}
