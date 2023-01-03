using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TableShop;

namespace TableShopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DB.OpenConnection();
        }

        public void LoadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            this.pnlMain.Tag= form;
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DB.CloseConnection();
            Application.Exit();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            LoadForm(new EmployeesForm());
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            LoadForm(new GoodsForm());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadForm(new StatisticsForm());
        }
    }
}