namespace MyStorage
{
    partial class ProviderForm
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
            this.panelRemain = new System.Windows.Forms.Panel();
            this.dataGridViewRemain = new System.Windows.Forms.DataGridView();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.panelRemain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRemain
            // 
            this.panelRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRemain.AutoSize = true;
            this.panelRemain.Controls.Add(this.dataGridViewRemain);
            this.panelRemain.Location = new System.Drawing.Point(11, 32);
            this.panelRemain.Margin = new System.Windows.Forms.Padding(2);
            this.panelRemain.Name = "panelRemain";
            this.panelRemain.Size = new System.Drawing.Size(430, 185);
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
            this.dataGridViewRemain.Size = new System.Drawing.Size(430, 185);
            this.dataGridViewRemain.TabIndex = 0;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(11, 6);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvider.TabIndex = 4;
            this.comboBoxProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvider_SelectedIndexChanged);
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(450, 263);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.panelRemain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(698, 441);
            this.MinimumSize = new System.Drawing.Size(185, 175);
            this.Name = "ProviderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            this.panelRemain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelRemain;
        private System.Windows.Forms.DataGridView dataGridViewRemain;
        private System.Windows.Forms.ComboBox comboBoxProvider;
    }
}