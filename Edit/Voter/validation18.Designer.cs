
namespace ElectoralManagementSystemGUI
{
    partial class validation18
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
            this.lbl18 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl18
            // 
            this.lbl18.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl18.Location = new System.Drawing.Point(36, 23);
            this.lbl18.Name = "lbl18";
            this.lbl18.Size = new System.Drawing.Size(423, 82);
            this.lbl18.TabIndex = 0;
            this.lbl18.Text = "Are You 18+ ?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.AliceBlue;
            this.btnYes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(99, 144);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(86, 38);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNO.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Location = new System.Drawing.Point(295, 144);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(86, 38);
            this.btnNO.TabIndex = 2;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // validation18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(515, 217);
            this.ControlBox = false;
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbl18);
            this.MaximumSize = new System.Drawing.Size(533, 264);
            this.MinimumSize = new System.Drawing.Size(533, 264);
            this.Name = "validation18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "validation18";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl18;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNO;
    }
}