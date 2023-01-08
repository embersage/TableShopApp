using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class ProvidersForm : Form
    {
        public ProvidersForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM `providers`";
            dgvProviders.DataSource = DB.LoadData(query).Tables[0];
            dgvProviders.Columns[0].HeaderText = "Код поставки";
            dgvProviders.Columns[1].HeaderText = "Наименование поставщика";
            dgvProviders.Columns[2].HeaderText = "Адрес";
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            AddProviderForm addProviderForm = new AddProviderForm();
            addProviderForm.ShowDialog();
        }

        private void btnRemoveProvider_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProviders.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvProviders.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        MySqlCommand command = new MySqlCommand($"DELETE FROM `providers` WHERE `provider_id` = @id", DB.GetConnection());
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        dgvProviders.Rows.RemoveAt(row.Index);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления.");
            }
        }

        private void btnEditProvider_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            if (dgvProviders.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dgvProviders.SelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value.ToString());
                }
            }
            EditProviderForm editProviderForm = new EditProviderForm(values);
            editProviderForm.ShowDialog();
        }
    }
}