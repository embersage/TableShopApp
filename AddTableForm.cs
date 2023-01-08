using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class AddTableForm : Form
    {
        public AddTableForm()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            //MySqlCommand command = new MySqlCommand($"INSERT INTO `table`(`consignment_id`, `quantity`, " +
            //    $"`manufacturer`, `model`, `life_time(years)`, `guarantee(months)`, `weight(kg)`, `size_width(cm)`, `size_height(cm)`, `size_depth(cm)`, " +
            //    $"`countertop_material`, `underframe_material`, `countertop_color`, `underframe_color`, `countertop_type`, `maximum_load`) VALUES " +
            //    $"(@consignment_id, @quantity, @manufacturer, @model, @life_time, @guarantee, @weight, " +
            //    $"@width, @height, @depth, @countertop_material, @underframe_material, " +
            //    $"@countertop_color, @underframe_color, @countertop_type, @maximum_load)", DB.GetConnection());
            //command.Parameters.AddWithValue("@consignment_id", tbSurname.Text.ToString());
            //command.Parameters.AddWithValue("@quantity", tbName.Text.ToString());
            //command.Parameters.AddWithValue("@manufacturer", tbPatronymic.Text.ToString());
            //command.Parameters.AddWithValue("@model", cbGender.Text.ToString());
            //command.Parameters.AddWithValue("@life_time", tbPhoneNumber.Text.ToString());
            //command.Parameters.AddWithValue("@guarantee", DateTime.Parse(tbBirthDate.Text).Date.ToString("yyyy-MM-dd"));
            //command.Parameters.AddWithValue("@weight", Convert.ToInt32(tbSalary.Text));
            //command.Parameters.AddWithValue("@width", tbLogin.Text.ToString());
            //command.Parameters.AddWithValue("@depth", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@height", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@countertop_material", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@underframe_material", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@countertop_color", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@underframe_color", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@countertop_type", tbPassword.Text.ToString());
            //command.Parameters.AddWithValue("@maximum_load", tbPassword.Text.ToString());
            //command.ExecuteNonQuery();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
