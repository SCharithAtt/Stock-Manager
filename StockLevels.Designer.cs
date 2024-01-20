using System.Data.SqlClient;
using System.Data;

namespace Stock_Manager
{
    partial class StockLevels
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
            
            this.label1 = new System.Windows.Forms.Label();
            this.btnToDashboard = new System.Windows.Forms.Button();
            this.dgvStockLevels = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Stock Levels";
            // 
            // btnToDashboard
            // 
            this.btnToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDashboard.Location = new System.Drawing.Point(34, 30);
            this.btnToDashboard.Name = "btnToDashboard";
            this.btnToDashboard.Size = new System.Drawing.Size(107, 28);
            this.btnToDashboard.TabIndex = 12;
            this.btnToDashboard.Text = "Dashboard";
            this.btnToDashboard.UseVisualStyleBackColor = true;
            this.btnToDashboard.Click += new System.EventHandler(this.btnToDashboard_Click);
            // 
            // dgvStockLevels
            // 
            this.dgvStockLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockLevels.Location = new System.Drawing.Point(81, 105);
            this.dgvStockLevels.Name = "dgvStockLevels";
            this.dgvStockLevels.RowHeadersWidth = 51;
            this.dgvStockLevels.RowTemplate.Height = 24;
            this.dgvStockLevels.Size = new System.Drawing.Size(632, 294);
            this.dgvStockLevels.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(689, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StockLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvStockLevels);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.label1);
            this.Name = "StockLevels";
            this.Text = "Stock Levels";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLevels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            using (con1)
            {
                con1.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM inventory", con1);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvStockLevels.DataSource = dt;
                con1.Close();
            }
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToDashboard;
        private System.Windows.Forms.DataGridView dgvStockLevels;
        private System.Windows.Forms.Button btnRefresh;
    }
}