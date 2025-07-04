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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btncategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
           
            Categories categories = new Categories();
            categories.CategoryName = name;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir şekilde Sisteme Eklendi", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir şekilde Sistemden Silindi", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);
            var updateValue = db.Categories.Find(id);
            updateValue.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir şekilde Güncellendi", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frmBankTransactions = new FrmBankTransactions();
            frmBankTransactions.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
