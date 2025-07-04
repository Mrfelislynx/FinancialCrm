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
    public partial class FrmBankTransactions : Form
    {
        public FrmBankTransactions()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {

            var banks = db.Banks.ToList();
            cmbBank.DataSource = banks;
            cmbBank.DisplayMember = "BankTitle";
            cmbBank.ValueMember = "BankId";
            cmbBank.SelectedIndex = -1;

            var bankProcesses = db.BankProcesses
                  .OrderByDescending(x => x.BankProcessId)
                  .Select(bp => new
                  {
                      bp.BankProcessId,
                      bp.Description,
                      bp.Amount,
                      bp.ProcessDate,
                      BankTitle = db.Banks.FirstOrDefault(b => b.BankId == bp.BankId).BankTitle
                  })
                  .ToList();

            dataGridView1.DataSource = bankProcesses;
            dataGridView1.Columns["BankProcessId"].Visible = false; // BankProcessId'yi gizle
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedValue != null && int.TryParse(cmbBank.SelectedValue.ToString(), out int selectedBankId))
            {
                using (var db = new FinancialCrmDbEntities())
                {
                    var bankProcesses = db.BankProcesses
                        .Where(x => x.BankId == selectedBankId)
                        .OrderByDescending(x => x.BankProcessId)
                        .Select(bp => new
                        {
                            bp.BankProcessId,
                            bp.Description,
                            bp.Amount,
                            bp.ProcessDate,
                            BankTitle = db.Banks.FirstOrDefault(b => b.BankId == bp.BankId).BankTitle
                        })
                        .ToList();

                    dataGridView1.DataSource = bankProcesses;
                    dataGridView1.Columns["BankProcessId"].Visible = false;
                }
            }
        }

        private void Kategoriler_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

