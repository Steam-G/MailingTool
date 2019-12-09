namespace MailingTool.EditClients
{
    partial class EventRecipientVal
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkedListBoxEvent = new System.Windows.Forms.CheckedListBox();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.checkedListBoxEvent);
            this.panel1.Controls.Add(this.comboBoxObject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 150);
            this.panel1.TabIndex = 2;
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefault.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefault.Location = new System.Drawing.Point(168, 124);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(27, 23);
            this.btnDefault.TabIndex = 3;
            this.btnDefault.Text = "⭯";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(6, 124);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(157, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Подписаться";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxEvent
            // 
            this.checkedListBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxEvent.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxEvent.CheckOnClick = true;
            this.checkedListBoxEvent.FormattingEnabled = true;
            this.checkedListBoxEvent.Items.AddRange(new object[] {
            "Прогноз",
            "Техническое состояние",
            "Отчет суточный",
            "Отчет недельный",
            "Отчет месячный"});
            this.checkedListBoxEvent.Location = new System.Drawing.Point(6, 30);
            this.checkedListBoxEvent.Name = "checkedListBoxEvent";
            this.checkedListBoxEvent.Size = new System.Drawing.Size(189, 75);
            this.checkedListBoxEvent.TabIndex = 2;
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Items.AddRange(new object[] {
            "Качалка 1",
            "Качалка 2",
            "Качалка 3",
            "Качалка 4",
            "Качалка 5",
            "Качалка 6"});
            this.comboBoxObject.Location = new System.Drawing.Point(6, 3);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(189, 21);
            this.comboBoxObject.TabIndex = 1;
            this.comboBoxObject.Text = "Выберите объект";
            // 
            // EventRecipientVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "EventRecipientVal";
            this.Size = new System.Drawing.Size(200, 150);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckedListBox checkedListBoxEvent;
        private System.Windows.Forms.ComboBox comboBoxObject;
    }
}
