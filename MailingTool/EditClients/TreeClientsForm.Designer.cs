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
            this.editPersonButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(442, 394);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(121, 23);
            this.editPersonButton.TabIndex = 4;
            this.editPersonButton.Text = "Редактировать";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.delPersonButton_Click);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Организация";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Получатель";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Эл. почта";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Заметки";
            this.columnHeader4.Width = 73;
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.personsListView.FullRowSelect = true;
            this.personsListView.Location = new System.Drawing.Point(11, 99);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(552, 289);
            this.personsListView.TabIndex = 2;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            this.personsListView.VirtualMode = true;
            this.personsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsListView_RetrieveVirtualItem);
            this.personsListView.SelectedIndexChanged += new System.EventHandler(this.personsListView_SelectedIndexChanged);
            this.personsListView.DoubleClick += new System.EventHandler(this.editPersonButton_Click);
            // 
            // TreeClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 429);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.personsListView);
            this.Name = "TreeClientsForm";
            this.Text = "TreeClientsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreeClientsForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView personsListView;
    }
}