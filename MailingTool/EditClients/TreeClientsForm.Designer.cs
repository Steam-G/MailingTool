namespace MailingTool
{
    partial class TreeClientsForm
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
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Узел7");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Узел1", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Узел3");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Узел4");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Узел5");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Узел2", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Узел8");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Узел9");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.personsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addPersonButton = new System.Windows.Forms.Button();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HotTracking = true;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode41.Name = "Узел6";
            treeNode41.Text = "Узел6";
            treeNode42.Name = "Узел7";
            treeNode42.Text = "Узел7";
            treeNode43.Name = "Узел1";
            treeNode43.Text = "Узел1";
            treeNode44.Name = "Узел3";
            treeNode44.Text = "Узел3";
            treeNode45.Name = "Узел4";
            treeNode45.Text = "Узел4";
            treeNode46.Name = "Узел5";
            treeNode46.Text = "Узел5";
            treeNode47.Name = "Узел2";
            treeNode47.Text = "Узел2";
            treeNode48.Name = "Узел0";
            treeNode48.Text = "Узел0";
            treeNode49.Name = "Узел8";
            treeNode49.Text = "Узел8";
            treeNode50.Name = "Узел9";
            treeNode50.Text = "Узел9";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(234, 81);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить корневой элемент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить дочерний элемент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Удалить элемент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.personsListView.FullRowSelect = true;
            this.personsListView.Location = new System.Drawing.Point(12, 99);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(420, 289);
            this.personsListView.TabIndex = 2;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            this.personsListView.VirtualMode = true;
            this.personsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsListView_RetrieveVirtualItem);
            this.personsListView.SelectedIndexChanged += new System.EventHandler(this.personsListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Возраст";
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(12, 394);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(107, 23);
            this.addPersonButton.TabIndex = 3;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(310, 394);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(121, 23);
            this.editPersonButton.TabIndex = 4;
            this.editPersonButton.Text = "Редактировать";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail";
            this.columnHeader4.Width = 168;
            // 
            // TreeClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 429);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.personsListView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeClientsForm";
            this.Text = "TreeClientsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button editPersonButton;
    }
}