namespace FinancialCrm
{
    partial class FrmSpendings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateSpendings = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoveSpendings = new System.Windows.Forms.Button();
            this.btnCreateSpendings = new System.Windows.Forms.Button();
            this.btnspendingsList = new System.Windows.Forms.Button();
            this.txtspendingPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtspendingsAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtspendingTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.Kategoriler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(286, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 255);
            this.panel4.TabIndex = 6;
            // 
            // btnUpdateSpendings
            // 
            this.btnUpdateSpendings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdateSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateSpendings.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSpendings.Location = new System.Drawing.Point(681, 165);
            this.btnUpdateSpendings.Name = "btnUpdateSpendings";
            this.btnUpdateSpendings.Size = new System.Drawing.Size(192, 33);
            this.btnUpdateSpendings.TabIndex = 11;
            this.btnUpdateSpendings.Text = "Harcama Güncelle";
            this.btnUpdateSpendings.UseVisualStyleBackColor = false;
            this.btnUpdateSpendings.Click += new System.EventHandler(this.btnUpdateSpendings_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdateSpendings);
            this.panel3.Controls.Add(this.btnRemoveSpendings);
            this.panel3.Controls.Add(this.btnCreateSpendings);
            this.panel3.Controls.Add(this.btnspendingsList);
            this.panel3.Controls.Add(this.txtspendingPeriod);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtspendingsAmount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtspendingTitle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSpendingId);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(286, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 210);
            this.panel3.TabIndex = 5;
            // 
            // btnRemoveSpendings
            // 
            this.btnRemoveSpendings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemoveSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveSpendings.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSpendings.Location = new System.Drawing.Point(486, 165);
            this.btnRemoveSpendings.Name = "btnRemoveSpendings";
            this.btnRemoveSpendings.Size = new System.Drawing.Size(175, 33);
            this.btnRemoveSpendings.TabIndex = 10;
            this.btnRemoveSpendings.Text = "Harcama Sil";
            this.btnRemoveSpendings.UseVisualStyleBackColor = false;
            this.btnRemoveSpendings.Click += new System.EventHandler(this.btnRemoveSpendings_Click);
            // 
            // btnCreateSpendings
            // 
            this.btnCreateSpendings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCreateSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateSpendings.ForeColor = System.Drawing.Color.Black;
            this.btnCreateSpendings.Location = new System.Drawing.Point(295, 165);
            this.btnCreateSpendings.Name = "btnCreateSpendings";
            this.btnCreateSpendings.Size = new System.Drawing.Size(175, 33);
            this.btnCreateSpendings.TabIndex = 9;
            this.btnCreateSpendings.Text = "Yeni Harcama";
            this.btnCreateSpendings.UseVisualStyleBackColor = false;
            this.btnCreateSpendings.Click += new System.EventHandler(this.btnCreateSpendings_Click);
            // 
            // btnspendingsList
            // 
            this.btnspendingsList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnspendingsList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnspendingsList.ForeColor = System.Drawing.Color.Black;
            this.btnspendingsList.Location = new System.Drawing.Point(105, 165);
            this.btnspendingsList.Name = "btnspendingsList";
            this.btnspendingsList.Size = new System.Drawing.Size(175, 33);
            this.btnspendingsList.TabIndex = 8;
            this.btnspendingsList.Text = "Harcama Listesi";
            this.btnspendingsList.UseVisualStyleBackColor = false;
            this.btnspendingsList.Click += new System.EventHandler(this.btnspendingsList_Click);
            // 
            // txtspendingPeriod
            // 
            this.txtspendingPeriod.BackColor = System.Drawing.SystemColors.Info;
            this.txtspendingPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtspendingPeriod.Location = new System.Drawing.Point(106, 126);
            this.txtspendingPeriod.Name = "txtspendingPeriod";
            this.txtspendingPeriod.Size = new System.Drawing.Size(768, 32);
            this.txtspendingPeriod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periyot:";
            // 
            // txtspendingsAmount
            // 
            this.txtspendingsAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txtspendingsAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtspendingsAmount.Location = new System.Drawing.Point(106, 83);
            this.txtspendingsAmount.Name = "txtspendingsAmount";
            this.txtspendingsAmount.Size = new System.Drawing.Size(768, 32);
            this.txtspendingsAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // txtspendingTitle
            // 
            this.txtspendingTitle.BackColor = System.Drawing.SystemColors.Info;
            this.txtspendingTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtspendingTitle.Location = new System.Drawing.Point(105, 44);
            this.txtspendingTitle.Name = "txtspendingTitle";
            this.txtspendingTitle.Size = new System.Drawing.Size(768, 32);
            this.txtspendingTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.SystemColors.Info;
            this.txtSpendingId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(105, 3);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(768, 32);
            this.txtSpendingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcama Id:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(36, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Faturalar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(36, 61);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(215, 45);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // Kategoriler
            // 
            this.Kategoriler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Kategoriler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategoriler.ForeColor = System.Drawing.Color.White;
            this.Kategoriler.Location = new System.Drawing.Point(36, 10);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(215, 45);
            this.Kategoriler.TabIndex = 0;
            this.Kategoriler.Text = "Kategoriler";
            this.Kategoriler.UseVisualStyleBackColor = false;
            this.Kategoriler.Click += new System.EventHandler(this.Kategoriler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.Kategoriler);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 481);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(310, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 127);
            this.panel2.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(36, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "Çıkış";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(36, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ayarlar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(36, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(36, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Banka Hareketleri";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(36, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Giderler";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 496);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdateSpendings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoveSpendings;
        private System.Windows.Forms.Button btnCreateSpendings;
        private System.Windows.Forms.Button btnspendingsList;
        private System.Windows.Forms.TextBox txtspendingPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtspendingsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtspendingTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button Kategoriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}