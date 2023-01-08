using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class EditEmployeeForm : Form
    {
        int number;
        public EditEmployeeForm(List<string> input)
        {
            InitializeComponent();
            tbSurname.Text = input[1];
            tbName.Text = input[2];
            tbPatronymic.Text = input[3];
            cbGender.Text = input[4];
            tbPhoneNumber.Text = input[5];
            tbBirthDate.Text = DateTime.Parse(input[6]).Date.ToString("dd.MM.yyyy");
            tbSalary.Text = input[7];
            tbLogin.Text = input[8];
            tbPassword.Text = input[9];
            number = Convert.ToInt32(input[0]);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(number);
            MySqlCommand command = new MySqlCommand($"UPDATE `employees` SET `employee_surname` = @employeeSurname, " +
                $"`employee_name` = @employeeName, `employee_patronymic` = @employeePatronymic, `gender` = @gender, " +
                $"`contact_number` = @contactNumber, `birth_date` = @birthDate, `salary` = @salary, `login` = @login," +
                $"`password` = @password WHERE `employee_id` = @id", DB.GetConnection());
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@employeeSurname", tbSurname.Text);
            command.Parameters.AddWithValue("@employeeName", tbName.Text);
            command.Parameters.AddWithValue("@employeePatronymic", tbPatronymic.Text);
            command.Parameters.AddWithValue("@gender", cbGender.Text);
            command.Parameters.AddWithValue("@contactNumber", tbPhoneNumber.Text);
            command.Parameters.AddWithValue("@birthDate", DateTime.Parse(tbBirthDate.Text).Date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@salary", Convert.ToInt32(tbSalary.Text));
            command.Parameters.AddWithValue("@login", tbLogin.Text);
            command.Parameters.AddWithValue("@password", tbPassword.Text);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}