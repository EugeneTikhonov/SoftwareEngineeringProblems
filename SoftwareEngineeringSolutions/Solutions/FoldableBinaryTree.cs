using Common.Trees;

namespace Solutions
{
    public class FoldableBinaryTree
    {
        public bool Solve<T>(BinaryTree<T> tree)
        {
            var result = AreMirrors(tree.Root.Left, tree.Root.Right);
            return result;
        }

        private bool AreMirrors<T>(Node<T> l, Node<T> r)
        {
            if (l == null && r == null)
            {
                return true;
            }

            if (l == null && r != null || l != null && r == null)
            {
                return false;
            }

            var leftRes = AreMirrors<T>(l.Left, r.Right);
            if (leftRes)
            {
                return AreMirrors<T>(l.Right, r.Left);
            }
            return false;
        }
    }
}