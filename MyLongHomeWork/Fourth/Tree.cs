namespace MyLongHomeWork
{
    public class Tree : ITree
    {
        TreeNode root { get; set; }


        public void AddItem(int value)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Value = value;

                return;
            }
            DoAdd(value, root);
        }

        private void DoAdd(int value, TreeNode node)
        {
            if (node == null) throw new InvalidOperationException();
            if (node.Value > value)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new TreeNode();
                    node.LeftChild.Value = value;
                    return;
                }
                DoAdd(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new TreeNode();
                    node.RightChild.Value = value;
                    return;
                }
                DoAdd(value, node.RightChild);
            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            return DoFindNodeByValue(value, root);
        }

        private TreeNode DoFindNodeByValue(int value, TreeNode node)
        {
            if (node == null)
            {
                throw new InvalidOperationException();
            }
            if (node.Value == value)
            {
                return node;
            }

            if (node.Value > value)
            {
                if (node.LeftChild == null)
                {
                    return null;
                }
                return DoFindNodeByValue(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                {
                    return null;
                }
                return DoFindNodeByValue(value, node.RightChild);
            }

        }

        public TreeNode GetRoot()
        {
            return root;
        }

        public void PrintTree()
        {
            if (root == null)
            {
                return;
            }
            int treeLength = GetLength(root);
            double maxWidth = Math.Pow(2, treeLength - 1) * 3;
            double initialX = maxWidth / 2;
            DoPrintTree((int)initialX, 1, root);
        }

        private void DoPrintTree(int x, int y, TreeNode node)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(node.Value);
            Console.CursorTop = ++y;
            Console.CursorLeft -= 1;
            Console.Write('/');
            Console.CursorLeft += 1;
            Console.Write('\\');
            Console.CursorTop = ++y;

            if (node.LeftChild != null)
                DoPrintTree(x - 2, y, node.LeftChild);
            if (node.RightChild != null)
                DoPrintTree(x + 2, y, node.RightChild);
        }

        private int GetLength(TreeNode node, int counter = 0)
        {
            if (node == null)
            {
                return counter;
            }
            if (node.LeftChild == null && node.RightChild == null)
            {
                return counter + 1;
            }
            if (node.LeftChild == null)
            {
                return GetLength(node.RightChild, counter + 1);
            }
            if (node.RightChild == null)
            {
                return GetLength(node.LeftChild, counter + 1);
            }
            return Math.Max(GetLength(node.LeftChild, counter + 1), GetLength(node.RightChild, counter + 1));
        }

        public void RemoveItem(int value)
        {
            DoRemoveItem(value, root);
        }

        private void DoRemoveItem(int value, TreeNode node)
        {
            if (node == null)
            {
                throw new InvalidOperationException();
            }
            if (node.Value == value && node == root)
            {
                root = null;
                return;
            }
            if (node.Value > value)
            {
                if (node.LeftChild == null)
                {
                    return;
                }
                if (node.LeftChild.Value == value)
                {
                    node.LeftChild = null;
                    return;
                }
                DoRemoveItem(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                {
                    return;
                }
                if (node.RightChild.Value == value)
                {
                    node.RightChild = null;
                    return;
                }
                DoRemoveItem(value, node.RightChild);
            }



        }
        public TreeNode BFS(int s)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(BFS(s));
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                Console.WriteLine($"Watching: {node.Value}");
                if (node.Value == s)
                {
                    return node;
                }

                stack.Push(node.LeftChild);
                stack.Push(node.RightChild);

            }

            return null;

        }

        private TreeNode DFCRecursive(int s, TreeNode node)
        {
            Console.WriteLine($"Watching: {node.Value}");
            if (node == null)
            {
                throw new InvalidOperationException();
            }
            if (s == node.Value)
            {
                return node;
            }
            if (node.LeftChild != null)
            {
                var result = DFCRecursive(s, node.LeftChild);
                if (result != null)
                {
                    return result;
                }
            }
            if (node.RightChild != null)
            {
                var result = DFCRecursive(s, node.RightChild);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        public TreeNode DFS(int value)
        {
            return DFCRecursive(value, root);
        }
    }
}






