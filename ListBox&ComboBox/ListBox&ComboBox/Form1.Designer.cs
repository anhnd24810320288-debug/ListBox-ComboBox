namespace ListBox_ComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBefore;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.TextBox txtTotalAfter;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTotalBefore = new TextBox();
            nudDiscount = new NumericUpDown();
            txtTotalAfter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(12, 12);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(240, 28);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(12, 48);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(240, 204);
            lstAvailableServices.TabIndex = 1;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(372, 48);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(240, 204);
            lstSelectedServices.TabIndex = 2;
            lstSelectedServices.DoubleClick += lstSelectedServices_DoubleClick;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(270, 80);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(90, 30);
            btnSelect.TabIndex = 3;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(270, 126);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(90, 30);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(270, 172);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 30);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 278);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 6;
            label1.Text = "Tổng tiền chưa giảm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 317);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 7;
            label2.Text = "Tỷ lệ chiết khấu (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 355);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 8;
            label3.Text = "Thành tiền";
            // 
            // txtTotalBefore
            // 
            txtTotalBefore.Location = new Point(155, 275);
            txtTotalBefore.Name = "txtTotalBefore";
            txtTotalBefore.ReadOnly = true;
            txtTotalBefore.Size = new Size(122, 27);
            txtTotalBefore.TabIndex = 9;
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(155, 315);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(122, 27);
            nudDiscount.TabIndex = 10;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // txtTotalAfter
            // 
            txtTotalAfter.Location = new Point(155, 352);
            txtTotalAfter.Name = "txtTotalAfter";
            txtTotalAfter.ReadOnly = true;
            txtTotalAfter.Size = new Size(122, 27);
            txtTotalAfter.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 401);
            Controls.Add(txtTotalAfter);
            Controls.Add(nudDiscount);
            Controls.Add(txtTotalBefore);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(cboCategory);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bảng tính tiền dịch vụ";
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
