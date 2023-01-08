using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TableShopApp;

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
            try
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        MySqlCommand command = new MySqlCommand($"DELETE FROM `employees` WHERE `employee_id` = @id", DB.GetConnection());
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        dgvEmployees.Rows.RemoveAt(row.Index);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления.");
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value.ToString());
                }
            }
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(values);
            editEmployeeForm.ShowDialog();
        }
    }
}