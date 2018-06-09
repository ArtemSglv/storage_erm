namespace MyStorage
{
    partial class StorageForm
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
            this.labelProd = new System.Windows.Forms.Label();
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.butConfirmReceipt = new System.Windows.Forms.Button();
            this.labelShopReceipt = new System.Windows.Forms.Label();
            this.labelPartner = new System.Windows.Forms.Label();
            this.comboBoxShopReceipt = new System.Windows.Forms.ComboBox();
            this.comboBoxPartner = new System.Windows.Forms.ComboBox();
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
            this.butReceipt.Location = new System.Drawing.Point(9, 13);
            this.butReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.butReceipt.Name = "butReceipt";
            this.butReceipt.Size = new System.Drawing.Size(86, 32);
            this.butReceipt.TabIndex = 0;
            this.butReceipt.Text = "Поступление";
            this.butReceipt.UseVisualStyleBackColor = true;
            this.butReceipt.Click += new System.EventHandler(this.butReceipt_Click);
            // 
            // butSale
            // 
            this.butSale.Location = new System.Drawing.Point(9, 50);
            this.butSale.Margin = new System.Windows.Forms.Padding(2);
            this.butSale.Name = "butSale";
            this.butSale.Size = new System.Drawing.Size(86, 32);
            this.butSale.TabIndex = 1;
            this.butSale.Text = "Продажа";
            this.butSale.UseVisualStyleBackColor = true;
            this.butSale.Click += new System.EventHandler(this.butSale_Click);
            // 
            // butRemain
            // 
            this.butRemain.Location = new System.Drawing.Point(9, 86);
            this.butRemain.Margin = new System.Windows.Forms.Padding(2);
            this.butRemain.Name = "butRemain";
            this.butRemain.Size = new System.Drawing.Size(86, 32);
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
            this.panelRemain.Location = new System.Drawing.Point(101, 8);
            this.panelRemain.Margin = new System.Windows.Forms.Padding(2);
            this.panelRemain.Name = "panelRemain";
            this.panelRemain.Size = new System.Drawing.Size(340, 245);
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
            this.dataGridViewRemain.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRemain.Name = "dataGridViewRemain";
            this.dataGridViewRemain.ReadOnly = true;
            this.dataGridViewRemain.RowTemplate.Height = 24;
            this.dataGridViewRemain.Size = new System.Drawing.Size(340, 245);
            this.dataGridViewRemain.TabIndex = 0;
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Location = new System.Drawing.Point(22, 92);
            this.dataGridViewSale.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.RowTemplate.Height = 24;
            this.dataGridViewSale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSale.Size = new System.Drawing.Size(300, 126);
            this.dataGridViewSale.TabIndex = 0;
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(22, 92);
            this.dataGridViewReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.RowTemplate.Height = 24;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(300, 125);
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
            this.panelSale.Location = new System.Drawing.Point(101, 8);
            this.panelSale.Margin = new System.Windows.Forms.Padding(2);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(344, 248);
            this.panelSale.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(258, 222);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(66, 19);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(20, 48);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Product";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(22, 67);
            this.comboBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(86, 21);
            this.comboBoxProducts.TabIndex = 3;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(20, 5);
            this.labelShop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(44, 13);
            this.labelShop.TabIndex = 2;
            this.labelShop.Text = "Storage";
            // 
            // comboBoxShops
            // 
            this.comboBoxShops.FormattingEnabled = true;
            this.comboBoxShops.Location = new System.Drawing.Point(22, 24);
            this.comboBoxShops.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxShops.Name = "comboBoxShops";
            this.comboBoxShops.Size = new System.Drawing.Size(86, 21);
            this.comboBoxShops.TabIndex = 1;
            this.comboBoxShops.SelectedIndexChanged += new System.EventHandler(this.comboBoxShops_SelectedIndexChanged);
            // 
            // panelReceipt
            // 
            this.panelReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceipt.AutoSize = true;
            this.panelReceipt.Controls.Add(this.labelProd);
            this.panelReceipt.Controls.Add(this.comboBoxProd);
            this.panelReceipt.Controls.Add(this.butConfirmReceipt);
            this.panelReceipt.Controls.Add(this.labelShopReceipt);
            this.panelReceipt.Controls.Add(this.labelPartner);
            this.panelReceipt.Controls.Add(this.comboBoxShopReceipt);
            this.panelReceipt.Controls.Add(this.comboBoxPartner);
            this.panelReceipt.Controls.Add(this.dataGridViewReceipt);
            this.panelReceipt.Location = new System.Drawing.Point(101, 8);
            this.panelReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(344, 248);
            this.panelReceipt.TabIndex = 3;
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Location = new System.Drawing.Point(128, 50);
            this.labelProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(44, 13);
            this.labelProd.TabIndex = 7;
            this.labelProd.Text = "Product";
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(130, 67);
            this.comboBoxProd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(92, 21);
            this.comboBoxProd.TabIndex = 6;
            this.comboBoxProd.SelectedIndexChanged += new System.EventHandler(this.comboBoxProd_SelectedIndexChanged);
            // 
            // butConfirmReceipt
            // 
            this.butConfirmReceipt.Location = new System.Drawing.Point(266, 223);
            this.butConfirmReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.butConfirmReceipt.Name = "butConfirmReceipt";
            this.butConfirmReceipt.Size = new System.Drawing.Size(56, 19);
            this.butConfirmReceipt.TabIndex = 5;
            this.butConfirmReceipt.Text = "Confirm";
            this.butConfirmReceipt.UseVisualStyleBackColor = true;
            this.butConfirmReceipt.Click += new System.EventHandler(this.butConfirmReceipt_Click);
            // 
            // labelShopReceipt
            // 
            this.labelShopReceipt.AutoSize = true;
            this.labelShopReceipt.Location = new System.Drawing.Point(20, 50);
            this.labelShopReceipt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShopReceipt.Name = "labelShopReceipt";
            this.labelShopReceipt.Size = new System.Drawing.Size(44, 13);
            this.labelShopReceipt.TabIndex = 4;
            this.labelShopReceipt.Text = "Storage";
            // 
            // labelPartner
            // 
            this.labelPartner.AutoSize = true;
            this.labelPartner.Location = new System.Drawing.Point(20, 5);
            this.labelPartner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPartner.Name = "labelPartner";
            this.labelPartner.Size = new System.Drawing.Size(41, 13);
            this.labelPartner.TabIndex = 3;
            this.labelPartner.Text = "Partner";
            // 
            // comboBoxShopReceipt
            // 
            this.comboBoxShopReceipt.FormattingEnabled = true;
            this.comboBoxShopReceipt.Location = new System.Drawing.Point(22, 67);
            this.comboBoxShopReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxShopReceipt.Name = "comboBoxShopReceipt";
            this.comboBoxShopReceipt.Size = new System.Drawing.Size(92, 21);
            this.comboBoxShopReceipt.TabIndex = 2;
            this.comboBoxShopReceipt.SelectedIndexChanged += new System.EventHandler(this.comboBoxShopReceipt_SelectedIndexChanged);
            // 
            // comboBoxPartner
            // 
            this.comboBoxPartner.FormattingEnabled = true;
            this.comboBoxPartner.Location = new System.Drawing.Point(22, 26);
            this.comboBoxPartner.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPartner.Name = "comboBoxPartner";
            this.comboBoxPartner.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPartner.TabIndex = 1;
            this.comboBoxPartner.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartner_SelectedIndexChanged);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(450, 263);
            this.Controls.Add(this.panelReceipt);
            this.Controls.Add(this.panelRemain);
            this.Controls.Add(this.panelSale);
            this.Controls.Add(this.butRemain);
            this.Controls.Add(this.butSale);
            this.Controls.Add(this.butReceipt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(698, 441);
            this.MinimumSize = new System.Drawing.Size(185, 175);
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.panelRemain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
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
        private System.Windows.Forms.Button butConfirmReceipt;
        private System.Windows.Forms.Label labelShopReceipt;
        private System.Windows.Forms.Label labelPartner;
        private System.Windows.Forms.ComboBox comboBoxShopReceipt;
        private System.Windows.Forms.ComboBox comboBoxPartner;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.ComboBox comboBoxProd;
    }
}