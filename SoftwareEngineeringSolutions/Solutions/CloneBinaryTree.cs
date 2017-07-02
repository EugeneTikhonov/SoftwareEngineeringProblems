using Common.Trees;

namespace Solutions
{
    public class CloneBinaryTree
    {
        public BinaryTree<T> Solve<T>(BinaryTree<T> source)
        {
            var resultRoot = CloneNode(source.Root);
            var result = new BinaryTree<T>(resultRoot);
            return result;
        }

        private Node<T> CloneNode<T>(Node<T> node)
        {
            var newNode = new Node<T>(node.Value);

            if (node.Left != null)
            {
                newNode.Left = CloneNode(node.Left);
            }

            if (node.Right != null)
            {
                newNode.Right = CloneNode(node.Right);
            }

            return newNode;
        }
    }
}