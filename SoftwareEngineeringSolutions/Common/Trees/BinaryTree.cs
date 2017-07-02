using System;
using System.Linq;

namespace Common.Trees
{
    public class BinaryTree<T>
    {
        public BinaryTree(T[] source)
        {
            if (source == null || !source.Any())
            {
                return;
            }
            Root = new Node<T>(source[0]);
            var r = new Random();
            for (var i = 1; i < source.Length; i++)
            {
                var inserted = false;
                var current = Root;
                while (!inserted)
                {
                    var isLeft = r.Next(1, 100) % 2 == 0;
                    if (isLeft)
                    {
                        var left = current.Left;
                        inserted = InsertionGoDeep(ref left, source[i]);
                        current.Left = left;
                        current = current.Left;
                    }
                    else
                    {
                        var right = current.Right;
                        inserted = InsertionGoDeep(ref right, source[i]);
                        current.Right = right;
                        current = current.Right;
                    }
                }
            }
        }

        public BinaryTree(Node<T> root)
        {
            Root = root;
        }

        public Node<T> Root { get; }

        private bool InsertionGoDeep(ref Node<T> current, T value)
        {
            if (current == null)
            {
                current = new Node<T>(value);
                return true;
            }
            return false;
        }
    }
}