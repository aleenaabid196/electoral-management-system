
namespace ElectoralManagementSystemGUI
{
    partial class FAQsForm
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
            this.richTxtFAQs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTxtFAQs
            // 
            this.richTxtFAQs.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtFAQs.Location = new System.Drawing.Point(84, 66);
            this.richTxtFAQs.Name = "richTxtFAQs";
            this.richTxtFAQs.Size = new System.Drawing.Size(530, 412);
            this.richTxtFAQs.TabIndex = 1;
            this.richTxtFAQs.Text = "Frequently Asked Questions will\nbe Updated Soon";
            // 
            // FAQsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(696, 547);
            this.Controls.Add(this.richTxtFAQs);
            this.MaximumSize = new System.Drawing.Size(714, 594);
            this.MinimumSize = new System.Drawing.Size(714, 594);
            this.Name = "FAQsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAQsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtFAQs;
    }
}