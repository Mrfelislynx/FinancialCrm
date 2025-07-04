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
    public partial class FrmUserCreate : Form
    {
        public FrmUserCreate()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnCreate_Click(object sender, EventArgs e)
        {
           string username = txtuserName.Text;
            string password = txtuserPass.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) 
                
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Users user = new Users();
            
            user.UserName = username;
            user.PassWord = password;
        

            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Kullanıcı başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
