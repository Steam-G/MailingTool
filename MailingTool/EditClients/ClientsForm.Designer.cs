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
            this.eventRecipientVal1 = new MailingTool.EditClients.EventRecipientVal();
            this.personRecipientTable1 = new MailingTool.EditClients.PersonRecipientTable();
            this.SuspendLayout();
            // 
            // eventRecipientVal1
            // 
            this.eventRecipientVal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventRecipientVal1.Location = new System.Drawing.Point(583, 0);
            this.eventRecipientVal1.MinimumSize = new System.Drawing.Size(200, 150);
            this.eventRecipientVal1.Name = "eventRecipientVal1";
            this.eventRecipientVal1.Size = new System.Drawing.Size(200, 361);
            this.eventRecipientVal1.TabIndex = 2;
            // 
            // personRecipientTable1
            // 
            this.personRecipientTable1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personRecipientTable1.Location = new System.Drawing.Point(0, 0);
            this.personRecipientTable1.Margin = new System.Windows.Forms.Padding(0);
            this.personRecipientTable1.Name = "personRecipientTable1";
            this.personRecipientTable1.Size = new System.Drawing.Size(580, 361);
            this.personRecipientTable1.TabIndex = 0;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 361);
            this.Controls.Add(this.eventRecipientVal1);
            this.Controls.Add(this.personRecipientTable1);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonRecipientTable personRecipientTable1;
        private EventRecipientVal eventRecipientVal1;
    }
}