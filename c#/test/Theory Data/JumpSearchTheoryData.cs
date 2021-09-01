﻿using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Jump.Test
{
    public sealed class JumpSearchTheoryData : TheoryData<IReadOnlyList<int>, int, int>
    {
        public JumpSearchTheoryData()
        {
            Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9);
            Add(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 1, 0);
            Add(new int[] { 2, 4, 6, 8, 10, 12, 14, 16 }, 10, 4);
        }
    }
}