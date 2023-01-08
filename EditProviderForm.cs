using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class EditProviderForm : Form
    {
        int number;
        public EditProviderForm(List<string> input)
        {
            InitializeComponent();
            tbName.Text = input[1];
            tbAddress.Text = input[2];
            number = Convert.ToInt32(input[0]);
        }

        private void btnEditProvider_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(number);
            MySqlCommand command = new MySqlCommand($"UPDATE `providers` SET `provider_name` = @providerName, `address` = @address WHERE `provider_id` = @id", DB.GetConnection());
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@providerName", tbName.Text);
            command.Parameters.AddWithValue("@address", tbAddress.Text);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}