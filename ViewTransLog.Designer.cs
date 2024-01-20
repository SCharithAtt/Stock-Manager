using System.Data.SqlClient;
using System.Data;

namespace Stock_Manager
{
    partial class ViewTransLog
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
            this.dgvTransLog = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Log";
            // 
            // btnToDashboard
            // 
            this.btnToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnToDashboard.Name = "btnToDashboard";
            this.btnToDashboard.Size = new System.Drawing.Size(107, 28);
            this.btnToDashboard.TabIndex = 12;
            this.btnToDashboard.Text = "Dashboard";
            this.btnToDashboard.UseVisualStyleBackColor = true;
            this.btnToDashboard.Click += new System.EventHandler(this.btnToDashboard_Click);
            // 
            // dgvTransLog
            // 
            this.dgvTransLog.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTransLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransLog.Location = new System.Drawing.Point(48, 82);
            this.dgvTransLog.Name = "dgvTransLog";
            this.dgvTransLog.RowHeadersWidth = 51;
            this.dgvTransLog.RowTemplate.Height = 24;
            this.dgvTransLog.Size = new System.Drawing.Size(706, 317);
            this.dgvTransLog.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(699, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ViewTransLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTransLog);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.label1);
            this.Name = "ViewTransLog";
            this.Text = "Transaction Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            using (con2)
            {
                con2.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM transactionlog", con2);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvTransLog.DataSource = dt;
                con2.Close();
            }

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToDashboard;
        private System.Windows.Forms.DataGridView dgvTransLog;
        private System.Windows.Forms.Button btnRefresh;
    }
}