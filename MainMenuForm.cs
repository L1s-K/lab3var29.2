namespace lab3var29._2
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

        }
        BinaryTree tree = new BinaryTree();
        private TextBox[] nodeTextBoxes; // Массив для хранения TextBox'ов
        private int nodeCount = 0;

        private void оToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Юхневич Г.С.\nГруппа: 6106-090301D");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void создатьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxWithElementsCount.Text, out nodeCount) && nodeCount > 0)
            {
                ClearNodeTextBoxes();
                tree.Root = tree.CreateBalanced(nodeCount);
                nodeTextBoxes = new TextBox[nodeCount];

                int currentIndex = 0;
                DisplayInputControls(tree.Root, this.Width / 2, 50, this.Width / 4, ref currentIndex);
            }
            else
            {
                MessageBox.Show("Введите корректное количество элементов (положительное число)");
            }
        }





        private void DisplayInputControls(TreeNode root, int x, int y, int offsetX, ref int index)
        {
            if (root != null || index < nodeTextBoxes.Length)
            {

                nodeTextBoxes[index] = new TextBox
                {
                    Width = 50,
                    Location = new Point(x, y),
                    Tag = root
                };
                Controls.Add(nodeTextBoxes[index]);
                index++;


                if (root.Left != null)
                {
                    DisplayInputControls(root.Left, x - offsetX, y + 50, offsetX / 2, ref index);
                }


                if (root.Right != null)
                {
                    DisplayInputControls(root.Right, x + offsetX, y + 50, offsetX / 2, ref index);
                }
            }



        }


        private void ClearNodeTextBoxes()
        {
            if (nodeTextBoxes != null)
            {
                for (int i = 0; i < nodeTextBoxes.Length; i++)
                {
                    if (nodeTextBoxes[i] != null)
                    {
                        Controls.Remove(nodeTextBoxes[i]);
                        nodeTextBoxes[i].Dispose();
                    }
                }
            }
            nodeTextBoxes = null;
        }


        private void FillTreeFromTextBoxes()
        {
            for (int i = 0; i < nodeTextBoxes.Length; i++)
            {
                
                if (nodeTextBoxes[i] != null && nodeTextBoxes[i].Tag is TreeNode node)
                {
                    string text = nodeTextBoxes[i].Text;

                    double num;
                    if (double.TryParse(text, out num))
                    {
                        node.NodeType = 'n';
                        node.Data = num;
                    }
                    else if (text.Length == 1 && IsOperator(text))
                    {
                        node.NodeType = char.Parse(text);
                    }
                }
            }
        }

        private bool IsOperator(string text)
        {
            char temp = char.Parse(text);
            bool result = false;
            if (temp == '+' || temp == '-' || temp == '*' || temp == '/')
            {
                result = true;
            }
            return result;

        }


        private void разрушениеДереваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.Root = null;
            ClearNodeTextBoxes();
        }

        private void обработкаДереваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeTextBoxes == null || tree.Root == null)
            {
                MessageBox.Show("Сначала создайте дерево");
            }
            else
            {

                FillTreeFromTextBoxes();

                if (tree.CanCreateArithmeticTree(tree.Root))
                {
                    MessageBox.Show("Дерево арифметическое");
                    string formula = tree.TreeToFormula(tree.Root);
                    MessageBox.Show($"Формула: {formula}\nРезультат: {tree.ArTreeCalculation(tree.Root)}");
                }
                else
                {
                    MessageBox.Show("Дерево не является арифметическим");
                }


            }

        }
    }
}
