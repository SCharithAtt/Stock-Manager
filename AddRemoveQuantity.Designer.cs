namespace Stock_Manager
{
    partial class AddRemoveQuantity
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
            this.components = new System.ComponentModel.Container();
            this.selectAdd = new System.Windows.Forms.RadioButton();
            this.selectRemove = new System.Windows.Forms.RadioButton();
            this.textQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.btnToDashboard = new System.Windows.Forms.Button();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.ComboBox();
            this.addRemoveQuantityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addRemoveQuantityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectAdd
            // 
            this.selectAdd.AutoSize = true;
            this.selectAdd.Location = new System.Drawing.Point(313, 124);
            this.selectAdd.Name = "selectAdd";
            this.selectAdd.Size = new System.Drawing.Size(56, 20);
            this.selectAdd.TabIndex = 2;
            this.selectAdd.TabStop = true;
            this.selectAdd.Text = "Add ";
            this.selectAdd.UseVisualStyleBackColor = true;
            this.selectAdd.CheckedChanged += new System.EventHandler(this.selectAdd_CheckedChanged);
            // 
            // selectRemove
            // 
            this.selectRemove.AutoSize = true;
            this.selectRemove.Location = new System.Drawing.Point(410, 124);
            this.selectRemove.Name = "selectRemove";
            this.selectRemove.Size = new System.Drawing.Size(80, 20);
            this.selectRemove.TabIndex = 3;
            this.selectRemove.TabStop = true;
            this.selectRemove.Text = "Remove";
            this.selectRemove.UseVisualStyleBackColor = true;
            this.selectRemove.CheckedChanged += new System.EventHandler(this.selectRemove_CheckedChanged);
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(313, 287);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(192, 22);
            this.textQty.TabIndex = 4;
            this.textQty.TextChanged += new System.EventHandler(this.inputQty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add  or Remove Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Action";
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Location = new System.Drawing.Point(313, 354);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(157, 51);
            this.btnSubmit1.TabIndex = 10;
            this.btnSubmit1.Text = "Submit";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // btnToDashboard
            // 
            this.btnToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnToDashboard.Name = "btnToDashboard";
            this.btnToDashboard.Size = new System.Drawing.Size(107, 28);
            this.btnToDashboard.TabIndex = 11;
            this.btnToDashboard.Text = "Dashboard";
            this.btnToDashboard.UseVisualStyleBackColor = true;
            this.btnToDashboard.Click += new System.EventHandler(this.btnToDashboard_Click);
            // 
            // inputCode
            // 
            this.inputCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputCode.Location = new System.Drawing.Point(313, 181);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(192, 22);
            this.inputCode.TabIndex = 12;
            // 
            // inputName
            // 
            this.inputName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputName.FormattingEnabled = true;
            this.inputName.Location = new System.Drawing.Point(313, 233);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(192, 24);
            this.inputName.TabIndex = 13;
            // 
            // addRemoveQuantityBindingSource
            // 
            this.addRemoveQuantityBindingSource.DataSource = typeof(Stock_Manager.AddRemoveQuantity);
            // 
            // AddRemoveQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.btnSubmit1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.selectRemove);
            this.Controls.Add(this.selectAdd);
            this.Name = "AddRemoveQuantity";
            this.Text = "Add/Remove Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.addRemoveQuantityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton selectAdd;
        private System.Windows.Forms.RadioButton selectRemove;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Button btnToDashboard;
        private System.Windows.Forms.BindingSource addRemoveQuantityBindingSource;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.ComboBox inputName;
    }
}