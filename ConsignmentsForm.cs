using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class ConsignmentsForm : Form
    {
        public ConsignmentsForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM `consignments`";
            dgvConsignments.DataSource = DB.LoadData(query).Tables[0];
            dgvConsignments.Columns[0].HeaderText = "Код поставки";
            dgvConsignments.Columns[1].HeaderText = "Код поставщика";
            dgvConsignments.Columns[2].HeaderText = "Количество товара";
            dgvConsignments.Columns[3].HeaderText = "Цена закупки";
            dgvConsignments.Columns[4].HeaderText = "Дата операции";
        }

        private void btnAddConsignment_Click(object sender, EventArgs e)
        {
            AddConsignmentForm addConsignmentForm = new AddConsignmentForm();
            addConsignmentForm.ShowDialog();
        }

        private void btnRemoveConsignment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsignments.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvConsignments.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        MySqlCommand command = new MySqlCommand($"DELETE FROM `consignments` WHERE `consignment_id` = @id", DB.GetConnection());
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        dgvConsignments.Rows.RemoveAt(row.Index);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления.");
            }
        }

        private void btnEditConsignment_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            if (dgvConsignments.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dgvConsignments.SelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value.ToString());
                }
            }
            EditConsignmentForm editConsignmentForm = new EditConsignmentForm(values);
            editConsignmentForm.ShowDialog();
        }
    }
}