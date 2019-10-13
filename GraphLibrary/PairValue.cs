using System;

namespace GraphLibrary
{
    public class PairValue<T> : IPairValue<T>
    {
        private readonly T _t1;
        private readonly T _t2;

        public PairValue(T t1, T t2)
        {
            if (t1 == null || t2 == null)
            {
                throw new ArgumentNullException();
            }
            if (t1.GetType() != t2.GetType())
            {
                throw new ArgumentException("Type of both values needs to be same");
            }
            _t1 = t1;
            _t2 = t2;
        }
        public bool ContainsValue(T value)
        {
            return value.Equals(_t1) || value.Equals(_t2);
        }

        public T GetFirst()
        {
            return _t1;
        }

        public T GetSecond()
        {
            return _t2;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = false;
            if (obj == null || obj.GetType() != typeof(PairValue<T>))
            {
                isEqual = false;
            }
            PairValue<T> casted = (PairValue<T>)obj;
            if (casted._t1.Equals(_t1) && casted._t2.Equals(_t2))
            {
                isEqual = true;
            }
            return isEqual;
        }

        /// <summary>
        /// Returns sum of individual hashcodes of _t1 and _t2
        /// </summary>
        /// <returns>int</returns>
        public override int GetHashCode()
        {
            return _t1.GetHashCode() + _t2.GetHashCode();
        }
    }
}