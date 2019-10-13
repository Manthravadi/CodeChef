using System;
using System.Collections.Generic;

namespace GraphLibrary
{
    public abstract class Graph<T, K> : IGraph<T, K>
    {
        protected readonly List<T> Vertices = new List<T>();
        protected readonly List<IPairValue<T>> Edges = new List<IPairValue<T>>();

        protected readonly Dictionary<IPairValue<T>, K> Weights = new Dictionary<IPairValue<T>, K>();

        public abstract bool AddEdge(T v1, T v2, K weight);

        public bool AddVertex(T vertex)
        {
            bool isAdded = false;
            if (vertex == null)
            {
                throw new ArgumentNullException();
            }
            if (!Vertices.Contains(vertex))
            {
                Vertices.Add(vertex);
                isAdded = true;
            }
            return isAdded;

        }

        public void AddVertices(IEnumerable<T> vertices)
        {
            if (vertices == null)
            {
                throw new ArgumentNullException();
            }
            using (var it = vertices.GetEnumerator())
            {
                while (it.MoveNext())
                {
                    if (it.Current != null && !Vertices.Contains(it.Current))
                    {
                        Vertices.Add(it.Current);
                    }
                }
            }
        }

        public abstract bool AreAdjacent(T v1, T v2);

        public abstract int Degree(T vertex);

        public abstract bool DeleteEdge(T v1, T v2);

        public bool DeleteVertex(T vertex)
        {
            bool isDeleted = false;
            if (vertex == null)
            {
                throw new ArgumentNullException();
            }
            if (Vertices.Contains(vertex))
            {
                Vertices.Remove(vertex);
                isDeleted = true;
            }
            return isDeleted;
        }

        public void DeleteVertices(IEnumerable<T> vertices)
        {
            if (vertices == null)
            {
                throw new ArgumentNullException();
            }
            using (var it = vertices.GetEnumerator())
            {
                while (it.MoveNext())
                {
                    if (it.Current != null)
                    {
                        Vertices.Remove(it.Current);
                    }
                }
            }
        }

        public abstract IEnumerable<T> GetAdjacentVertices(T vertex);

        public int GetEdgesCount()
        {
            return Edges.Count;
        }

        public IEnumerable<IPairValue<T>> GetEdges()
        {
            return Edges;
        }

        public int GetVerticesCount()
        {
            return Vertices.Count;
        }

        public IEnumerable<T> GetVertices()
        {
            return Vertices;
        }

        public abstract K GetWeight(T v1, T v2);

        public abstract int InDegree(T vertex);

        public abstract int OutDegree(T vertex);
    }
}