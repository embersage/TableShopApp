using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TableShopApp;
using System.Data;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using System.Collections;

namespace TableShopApp
{
    public partial class AddConsignmentForm : Form
    {
        Dictionary<string, int> values = new Dictionary<string, int>();
        public AddConsignmentForm()
        {
            InitializeComponent();
            string query = "SELECT `provider_id`, `provider_name` FROM `providers`";
            foreach (DataRow row in DB.LoadData(query).Tables[0].AsEnumerable())
            {
                values.Add(row.ItemArray[1].ToString(), Convert.ToInt32(row.ItemArray[0]));
            }
            cbProvider.DataSource = values.Keys.ToList();
            cbProvider.SelectedIndex = 0;
        }

        private void btnAddConsignment_Click(object sender, EventArgs e)
        {
            string query = $"SELECT `provider_id` FROM `providers` WHERE `provider_name` = '{cbProvider.Text}'";
            int id = Convert.ToInt32(DB.LoadData(query).Tables[0].Rows[0].ItemArray[0]);

            MySqlCommand command = new MySqlCommand($"INSERT INTO `consignments`(`provider_id`, `quantity`, " +
                $"`purchase_price`, `date_of_operation`) VALUES (@provider, @quantity, @price, @date)", DB.GetConnection());
            command.Parameters.AddWithValue("@provider", id);
            command.Parameters.AddWithValue("@quantity", Convert.ToInt32(tbAmount.Text));
            command.Parameters.AddWithValue("@price", Convert.ToInt32(tbPrice.Text));
            command.Parameters.AddWithValue("@date", DateTime.Parse(tbDate.Text).Date.ToString("yyyy-MM-dd"));
            command.ExecuteNonQuery();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
