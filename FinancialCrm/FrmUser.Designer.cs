namespace FinancialCrm
{
    partial class FrmUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtuserPass = new System.Windows.Forms.TextBox();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.LnkKayıtOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(137, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre :";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(216, 147);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(215, 22);
            this.txtuserName.TabIndex = 8;
            // 
            // txtuserPass
            // 
            this.txtuserPass.Location = new System.Drawing.Point(216, 203);
            this.txtuserPass.Name = "txtuserPass";
            this.txtuserPass.Size = new System.Drawing.Size(215, 22);
            this.txtuserPass.TabIndex = 9;
            // 
            // btnEntrance
            // 
            this.btnEntrance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntrance.ForeColor = System.Drawing.Color.White;
            this.btnEntrance.Location = new System.Drawing.Point(216, 241);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(215, 45);
            this.btnEntrance.TabIndex = 10;
            this.btnEntrance.Text = "Giriş";
            this.btnEntrance.UseVisualStyleBackColor = false;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // LnkKayıtOl
            // 
            this.LnkKayıtOl.AutoSize = true;
            this.LnkKayıtOl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkKayıtOl.LinkColor = System.Drawing.Color.Red;
            this.LnkKayıtOl.Location = new System.Drawing.Point(338, 301);
            this.LnkKayıtOl.Name = "LnkKayıtOl";
            this.LnkKayıtOl.Size = new System.Drawing.Size(83, 28);
            this.LnkKayıtOl.TabIndex = 11;
            this.LnkKayıtOl.TabStop = true;
            this.LnkKayıtOl.Text = "Kayıt Ol";
            this.LnkKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayıtOl_LinkClicked);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.Controls.Add(this.LnkKayıtOl);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.txtuserPass);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtuserPass;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.LinkLabel LnkKayıtOl;
    }
}