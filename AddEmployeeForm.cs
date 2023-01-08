using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO `employees`(`employee_surname`, `employee_name`, " +
                $"`employee_patronymic`, `gender`, `contact_number`, `birth_date`, `salary`, `login`, `password`) VALUES " +
                $"(@employeeSurname, @employeeName, @employeePatronymic, @gender, @contactNumber, @birthDate, @salary, @login, @password)", DB.GetConnection());
            command.Parameters.AddWithValue("@employeeSurname", tbSurname.Text.ToString());
            command.Parameters.AddWithValue("@employeeName", tbName.Text.ToString());
            command.Parameters.AddWithValue("@employeePatronymic", tbPatronymic.Text.ToString());
            command.Parameters.AddWithValue("@gender", cbGender.Text.ToString());
            command.Parameters.AddWithValue("@contactNumber", tbPhoneNumber.Text.ToString());
            command.Parameters.AddWithValue("@birthDate", DateTime.Parse(tbBirthDate.Text).Date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@salary", Convert.ToInt32(tbSalary.Text));
            command.Parameters.AddWithValue("@login", tbLogin.Text.ToString());
            command.Parameters.AddWithValue("@password", tbPassword.Text.ToString());
            command.ExecuteNonQuery();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
