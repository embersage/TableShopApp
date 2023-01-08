using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TableShopApp;

namespace TableShopApp
{
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM `table`";
            dgvGoods.DataSource = DB.LoadData(query).Tables[0];
            dgvGoods.Columns[0].HeaderText = "Код стола";
            dgvGoods.Columns[1].HeaderText = "Код поставки";
            dgvGoods.Columns[2].HeaderText = "Количество";
            dgvGoods.Columns[3].HeaderText = "Производитель";
            dgvGoods.Columns[4].HeaderText = "Модель";
            dgvGoods.Columns[5].HeaderText = "Срок службы (лет)";
            dgvGoods.Columns[6].HeaderText = "Гарантия (месяцев)";
            dgvGoods.Columns[7].HeaderText = "Вес (кг)";
            dgvGoods.Columns[8].HeaderText = "Ширина (см)";
            dgvGoods.Columns[9].HeaderText = "Высота (см)";
            dgvGoods.Columns[10].HeaderText = "Глубина (см)";
            dgvGoods.Columns[11].HeaderText = "Материал столешницы";
            dgvGoods.Columns[12].HeaderText = "Материал подстолья";
            dgvGoods.Columns[13].HeaderText = "Цвет столешницы";
            dgvGoods.Columns[14].HeaderText = "Цвет подстолья";
            dgvGoods.Columns[15].HeaderText = "Тип столешницы";
            dgvGoods.Columns[16].HeaderText = "Максимальная нагрузка (кг)";
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddTableForm addTableForm = new AddTableForm();
            addTableForm.ShowDialog();
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGoods.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvGoods.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        string keyName = dgvGoods.Columns[0].HeaderText.ToString();
                        MySqlCommand command = new MySqlCommand("DELETE FROM `table` WHERE " + keyName + " = @id", DB.GetConnection());
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        dgvGoods.Rows.RemoveAt(row.Index);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления.");
            }
        }

        private void btnRemoveAllTables_Click(object sender, EventArgs e)
        {

        }
    }
}
