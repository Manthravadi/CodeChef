using System;

namespace GraphLibrary
{
    /// <summary>
    /// Simple data structure to store a pair of vertices
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPairValue<T>
    {
        /// <summary>
        /// Returns first vertex
        /// </summary>
        /// <returns>T</returns>
        T GetFirst();

        /// <summary>
        /// Returns second vertex
        /// </summary>
        /// <returns>T</returns>
        T GetSecond();

        /// <summary>
        /// Returns true if the given value is stored in the data structure
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        bool ContainsValue(T value);
    }
}