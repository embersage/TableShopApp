using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class EditConsignmentForm : Form
    {
        int number;
        Dictionary<string, int> values = new Dictionary<string, int>();
        public EditConsignmentForm(List<string> input)
        {
            InitializeComponent();
            tbAmount.Text = input[2];
            tbPrice.Text = input[3];
            tbDate.Text = DateTime.Parse(input[4]).Date.ToString("dd.MM.yyyy");
            number = Convert.ToInt32(input[0]);

            string query = "SELECT `provider_id`, `provider_name` FROM `providers`";
            foreach (DataRow row in DB.LoadData(query).Tables[0].AsEnumerable())
            {
                values.Add(row.ItemArray[1].ToString(), Convert.ToInt32(row.ItemArray[0]));
            }
            cbProvider.DataSource = values.Keys.ToList();
            cbProvider.SelectedIndex = Convert.ToInt32(input[1]);
        }

        private void btnEditConsignment_Click(object sender, EventArgs e)
        {
            string query = $"SELECT `provider_id` FROM `providers` WHERE `provider_name` = '{cbProvider.Text}'";
            int res = Convert.ToInt32(DB.LoadData(query).Tables[0].Rows[0].ItemArray[0]);

            int id = Convert.ToInt32(number);
            MySqlCommand command = new MySqlCommand($"UPDATE `consignments` SET `provider_id` = @providerId, " +
                $"`quantity` = @quantity, `purchase_price` = @price, `date_of_operation` = @date WHERE `consignment_id` = @id", DB.GetConnection());
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@providerId", res);
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