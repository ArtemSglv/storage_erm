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
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelSale = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.dataGridView);
            this.panel.Location = new System.Drawing.Point(135, 10);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(453, 302);
            this.panel.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(453, 302);
            this.dataGridView.TabIndex = 0;
            // 
            // panelSale
            // 
            this.panelSale.Location = new System.Drawing.Point(133, 10);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(455, 302);
            this.panelSale.TabIndex = 4;
            this.panelSale.Visible = false;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 324);
            this.Controls.Add(this.panelSale);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.butRemain);
            this.Controls.Add(this.butSale);
            this.Controls.Add(this.butReceipt);
            this.MaximumSize = new System.Drawing.Size(926, 534);
            this.MinimumSize = new System.Drawing.Size(241, 207);
            this.Name = "StoreForm";
            this.Text = "Магазин";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReceipt;
        private System.Windows.Forms.Button butSale;
        private System.Windows.Forms.Button butRemain;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelSale;
    }
}