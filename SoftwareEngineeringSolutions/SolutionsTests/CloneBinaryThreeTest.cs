using Common.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionsTests
{
    [TestClass]
    public class CloneBinaryThreeTest : TestBase<CloneBinaryTree>
    {
        [TestMethod]
        public void Test()
        {
            var tree = new BinaryTree<int>(new [] {3, 7, 5, 9, 2});
            var resultTree = Solution.Solve(tree);
            var result = Check(tree.Root, resultTree.Root);
            Assert.IsTrue(result);
        }

        private static bool Check<T>(Node<T> node1, Node<T> node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            // both are not null
            if (!node1.Value.Equals(node2.Value))
            {
                return false;
            }

            var checkLeft = Check(node1.Left, node2.Left);
            if (!checkLeft)
            {
                return false;
            }

            return Check(node1.Right, node2.Right);
        }
    }
}