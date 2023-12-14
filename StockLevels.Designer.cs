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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.btnToDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnToDashboard.Name = "btnToDashboard";
            this.btnToDashboard.Size = new System.Drawing.Size(107, 28);
            this.btnToDashboard.TabIndex = 12;
            this.btnToDashboard.Text = "Dashboard";
            this.btnToDashboard.UseVisualStyleBackColor = true;
            this.btnToDashboard.Click += new System.EventHandler(this.btnToDashboard_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(131, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 290);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // StockLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.label1);
            this.Name = "StockLevels";
            this.Text = "Stock Levels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToDashboard;
        private System.Windows.Forms.ListView listView1;
    }
}