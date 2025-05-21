namespace lab3var29._2
{
    public class TreeNode
    {
        private char nodeType;
        private TreeNode left;
        private TreeNode right;
        private double data;

        public char NodeType
        {
            get { return nodeType; }
            set { nodeType = value; }
        }
        public double Data
        {
            get { return data; }
            set { data = value; }
        }
        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public TreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public TreeNode() { }
        public TreeNode(char nodeType)
        {
            NodeType = nodeType;
        }
        public TreeNode(char nodeType, double data, TreeNode left, TreeNode right)
        {
            NodeType = nodeType;
            Data = data;
            Left = left;
            Right = right;
        }
    }

    public class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public BinaryTree()
        {
            root = null;
        }

        public TreeNode CreateBalanced(int n)
        {
            TreeNode node = new TreeNode();
            if (n > 0)
            {
                node.Left = CreateBalanced(n / 2);
                node.Right = CreateBalanced(n - (n / 2) - 1);
            }
            else
            {
                node = null;
            }
            return node;
        }

        internal double ArTreeCalculation(TreeNode root)
        {
            double mainResult = 0;
            if (root != null)
            {
                double leftResult = ArTreeCalculation(root.Left);
                double rightResult = ArTreeCalculation(root.Right);

                if (root.Left == null && root.Right == null)
                {
                    mainResult = root.Data;
                }


                switch (root.NodeType)
                {
                    case '+':
                        mainResult = leftResult + rightResult;
                        break;
                    case '-':
                        mainResult = leftResult - rightResult;
                        break;
                    case '*':
                        mainResult = leftResult * rightResult;
                        break;
                    case '/':
                        mainResult = leftResult / rightResult;
                        break;
                }
            }
            return Math.Round(mainResult, 4);
        }

        public bool CanCreateArithmeticTree(TreeNode root)
        {
            bool result = false;

            if (root != null)
            {
                bool currentNodeResult = false;
                bool leftSubtreeResult = true;
                bool rightSubtreeResult = true;


                if (root.Left == null && root.Right == null)
                {
                    currentNodeResult = !IsNodeOperator(root);
                }
                else if (root.Left != null && root.Right != null)
                {
                    currentNodeResult = IsNodeOperator(root);
                }


                if (root.Left != null)
                {
                    leftSubtreeResult = CanCreateArithmeticTree(root.Left);
                }

                if (root.Right != null)
                {
                    rightSubtreeResult = CanCreateArithmeticTree(root.Right);
                }


                result = currentNodeResult && leftSubtreeResult && rightSubtreeResult;
            }

            return result;
        }

        private bool IsNodeOperator(TreeNode root)
        {
            bool result = false;
            if (root.NodeType == '+' || root.NodeType == '-' || root.NodeType == '*' || root.NodeType == '/')
            {
                result = true;
            }
            return result;
        }
        public string TreeToFormula(TreeNode root)
        {
            string result = "";

            if (root != null)
            {
                if (root.Left == null && root.Right == null)
                {
                    if (root.NodeType == 'n')
                    {
                        result = root.Data.ToString();
                    }
                }
                else
                {
                    result = "(" + TreeToFormula(root.Left) + " " + root.NodeType + " " + TreeToFormula(root.Right) + ")";
                }
            }

            return result;
        }

        public void ConfigTextboxesForNewTree(ref TextBox[] textBoxes, TreeNode root, int x, int y, int deltaX, ref int index)
        {

            if (root != null)
            {

                textBoxes[index] = new TextBox
                {
                    Width = 50,
                    Location = new Point(x, y),
                    Tag = root
                };
                index++;


                if (root.Left != null)
                {
                    ConfigTextboxesForNewTree(ref textBoxes, root.Left, x - deltaX, y + 50, deltaX / 2, ref index);
                }


                if (root.Right != null)
                {
                    ConfigTextboxesForNewTree(ref textBoxes, root.Right, x + deltaX, y + 50, deltaX / 2, ref index);
                }

            }
            else
            {
                textBoxes = null;
            }

        }

    }
}
