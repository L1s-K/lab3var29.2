namespace lab3var29._2
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            оToolStripMenuItem = new ToolStripMenuItem();
            заданиеToolStripMenuItem = new ToolStripMenuItem();
            созданиеДереваToolStripMenuItem = new ToolStripMenuItem();
            AskToChooseCountOfElementsTextBox = new ToolStripTextBox();
            TextBoxWithElementsCount = new ToolStripTextBox();
            создатьДеревоToolStripMenuItem = new ToolStripMenuItem();
            обработкаДереваToolStripMenuItem = new ToolStripMenuItem();
            разрушениеДереваToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { оToolStripMenuItem, заданиеToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // оToolStripMenuItem
            // 
            оToolStripMenuItem.Name = "оToolStripMenuItem";
            оToolStripMenuItem.Size = new Size(94, 20);
            оToolStripMenuItem.Text = "О программе";
            оToolStripMenuItem.Click += оToolStripMenuItem_Click;
            // 
            // заданиеToolStripMenuItem
            // 
            заданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { созданиеДереваToolStripMenuItem, обработкаДереваToolStripMenuItem, разрушениеДереваToolStripMenuItem });
            заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            заданиеToolStripMenuItem.Size = new Size(64, 20);
            заданиеToolStripMenuItem.Text = "Задание";
            // 
            // созданиеДереваToolStripMenuItem
            // 
            созданиеДереваToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AskToChooseCountOfElementsTextBox, TextBoxWithElementsCount, создатьДеревоToolStripMenuItem });
            созданиеДереваToolStripMenuItem.Name = "созданиеДереваToolStripMenuItem";
            созданиеДереваToolStripMenuItem.Size = new Size(182, 22);
            созданиеДереваToolStripMenuItem.Text = "Создание дерева";
            // 
            // AskToChooseCountOfElementsTextBox
            // 
            AskToChooseCountOfElementsTextBox.Enabled = false;
            AskToChooseCountOfElementsTextBox.Name = "AskToChooseCountOfElementsTextBox";
            AskToChooseCountOfElementsTextBox.Size = new Size(250, 23);
            AskToChooseCountOfElementsTextBox.Text = "Введите количество элементов для дерева";
            // 
            // TextBoxWithElementsCount
            // 
            TextBoxWithElementsCount.Name = "TextBoxWithElementsCount";
            TextBoxWithElementsCount.Size = new Size(100, 23);
            // 
            // создатьДеревоToolStripMenuItem
            // 
            создатьДеревоToolStripMenuItem.Name = "создатьДеревоToolStripMenuItem";
            создатьДеревоToolStripMenuItem.Size = new Size(310, 22);
            создатьДеревоToolStripMenuItem.Text = "Создать дерево";
            создатьДеревоToolStripMenuItem.Click += создатьДеревоToolStripMenuItem_Click;
            // 
            // обработкаДереваToolStripMenuItem
            // 
            обработкаДереваToolStripMenuItem.Name = "обработкаДереваToolStripMenuItem";
            обработкаДереваToolStripMenuItem.Size = new Size(182, 22);
            обработкаДереваToolStripMenuItem.Text = "Обработка дерева";
            обработкаДереваToolStripMenuItem.Click += обработкаДереваToolStripMenuItem_Click;
            // 
            // разрушениеДереваToolStripMenuItem
            // 
            разрушениеДереваToolStripMenuItem.Name = "разрушениеДереваToolStripMenuItem";
            разрушениеДереваToolStripMenuItem.Size = new Size(182, 22);
            разрушениеДереваToolStripMenuItem.Text = "Разрушение дерева";
            разрушениеДереваToolStripMenuItem.Click += разрушениеДереваToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenuForm";
            Text = "Cбалансированное дерево";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem оToolStripMenuItem;
        private ToolStripMenuItem заданиеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem созданиеДереваToolStripMenuItem;
        private ToolStripMenuItem обработкаДереваToolStripMenuItem;
        private ToolStripMenuItem разрушениеДереваToolStripMenuItem;
        private ToolStripTextBox AskToChooseCountOfElementsTextBox;
        private ToolStripTextBox TextBoxWithElementsCount;
        private ToolStripMenuItem создатьДеревоToolStripMenuItem;
    }
}
