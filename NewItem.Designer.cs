namespace Stock_Manager
{
    partial class NewItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputQty = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnToDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(152, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(152, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(152, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add New Stock Item";
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(286, 103);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(161, 22);
            this.inputCode.TabIndex = 4;
            this.inputCode.TextChanged += new System.EventHandler(this.inputCode_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(286, 165);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(161, 22);
            this.inputName.TabIndex = 5;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // inputQty
            // 
            this.inputQty.Location = new System.Drawing.Point(286, 220);
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(161, 22);
            this.inputQty.TabIndex = 6;
            this.inputQty.TextChanged += new System.EventHandler(this.inputQty_TextChanged);
          
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(286, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(333, 357);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 48);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnToDashboard
            // 
            this.btnToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDashboard.Location = new System.Drawing.Point(12, 22);
            this.btnToDashboard.Name = "btnToDashboard";
            this.btnToDashboard.Size = new System.Drawing.Size(107, 28);
            this.btnToDashboard.TabIndex = 12;
            this.btnToDashboard.Text = "Dashboard";
            this.btnToDashboard.UseVisualStyleBackColor = true;
            this.btnToDashboard.Click += new System.EventHandler(this.btnToDashboard_Click);
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.inputQty);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewItem";
            this.Text = "Add New Stock Item";
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputQty;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnToDashboard;
    }
}