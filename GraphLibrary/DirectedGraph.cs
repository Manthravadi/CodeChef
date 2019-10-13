using System;
using System.Collections.Generic;

namespace GraphLibrary
{
    public class DirectedGraph<T, K> : Graph<T, K>
    {
        public override bool AddEdge(T v1, T v2, K weight)
        {
            bool isAdded = false;
            if (v1 == null || v2 == null || weight == null)
            {
                throw new ArgumentNullException();
            }
            if (Vertices.Contains(v1) && Vertices.Contains(v2))
            {
                var pair = new PairValue<T>(v1, v2);
                Edges.Add(pair);
                Weights[pair] = weight;
                isAdded = true;
            }
            return isAdded;
        }
       

        public override void GetWeight(T v1, T v2)
        {
            if (v1 == null || v2 == null)
            {
                throw new ArgumentNullException();
            }

        }



    }
}