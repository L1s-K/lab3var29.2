namespace lab3var29._2
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        BinaryTree tree = new BinaryTree();
        private TextBox[] nodeTextBoxes;
        private int nodeCount = 0;

        private void îToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Àâòîð: Þõíåâè÷ Ã.Ñ.\nÃðóïïà: 6106-090301D");
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void ñîçäàòüÄåðåâîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(TextBoxWithElementsCount.Text, out nodeCount) && nodeCount > 0)
            {
                DeleteTextBoxes();
                
                tree.Root = tree.CreateBalanced(nodeCount);
                nodeTextBoxes = new TextBox[nodeCount];

                int currentIndex = 0;
                DisplayTextBox(tree.Root, this.Width / 2, 50, this.Width / 4, ref currentIndex);
            }
            else
            {
                MessageBox.Show("Ââåäèòå êîððåêòíîå êîëè÷åñòâî ýëåìåíòîâ (ïîëîæèòåëüíîå ÷èñëî)");
            }
        }





        private void DisplayTextBox(TreeNode root, int x, int y, int deltaX, ref int index) // спрятать "корни" в класс дерева, а как их спрятать если я связываю textbox с узлом дерева
        {
            if (root != null)
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
                    DisplayTextBox(root.Left, x - deltaX, y + 50, deltaX / 2, ref index);
                }


                if (root.Right != null)
                {
                    DisplayTextBox(root.Right, x + deltaX, y + 50, deltaX / 2, ref index);
                }
            }



        }


        private void DeleteTextBoxes()
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


        private void ðàçðóøåíèåÄåðåâàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.Root = null;
            nodeCount = 0;
            DeleteTextBoxes();
        }

        private void îáðàáîòêàÄåðåâàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeTextBoxes == null || tree.Root == null)
            {
                MessageBox.Show("Ñíà÷àëà ñîçäàéòå äåðåâî");
            }
            else
            {

                FillTreeFromTextBoxes();

                if (tree.CanCreateArithmeticTree(tree.Root))
                {
                    string formula = tree.TreeToFormula(tree.Root);
                    MessageBox.Show("Äåðåâî àðèôìåòè÷åñêîå\nÔîðìóëà: " + formula + "\nÐåçóëüòàò:  " + tree.ArTreeCalculation(tree.Root));


                }
                else
                {
                    MessageBox.Show("Äåðåâî íå ÿâëÿåòñÿ àðèôìåòè÷åñêèì");
                }


            }

        }
    }
}
