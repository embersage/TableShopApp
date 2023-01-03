namespace TableShopApp
{
    partial class GoodsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.btnRemoveAllTables = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGoods
            // 
            this.dgvGoods.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Location = new System.Drawing.Point(12, 76);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.Size = new System.Drawing.Size(576, 332);
            this.dgvGoods.TabIndex = 1;
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Location = new System.Drawing.Point(223, 31);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(160, 30);
            this.btnRemoveTable.TabIndex = 6;
            this.btnRemoveTable.Text = "Удалить стол";
            this.btnRemoveTable.UseVisualStyleBackColor = true;
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click);
            // 
            // btnRemoveAllTables
            // 
            this.btnRemoveAllTables.Location = new System.Drawing.Point(428, 31);
            this.btnRemoveAllTables.Name = "btnRemoveAllTables";
            this.btnRemoveAllTables.Size = new System.Drawing.Size(160, 30);
            this.btnRemoveAllTables.TabIndex = 5;
            this.btnRemoveAllTables.Text = "Удалить все столы";
            this.btnRemoveAllTables.UseVisualStyleBackColor = true;
            this.btnRemoveAllTables.Click += new System.EventHandler(this.btnRemoveAllTables_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(12, 31);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(160, 30);
            this.btnAddTable.TabIndex = 4;
            this.btnAddTable.Text = "Добавить стол";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnRemoveTable);
            this.Controls.Add(this.btnRemoveAllTables);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.dgvGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.Button btnRemoveTable;
        private System.Windows.Forms.Button btnRemoveAllTables;
        private System.Windows.Forms.Button btnAddTable;
    }
}