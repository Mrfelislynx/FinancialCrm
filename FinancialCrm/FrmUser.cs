using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

      

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            var username = txtuserName.Text;
            var password = txtuserPass.Text;
            using (FinancialCrmDbEntities db = new FinancialCrmDbEntities())
            {
                var user = db.Users.FirstOrDefault(x => x.UserName == username && x.PassWord == password);
                if (user != null)
                {
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FrmUserCreate frmUserCreate = new FrmUserCreate();
            frmUserCreate.Show();
            this.Hide();

        }
    }
}
