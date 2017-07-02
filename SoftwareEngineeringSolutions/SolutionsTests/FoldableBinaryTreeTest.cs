using System.Runtime.InteropServices.ComTypes;
using Common.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace SolutionsTests
{
    [TestClass]
    public class FoldableBinaryTreeTest : TestBase<FoldableBinaryTree>
    {
        [TestMethod]
        public void Test()
        {
            var root = new Node<int>(5);
            root.Left = new Node<int>(3);
            root.Left.Left = new Node<int>(32);
            root.Left.Left.Right = new Node<int>(23);
            root.Left.Right = new Node<int>(543);

            root.Right = new Node<int>(9);
            root.Right.Left = new Node<int>(4);
            root.Right.Right = new Node<int>(74);
            root.Right.Right.Left = new Node<int>(79);

            var result = Solution.Solve(new BinaryTree<int>(root));
            Assert.IsTrue(result, "NOT");
        }
    }
}