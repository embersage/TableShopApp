using System;
using System.Windows.Forms;

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
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
