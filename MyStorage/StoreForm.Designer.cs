namespace MyStorage
{
    partial class StoreForm
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
            this.butReceipt = new System.Windows.Forms.Button();
            this.butSale = new System.Windows.Forms.Button();
            this.butRemain = new System.Windows.Forms.Button();
            this.panelRemain = new System.Windows.Forms.Panel();
            this.dataGridViewRemain = new System.Windows.Forms.DataGridView();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.panelSale = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.comboBoxShops = new System.Windows.Forms.ComboBox();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.panelRemain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.panelSale.SuspendLayout();
            this.panelReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // butReceipt
            // 
            this.butReceipt.Location = new System.Drawing.Point(12, 16);
            this.butReceipt.Name = "butReceipt";
            this.butReceipt.Size = new System.Drawing.Size(115, 39);
            this.butReceipt.TabIndex = 0;
            this.butReceipt.Text = "Поступление";
            this.butReceipt.UseVisualStyleBackColor = true;
            this.butReceipt.Click += new System.EventHandler(this.butReceipt_Click);
            // 
            // butSale
            // 
            this.butSale.Location = new System.Drawing.Point(12, 61);
            this.butSale.Name = "butSale";
            this.butSale.Size = new System.Drawing.Size(115, 39);
            this.butSale.TabIndex = 1;
            this.butSale.Text = "Продажа";
            this.butSale.UseVisualStyleBackColor = true;
            this.butSale.Click += new System.EventHandler(this.butSale_Click);
            // 
            // butRemain
            // 
            this.butRemain.Location = new System.Drawing.Point(12, 106);
            this.butRemain.Name = "butRemain";
            this.butRemain.Size = new System.Drawing.Size(115, 39);
            this.butRemain.TabIndex = 2;
            this.butRemain.Text = "Остатки";
            this.butRemain.UseVisualStyleBackColor = true;
            this.butRemain.Click += new System.EventHandler(this.butRemain_Click);
            // 
            // panelRemain
            // 
            this.panelRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRemain.AutoSize = true;
            this.panelRemain.Controls.Add(this.dataGridViewRemain);
            this.panelRemain.Location = new System.Drawing.Point(135, 10);
            this.panelRemain.Name = "panelRemain";
            this.panelRemain.Size = new System.Drawing.Size(453, 302);
            this.panelRemain.TabIndex = 3;
            this.panelRemain.Visible = false;
            // 
            // dataGridViewRemain
            // 
            this.dataGridViewRemain.AllowUserToAddRows = false;
            this.dataGridViewRemain.AllowUserToDeleteRows = false;
            this.dataGridViewRemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRemain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRemain.Name = "dataGridViewRemain";
            this.dataGridViewRemain.ReadOnly = true;
            this.dataGridViewRemain.RowTemplate.Height = 24;
            this.dataGridViewRemain.Size = new System.Drawing.Size(453, 302);
            this.dataGridViewRemain.TabIndex = 0;
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Location = new System.Drawing.Point(30, 113);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.RowTemplate.Height = 24;
            this.dataGridViewSale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSale.Size = new System.Drawing.Size(400, 155);
            this.dataGridViewSale.TabIndex = 0;
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.RowTemplate.Height = 24;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(453, 302);
            this.dataGridViewReceipt.TabIndex = 0;
            // 
            // panelSale
            // 
            this.panelSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSale.AutoSize = true;
            this.panelSale.Controls.Add(this.buttonConfirm);
            this.panelSale.Controls.Add(this.labelProduct);
            this.panelSale.Controls.Add(this.comboBoxProducts);
            this.panelSale.Controls.Add(this.labelShop);
            this.panelSale.Controls.Add(this.comboBoxShops);
            this.panelSale.Controls.Add(this.dataGridViewSale);
            this.panelSale.Location = new System.Drawing.Point(135, 10);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(453, 302);
            this.panelSale.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(344, 273);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(88, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(27, 59);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(57, 17);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Product";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(30, 83);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(114, 24);
            this.comboBoxProducts.TabIndex = 3;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(27, 6);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(41, 17);
            this.labelShop.TabIndex = 2;
            this.labelShop.Text = "Shop";
            // 
            // comboBoxShops
            // 
            this.comboBoxShops.FormattingEnabled = true;
            this.comboBoxShops.Location = new System.Drawing.Point(30, 30);
            this.comboBoxShops.Name = "comboBoxShops";
            this.comboBoxShops.Size = new System.Drawing.Size(114, 24);
            this.comboBoxShops.TabIndex = 1;
            this.comboBoxShops.SelectedIndexChanged += new System.EventHandler(this.comboBoxShops_SelectedIndexChanged);
            // 
            // panelReceipt
            // 
            this.panelReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceipt.AutoSize = true;
            this.panelReceipt.Controls.Add(this.dataGridViewReceipt);
            this.panelReceipt.Location = new System.Drawing.Point(135, 10);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(453, 302);
            this.panelReceipt.TabIndex = 3;
            this.panelReceipt.Visible = false;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 324);
            this.Controls.Add(this.panelSale);
            this.Controls.Add(this.panelReceipt);
            this.Controls.Add(this.panelRemain);
            this.Controls.Add(this.butRemain);
            this.Controls.Add(this.butSale);
            this.Controls.Add(this.butReceipt);
            this.MaximumSize = new System.Drawing.Size(926, 534);
            this.MinimumSize = new System.Drawing.Size(241, 207);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.panelRemain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            this.panelReceipt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReceipt;
        private System.Windows.Forms.Button butSale;
        private System.Windows.Forms.Button butRemain;
        private System.Windows.Forms.Panel panelRemain;
        private System.Windows.Forms.DataGridView dataGridViewRemain;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.ComboBox comboBoxShops;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label labelShop;
    }
}