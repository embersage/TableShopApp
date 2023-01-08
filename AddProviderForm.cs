using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class AddProviderForm : Form
    {
        public AddProviderForm()
        {
            InitializeComponent();  
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO `providers`(`provider_name`, `address`) VALUES " +
                $"(@providerName, @address)", DB.GetConnection());
            command.Parameters.AddWithValue("@providerName", tbName.Text.ToString());
            command.Parameters.AddWithValue("@address", tbAddress.Text.ToString());
            command.ExecuteNonQuery();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
