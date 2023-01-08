namespace TableShopApp
{
    partial class ConsignmentsForm
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
            this.dgvConsignments = new System.Windows.Forms.DataGridView();
            this.btnAddConsignment = new System.Windows.Forms.Button();
            this.btnRemoveConsignment = new System.Windows.Forms.Button();
            this.btnEditConsignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsignments
            // 
            this.dgvConsignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsignments.Location = new System.Drawing.Point(12, 76);
            this.dgvConsignments.Name = "dgvConsignments";
            this.dgvConsignments.Size = new System.Drawing.Size(576, 332);
            this.dgvConsignments.TabIndex = 0;
            // 
            // btnAddConsignment
            // 
            this.btnAddConsignment.Location = new System.Drawing.Point(12, 31);
            this.btnAddConsignment.Name = "btnAddConsignment";
            this.btnAddConsignment.Size = new System.Drawing.Size(180, 30);
            this.btnAddConsignment.TabIndex = 1;
            this.btnAddConsignment.Text = "Добавить поставку";
            this.btnAddConsignment.UseVisualStyleBackColor = true;
            this.btnAddConsignment.Click += new System.EventHandler(this.btnAddConsignment_Click);
            // 
            // btnRemoveConsignment
            // 
            this.btnRemoveConsignment.Location = new System.Drawing.Point(211, 31);
            this.btnRemoveConsignment.Name = "btnRemoveConsignment";
            this.btnRemoveConsignment.Size = new System.Drawing.Size(180, 30);
            this.btnRemoveConsignment.TabIndex = 3;
            this.btnRemoveConsignment.Text = "Удалить выбранные поставки";
            this.btnRemoveConsignment.UseVisualStyleBackColor = true;
            this.btnRemoveConsignment.Click += new System.EventHandler(this.btnRemoveConsignment_Click);
            // 
            // btnEditConsignment
            // 
            this.btnEditConsignment.Location = new System.Drawing.Point(408, 31);
            this.btnEditConsignment.Name = "btnEditConsignment";
            this.btnEditConsignment.Size = new System.Drawing.Size(180, 30);
            this.btnEditConsignment.TabIndex = 2;
            this.btnEditConsignment.Text = "Изменить поставку";
            this.btnEditConsignment.UseVisualStyleBackColor = true;
            this.btnEditConsignment.Click += new System.EventHandler(this.btnEditConsignment_Click);
            // 
            // ConsignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnRemoveConsignment);
            this.Controls.Add(this.btnEditConsignment);
            this.Controls.Add(this.btnAddConsignment);
            this.Controls.Add(this.dgvConsignments);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsignmentsForm";
            this.Text = "ConsignmentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddConsignment;
        private System.Windows.Forms.Button btnRemoveConsignment;
        private System.Windows.Forms.Button btnEditConsignment;
        private System.Windows.Forms.DataGridView dgvConsignments;
    }
}