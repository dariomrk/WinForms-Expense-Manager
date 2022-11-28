namespace WinForms_Expense_Manager.Forms
{
    partial class OptionsForm
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
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrency.Location = new System.Drawing.Point(12, 19);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(58, 15);
            this.labelCurrency.TabIndex = 0;
            this.labelCurrency.Text = "Currency:";
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(170, 16);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(78, 23);
            this.textBoxCurrency.TabIndex = 1;
            this.textBoxCurrency.TextChanged += new System.EventHandler(this.textBoxCurrency_TextChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(12, 63);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(236, 32);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 108);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxCurrency);
            this.Controls.Add(this.labelCurrency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCurrency;
        private TextBox textBoxCurrency;
        private Button buttonApply;
    }
}