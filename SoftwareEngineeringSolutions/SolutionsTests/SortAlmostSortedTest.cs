using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionsTests
{
    [TestClass]
    public class SortAlmostSortedTest : TestBase<SortAlmostSorted>
    {
        [TestMethod]
        public void Test()
        {
            var a = new[] {10, 20, 60, 40, 50, 30};
            try
            {
                Solution.Solve(a);
            }
            catch
            {
                Assert.Fail("Oops.");
            }
            for (var i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] < a[i])
                {
                    Assert.Fail("The array is not sorted.");
                }
            }

            Assert.IsTrue(true);
        }
    }
}