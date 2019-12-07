namespace MailingTool.EditClients
{
    partial class ClientsForm
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
            this.personRecipientTable1 = new MailingTool.EditClients.PersonRecipientTable();
            this.SuspendLayout();
            // 
            // personRecipientTable1
            // 
            this.personRecipientTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personRecipientTable1.Location = new System.Drawing.Point(0, 0);
            this.personRecipientTable1.Name = "personRecipientTable1";
            this.personRecipientTable1.Size = new System.Drawing.Size(534, 361);
            this.personRecipientTable1.TabIndex = 0;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.personRecipientTable1);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonRecipientTable personRecipientTable1;
    }
}