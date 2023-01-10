using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class ClientsMainForm : Form
    {
        public ClientsMainForm()
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

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            LoadForm(new CatalogForm());
        }
    }
}