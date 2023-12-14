namespace Stock_Manager
{
    partial class Dashboard
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
            this.btnAddNewItem = new System.Windows.Forms.LinkLabel();
            this.btnStockQnty = new System.Windows.Forms.LinkLabel();
            this.btnDisplayLog = new System.Windows.Forms.LinkLabel();
            this.btnDisplayStock = new System.Windows.Forms.LinkLabel();
            this.btnDltItem = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAddNewItem.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewItem.LinkColor = System.Drawing.Color.Black;
            this.btnAddNewItem.Location = new System.Drawing.Point(158, 24);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(500, 45);
            this.btnAddNewItem.TabIndex = 0;
            this.btnAddNewItem.TabStop = true;
            this.btnAddNewItem.Text = "Add New Stock Item";
            this.btnAddNewItem.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnAddNewItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAddNewItem_LinkClicked);
            // 
            // btnStockQnty
            // 
            this.btnStockQnty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStockQnty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnStockQnty.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockQnty.LinkColor = System.Drawing.Color.Black;
            this.btnStockQnty.Location = new System.Drawing.Point(158, 86);
            this.btnStockQnty.Name = "btnStockQnty";
            this.btnStockQnty.Size = new System.Drawing.Size(500, 45);
            this.btnStockQnty.TabIndex = 1;
            this.btnStockQnty.TabStop = true;
            this.btnStockQnty.Text = "Add/Remove Quantity to Stock Item";
            this.btnStockQnty.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnStockQnty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnStockQnty_LinkClicked);
            // 
            // btnDisplayLog
            // 
            this.btnDisplayLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplayLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDisplayLog.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnDisplayLog.LinkColor = System.Drawing.Color.Black;
            this.btnDisplayLog.Location = new System.Drawing.Point(158, 278);
            this.btnDisplayLog.Name = "btnDisplayLog";
            this.btnDisplayLog.Size = new System.Drawing.Size(500, 45);
            this.btnDisplayLog.TabIndex = 2;
            this.btnDisplayLog.TabStop = true;
            this.btnDisplayLog.Text = "View Transaction Log";
            this.btnDisplayLog.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnDisplayLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDisplayLog_LinkClicked);
            // 
            // btnDisplayStock
            // 
            this.btnDisplayStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplayStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDisplayStock.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnDisplayStock.LinkColor = System.Drawing.Color.Black;
            this.btnDisplayStock.Location = new System.Drawing.Point(158, 215);
            this.btnDisplayStock.Name = "btnDisplayStock";
            this.btnDisplayStock.Size = new System.Drawing.Size(500, 45);
            this.btnDisplayStock.TabIndex = 4;
            this.btnDisplayStock.TabStop = true;
            this.btnDisplayStock.Text = "Display Stock Levels";
            this.btnDisplayStock.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnDisplayStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDisplayStock_LinkClicked);
            // 
            // btnDltItem
            // 
            this.btnDltItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDltItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDltItem.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.btnDltItem.LinkColor = System.Drawing.Color.Black;
            this.btnDltItem.Location = new System.Drawing.Point(158, 151);
            this.btnDltItem.Name = "btnDltItem";
            this.btnDltItem.Size = new System.Drawing.Size(500, 45);
            this.btnDltItem.TabIndex = 5;
            this.btnDltItem.TabStop = true;
            this.btnDltItem.Text = "Delete Stock Items";
            this.btnDltItem.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnDltItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDltItem_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(295, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDltItem);
            this.Controls.Add(this.btnDisplayStock);
            this.Controls.Add(this.btnDisplayLog);
            this.Controls.Add(this.btnStockQnty);
            this.Controls.Add(this.btnAddNewItem);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel btnAddNewItem;
        private System.Windows.Forms.LinkLabel btnStockQnty;
        private System.Windows.Forms.LinkLabel btnDisplayLog;
        private System.Windows.Forms.LinkLabel btnDisplayStock;
        private System.Windows.Forms.LinkLabel btnDltItem;
        private System.Windows.Forms.Button btnLogout;
    }
}