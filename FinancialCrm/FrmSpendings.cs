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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private readonly object txtspendingAmount;

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnspendingsList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateSpendings_Click(object sender, EventArgs e)
        {
            string title = txtspendingTitle.Text;
           decimal amount = decimal.Parse(txtspendingsAmount.Text);
            string period = txtspendingPeriod.Text;
            Spendings spendings = new Spendings();
            spendings.SpendingsTitle = title;
            spendings.SpendingsAmount = amount;
            spendings.SpendingsPeriod = period;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcamalar Başarılı Bir şekilde Sisteme Eklendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveSpendings_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcamalar Başarılı Bir şekilde Sistemden Silindi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdateSpendings_Click(object sender, EventArgs e)
        {
            string title = txtspendingTitle.Text;
            decimal amount = decimal.Parse(txtspendingsAmount.Text);
            string period = txtspendingPeriod.Text;
            int id = int.Parse(txtSpendingId.Text);
            var updateValue = db.Spendings.Find(id);
            updateValue.SpendingsTitle = title;
            updateValue.SpendingsAmount = amount;
            updateValue.SpendingsPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Harcamalar Başarılı Bir şekilde Güncellendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void Kategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }
    }
}
