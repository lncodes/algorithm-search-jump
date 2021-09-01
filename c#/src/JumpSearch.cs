using System;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Jump
{
    public sealed class JumpSearch
    {
        /// <summary>
        /// Method for jump search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="element"></param>
        /// <returns cref="int"></returns>
        public int Search<T>(IReadOnlyList<T> data, T element) where T : IComparable 
        {
            var currentIndex = 0;
            var maxIndex = data.Count - 1;
            var jumpDistance = (int)Math.Sqrt(data.Count);
            var currentRangeMaxIndex = jumpDistance;

            while (data[Math.Min(currentRangeMaxIndex, maxIndex)].CompareTo(element) < 0)
            {
                currentIndex = currentRangeMaxIndex;
                currentRangeMaxIndex += jumpDistance;
                if (currentIndex > maxIndex)
                    return -1;
            }

            while (data[currentIndex].CompareTo(element) < 0)
            {
                currentIndex++;
                if (currentIndex > Math.Min(currentRangeMaxIndex, maxIndex))
                    return -1;
            }

            return data[currentIndex].Equals(element) ? currentIndex : -1;
        }
    }
}
