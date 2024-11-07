namespace LearnTeach
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Типы ссылок");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Объявление классов");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Создание объектов");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Конструкторы и инициализация");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Наследование классов");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Общие сведения", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Поля и методы класса");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Создание объекта класса");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Конструктор по умолчанию");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Обращение к функциональности класса");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Добавление класса");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Классы и объекты", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Поля класса");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Конструкторы");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Инициализаторы объектов");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Собственные структуры");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Итог");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Дополнительный материал", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearTextButton = new System.Windows.Forms.Button();
            this.TestPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMainTest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelBar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(1022, 2);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 91);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.TestPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1904, 1011);
            this.tabControl1.TabIndex = 4;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.splitContainer1);
            this.MainPage.Location = new System.Drawing.Point(4, 29);
            this.MainPage.Margin = new System.Windows.Forms.Padding(2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(2);
            this.MainPage.Size = new System.Drawing.Size(1896, 978);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1892, 974);
            this.splitContainer1.SplitterDistance = 726;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // MainTreeView
            // 
            this.MainTreeView.CheckBoxes = true;
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.MainTreeView.Name = "MainTreeView";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Типы ссылок";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Объявление классов";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "Создание объектов";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Конструкторы и инициализация";
            treeNode5.Name = "Узел5";
            treeNode5.Text = "Наследование классов";
            treeNode6.Name = "Узел0";
            treeNode6.Text = "Общие сведения";
            treeNode7.Name = "Узел1";
            treeNode7.Text = "Поля и методы класса";
            treeNode8.Name = "Узел4";
            treeNode8.Text = "Создание объекта класса";
            treeNode9.Name = "Узел5";
            treeNode9.Text = "Конструктор по умолчанию";
            treeNode10.Name = "Узел6";
            treeNode10.Text = "Обращение к функциональности класса";
            treeNode11.Name = "Узел7";
            treeNode11.Text = "Добавление класса";
            treeNode12.Name = "Узел0";
            treeNode12.Text = "Классы и объекты";
            treeNode13.Name = "Узел1";
            treeNode13.Text = "Поля класса";
            treeNode14.Name = "Узел2";
            treeNode14.Text = "Конструкторы";
            treeNode15.Name = "Узел3";
            treeNode15.Text = "Инициализаторы объектов";
            treeNode16.Name = "Узел4";
            treeNode16.Text = "Собственные структуры";
            treeNode17.Name = "Узел5";
            treeNode17.Text = "Итог";
            treeNode18.Name = "Узел0";
            treeNode18.Text = "Дополнительный материал";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode18});
            this.MainTreeView.Size = new System.Drawing.Size(726, 974);
            this.MainTreeView.TabIndex = 1;
            this.MainTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterCheck);
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.87952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.12048F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 974);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(2, 2);
            this.TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(1159, 871);
            this.TextBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.Controls.Add(this.BackButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClearTextButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 877);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1159, 95);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ClearTextButton
            // 
            this.ClearTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearTextButton.Location = new System.Drawing.Point(2, 2);
            this.ClearTextButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearTextButton.Name = "ClearTextButton";
            this.ClearTextButton.Size = new System.Drawing.Size(997, 91);
            this.ClearTextButton.TabIndex = 2;
            this.ClearTextButton.Text = "Очистить поле";
            this.ClearTextButton.UseVisualStyleBackColor = true;
            this.ClearTextButton.Click += new System.EventHandler(this.ClearTextButton_Click);
            // 
            // TestPage
            // 
            this.TestPage.Controls.Add(this.splitContainer2);
            this.TestPage.Location = new System.Drawing.Point(4, 29);
            this.TestPage.Margin = new System.Windows.Forms.Padding(2);
            this.TestPage.Name = "TestPage";
            this.TestPage.Padding = new System.Windows.Forms.Padding(2);
            this.TestPage.Size = new System.Drawing.Size(1896, 978);
            this.TestPage.TabIndex = 1;
            this.TestPage.Text = "Тесты";
            this.TestPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox4);
            this.splitContainer2.Panel2.Controls.Add(this.textBox3);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1892, 974);
            this.splitContainer2.SplitterDistance = 968;
            this.splitContainer2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(106, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(711, 895);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.buttonMainTest);
            this.panel4.Location = new System.Drawing.Point(9, 677);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 206);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(124, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 80);
            this.label4.TabIndex = 1;
            this.label4.Text = "      ОСНОВНОЙ ТЕСТ\r\nпо пройденному материалу\r\n";
            // 
            // buttonMainTest
            // 
            this.buttonMainTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonMainTest.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainTest.Location = new System.Drawing.Point(215, 111);
            this.buttonMainTest.Name = "buttonMainTest";
            this.buttonMainTest.Size = new System.Drawing.Size(238, 83);
            this.buttonMainTest.TabIndex = 0;
            this.buttonMainTest.Text = " ПРОЙТИ ТЕСТ ";
            this.buttonMainTest.UseVisualStyleBackColor = true;
            this.buttonMainTest.Click += new System.EventHandler(this.buttonMainTest_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonTest3);
            this.panel3.Location = new System.Drawing.Point(9, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 149);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(144, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 70);
            this.label3.TabIndex = 1;
            this.label3.Text = "            ТЕСТ №3\r\nпо разделу \"Общие сведения\"";
            // 
            // buttonTest3
            // 
            this.buttonTest3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTest3.BackColor = System.Drawing.Color.Snow;
            this.buttonTest3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest3.Location = new System.Drawing.Point(215, 99);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(238, 38);
            this.buttonTest3.TabIndex = 0;
            this.buttonTest3.Text = " ПРОЙТИ ТЕСТ ";
            this.buttonTest3.UseVisualStyleBackColor = false;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.buttonTest2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 149);
            this.panel2.TabIndex = 5;
            // 
            // buttonTest2
            // 
            this.buttonTest2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTest2.BackColor = System.Drawing.Color.Snow;
            this.buttonTest2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest2.Location = new System.Drawing.Point(215, 95);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(238, 38);
            this.buttonTest2.TabIndex = 2;
            this.buttonTest2.Text = " ПРОЙТИ ТЕСТ ";
            this.buttonTest2.UseVisualStyleBackColor = false;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(145, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "            ТЕСТ №2 \r\nпо разделу \"Классы и объекты\"";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.buttonTest1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 149);
            this.panel1.TabIndex = 4;
            // 
            // buttonTest1
            // 
            this.buttonTest1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTest1.BackColor = System.Drawing.Color.Snow;
            this.buttonTest1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest1.Location = new System.Drawing.Point(215, 98);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(238, 38);
            this.buttonTest1.TabIndex = 3;
            this.buttonTest1.Text = " ПРОЙТИ ТЕСТ ";
            this.buttonTest1.UseVisualStyleBackColor = false;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "            ТЕСТ №1\r\nпо разделу \"Общие сведения\"";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(11, 692);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(791, 206);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(8, 455);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(791, 149);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(8, 237);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(791, 149);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(11, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(791, 149);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(1539, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // labelBar
            // 
            this.labelBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBar.AutoSize = true;
            this.labelBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBar.Location = new System.Drawing.Point(1479, 3);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(43, 24);
            this.labelBar.TabIndex = 5;
            this.labelBar.Text = "0 %";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1011);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TestPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage TestPage;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ClearTextButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMainTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTest3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Panel panel5;
    }
}