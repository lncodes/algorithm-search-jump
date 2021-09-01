using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Jump.Test
{
    public sealed class JumpSearchTest
    {
        [Theory]
        [ClassData(typeof(JumpSearchTheoryData))]
        public void Search_Jump_ShouldEqual(IReadOnlyList<int> data, int element, int expected)
        {
            var instance = new JumpSearch();
            var actual = instance.Search(data, element);
            Assert.Equal(expected, actual);
        }
    }
}
