namespace TableShopApp
{
    partial class ProvidersForm
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
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.btnRemoveProvider = new System.Windows.Forms.Button();
            this.btnEditProvider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProviders
            // 
            this.dgvProviders.BackgroundColor = System.Drawing.Color.White;
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Location = new System.Drawing.Point(12, 76);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(576, 332);
            this.dgvProviders.TabIndex = 0;
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Location = new System.Drawing.Point(12, 31);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(170, 30);
            this.btnAddProvider.TabIndex = 1;
            this.btnAddProvider.Text = "Добавить поставщика";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // btnRemoveProvider
            // 
            this.btnRemoveProvider.Location = new System.Drawing.Point(201, 31);
            this.btnRemoveProvider.Name = "btnRemoveProvider";
            this.btnRemoveProvider.Size = new System.Drawing.Size(200, 30);
            this.btnRemoveProvider.TabIndex = 3;
            this.btnRemoveProvider.Text = "Удалить выбранных поставщиков";
            this.btnRemoveProvider.UseVisualStyleBackColor = true;
            this.btnRemoveProvider.Click += new System.EventHandler(this.btnRemoveProvider_Click);
            // 
            // btnEditProvider
            // 
            this.btnEditProvider.Location = new System.Drawing.Point(418, 31);
            this.btnEditProvider.Name = "btnEditProvider";
            this.btnEditProvider.Size = new System.Drawing.Size(170, 30);
            this.btnEditProvider.TabIndex = 2;
            this.btnEditProvider.Text = "Изменить поставщика";
            this.btnEditProvider.UseVisualStyleBackColor = true;
            this.btnEditProvider.Click += new System.EventHandler(this.btnEditProvider_Click);
            // 
            // ProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnRemoveProvider);
            this.Controls.Add(this.btnEditProvider);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.dgvProviders);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProvidersForm";
            this.Text = "ProvidersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Button btnRemoveProvider;
        private System.Windows.Forms.Button btnEditProvider;
        private System.Windows.Forms.DataGridView dgvProviders;
    }
}