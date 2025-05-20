namespace Airplane.EmployeeAddress
{
    partial class EmpAddForm
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
            addlbl = new Label();
            dgvEMPAddress = new DataGridView();
            DeleteBTN = new Button();
            UpdateBtn = new Button();
            InserBTN = new Button();
            label_id = new Label();
            Addlabel = new Label();
            addTXT = new TextBox();
            combo_ssn = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEMPAddress).BeginInit();
            SuspendLayout();
            // 
            // addlbl
            // 
            addlbl.BackColor = SystemColors.ControlLightLight;
            addlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addlbl.ForeColor = SystemColors.Highlight;
            addlbl.Location = new Point(688, 26);
            addlbl.Name = "addlbl";
            addlbl.Size = new Size(246, 33);
            addlbl.TabIndex = 17;
            addlbl.Text = "Employee Addresses";
            addlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEMPAddress
            // 
            dgvEMPAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEMPAddress.Location = new Point(647, 73);
            dgvEMPAddress.Name = "dgvEMPAddress";
            dgvEMPAddress.RowHeadersWidth = 51;
            dgvEMPAddress.Size = new Size(564, 290);
            dgvEMPAddress.TabIndex = 16;
            dgvEMPAddress.RowEnter += dgvEMPAddress_RowEnter;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBTN.ForeColor = Color.DarkOrange;
            DeleteBTN.Location = new Point(243, 303);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(108, 41);
            DeleteBTN.TabIndex = 15;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.DarkOrange;
            UpdateBtn.Location = new Point(394, 303);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(108, 41);
            UpdateBtn.TabIndex = 14;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // InserBTN
            // 
            InserBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InserBTN.ForeColor = Color.DarkOrange;
            InserBTN.Location = new Point(87, 303);
            InserBTN.Name = "InserBTN";
            InserBTN.Size = new Size(108, 41);
            InserBTN.TabIndex = 13;
            InserBTN.Text = "Insert";
            InserBTN.UseVisualStyleBackColor = true;
            InserBTN.Click += InserBTN_Click;
            // 
            // label_id
            // 
            label_id.BackColor = SystemColors.ControlLightLight;
            label_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_id.ForeColor = SystemColors.Highlight;
            label_id.Location = new Point(125, 103);
            label_id.Name = "label_id";
            label_id.Size = new Size(156, 33);
            label_id.TabIndex = 12;
            label_id.Text = "Employee SSN";
            label_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Addlabel
            // 
            Addlabel.BackColor = SystemColors.ControlLightLight;
            Addlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addlabel.ForeColor = SystemColors.Highlight;
            Addlabel.Location = new Point(69, 161);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(252, 39);
            Addlabel.TabIndex = 11;
            Addlabel.Text = "Employee Address";
            Addlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addTXT
            // 
            addTXT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTXT.Location = new Point(351, 161);
            addTXT.Name = "addTXT";
            addTXT.Size = new Size(151, 31);
            addTXT.TabIndex = 10;
            // 
            // combo_ssn
            // 
            combo_ssn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_ssn.FormattingEnabled = true;
            combo_ssn.Location = new Point(351, 103);
            combo_ssn.Name = "combo_ssn";
            combo_ssn.Size = new Size(151, 33);
            combo_ssn.TabIndex = 9;
            // 
            // EmpAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 450);
            Controls.Add(addlbl);
            Controls.Add(dgvEMPAddress);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBtn);
            Controls.Add(InserBTN);
            Controls.Add(label_id);
            Controls.Add(Addlabel);
            Controls.Add(addTXT);
            Controls.Add(combo_ssn);
            Name = "EmpAddForm";
            Text = "EmpAddForm";
            ((System.ComponentModel.ISupportInitialize)dgvEMPAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addlbl;
        private DataGridView dgvEMPAddress;
        private Button DeleteBTN;
        private Button UpdateBtn;
        private Button InserBTN;
        private Label label_id;
        private Label Addlabel;
        private TextBox addTXT;
        private ComboBox combo_ssn;
    }
}