namespace TableShopApp
{
    partial class CatalogForm
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
            this.lvGoods = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvGoods
            // 
            this.lvGoods.HideSelection = false;
            this.lvGoods.Location = new System.Drawing.Point(12, 76);
            this.lvGoods.Name = "lvGoods";
            this.lvGoods.Size = new System.Drawing.Size(576, 332);
            this.lvGoods.TabIndex = 0;
            this.lvGoods.UseCompatibleStateImageBehavior = false;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.lvGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGoods;
    }
}