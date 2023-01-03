using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableShop;

namespace TableShopApp
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM `employees`";
            dgvEmployees.DataSource = DB.LoadData(query).Tables[0];
            dgvEmployees.Columns[0].HeaderText = "Код работника";
            dgvEmployees.Columns[1].HeaderText = "Фамилия работника";
            dgvEmployees.Columns[2].HeaderText = "Имя работника";
            dgvEmployees.Columns[3].HeaderText = "Отчество работника";
            dgvEmployees.Columns[4].HeaderText = "Пол работника";
            dgvEmployees.Columns[5].HeaderText = "Номер телефона";
            dgvEmployees.Columns[6].HeaderText = "Дата рождения";
            dgvEmployees.Columns[7].HeaderText = "Зарплата";
            dgvEmployees.Columns[8].HeaderText = "Логин";
            dgvEmployees.Columns[9].HeaderText = "Пароль";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveAllEmployees_Click(object sender, EventArgs e)
        {

        }
    }
}