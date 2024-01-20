using System.Collections.Generic;
using System.Data.SqlClient;

namespace Stock_Manager
{

    partial class DeleteStock
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Item From Inventory";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete Stock Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(312, 77);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(173, 23);
            this.btnLoadItems.TabIndex = 16;
            this.btnLoadItems.Text = "Load Stock Items";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(99, 117);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(615, 244);
            this.lbItems.TabIndex = 17;
            // 
            // DeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btnLoadItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStock";
            this.Text = "Delete Stock Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToDashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadItems;
        private System.Windows.Forms.ListBox lbItems;
    }
}