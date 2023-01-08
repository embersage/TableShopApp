using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            DB.OpenConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DB.CloseConnection();
            Application.Exit();
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            string query = $"SELECT `employees`.`Employee_id` FROM `employees` WHERE login = '{login}' AND password = '{password}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DB.GetConnection());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}