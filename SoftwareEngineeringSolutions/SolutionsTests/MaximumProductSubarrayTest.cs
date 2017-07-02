using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionsTests
{
    [TestClass]
    public class MaximumProductSubarrayTest : TestBase<MaximumProductSubarray>
    {
        [TestMethod]
        public void Test()
        {
            var a1 = new [] {6, -3, -10, 0, 2};

            var a2 = new[] { -1, -3, -10, 0, 60 };

            var a3 = new[] { -2, -3, 0, -2, -40 };

            var a2Result = Solution.Solve(a2);

            Assert.AreEqual(a2Result, 60);
        }
    }
}
