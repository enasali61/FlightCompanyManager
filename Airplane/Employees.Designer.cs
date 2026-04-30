namespace Airplane
{
    partial class Employees
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
            SSN_lbl = new Label();
            ssnTxt = new TextBox();
            AirCombo = new ComboBox();
            MaleRD = new RadioButton();
            panel1 = new Panel();
            FemaleRD = new RadioButton();
            GenderLbl = new Label();
            fnameLbl = new Label();
            lastLbl = new Label();
            airIdLbl = new Label();
            bdayLbl = new Label();
            positionLbl = new Label();
            fnameTxt = new TextBox();
            dtp_bday = new DateTimePicker();
            lnameTxt = new TextBox();
            PositTxt = new TextBox();
            inertBtn = new Button();
            dgv_employee = new DataGridView();
            dgv_lbl = new Label();
            deleteBtn = new Button();
            updateBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employee).BeginInit();
            SuspendLayout();
            // 
            // SSN_lbl
            // 
            SSN_lbl.BackColor = SystemColors.ButtonHighlight;
            SSN_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SSN_lbl.ForeColor = SystemColors.Highlight;
            SSN_lbl.Location = new Point(100, 26);
            SSN_lbl.Margin = new Padding(4, 0, 4, 0);
            SSN_lbl.Name = "SSN_lbl";
            SSN_lbl.Size = new Size(108, 40);
            SSN_lbl.TabIndex = 0;
            SSN_lbl.Text = "SSN";
            SSN_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ssnTxt
            // 
            ssnTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ssnTxt.Location = new Point(267, 26);
            ssnTxt.Margin = new Padding(4);
            ssnTxt.Name = "ssnTxt";
            ssnTxt.Size = new Size(170, 38);
            ssnTxt.TabIndex = 1;
            // 
            // AirCombo
            // 
            AirCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AirCombo.FormattingEnabled = true;
            AirCombo.Location = new Point(288, 430);
            AirCombo.Margin = new Padding(4);
            AirCombo.Name = "AirCombo";
            AirCombo.Size = new Size(206, 36);
            AirCombo.TabIndex = 2;
            // 
            // MaleRD
            // 
            MaleRD.AutoSize = true;
            MaleRD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaleRD.Location = new Point(171, 14);
            MaleRD.Margin = new Padding(4);
            MaleRD.Name = "MaleRD";
            MaleRD.Size = new Size(80, 32);
            MaleRD.TabIndex = 4;
            MaleRD.TabStop = true;
            MaleRD.Text = "Male";
            MaleRD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(FemaleRD);
            panel1.Controls.Add(MaleRD);
            panel1.Controls.Add(GenderLbl);
            panel1.Location = new Point(75, 283);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 59);
            panel1.TabIndex = 5;
            // 
            // FemaleRD
            // 
            FemaleRD.AutoSize = true;
            FemaleRD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FemaleRD.Location = new Point(357, 14);
            FemaleRD.Margin = new Padding(4);
            FemaleRD.Name = "FemaleRD";
            FemaleRD.Size = new Size(100, 32);
            FemaleRD.TabIndex = 9;
            FemaleRD.TabStop = true;
            FemaleRD.Text = "Female";
            FemaleRD.UseVisualStyleBackColor = true;
            // 
            // GenderLbl
            // 
            GenderLbl.BackColor = SystemColors.ButtonHighlight;
            GenderLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLbl.ForeColor = SystemColors.Highlight;
            GenderLbl.Location = new Point(21, 10);
            GenderLbl.Margin = new Padding(4, 0, 4, 0);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(96, 40);
            GenderLbl.TabIndex = 8;
            GenderLbl.Text = "Gender";
            GenderLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fnameLbl
            // 
            fnameLbl.BackColor = SystemColors.ButtonHighlight;
            fnameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameLbl.ForeColor = SystemColors.Highlight;
            fnameLbl.Location = new Point(69, 97);
            fnameLbl.Margin = new Padding(4, 0, 4, 0);
            fnameLbl.Name = "fnameLbl";
            fnameLbl.Size = new Size(154, 40);
            fnameLbl.TabIndex = 6;
            fnameLbl.Text = "First Name";
            fnameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastLbl
            // 
            lastLbl.BackColor = SystemColors.ButtonHighlight;
            lastLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastLbl.ForeColor = SystemColors.Highlight;
            lastLbl.Location = new Point(69, 158);
            lastLbl.Margin = new Padding(4, 0, 4, 0);
            lastLbl.Name = "lastLbl";
            lastLbl.Size = new Size(154, 40);
            lastLbl.TabIndex = 7;
            lastLbl.Text = "Last Name";
            lastLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // airIdLbl
            // 
            airIdLbl.BackColor = SystemColors.ButtonHighlight;
            airIdLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            airIdLbl.ForeColor = SystemColors.Highlight;
            airIdLbl.Location = new Point(89, 430);
            airIdLbl.Margin = new Padding(4, 0, 4, 0);
            airIdLbl.Name = "airIdLbl";
            airIdLbl.Size = new Size(134, 40);
            airIdLbl.TabIndex = 9;
            airIdLbl.Text = "AirLine Id";
            airIdLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bdayLbl
            // 
            bdayLbl.BackColor = SystemColors.ButtonHighlight;
            bdayLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bdayLbl.ForeColor = SystemColors.Highlight;
            bdayLbl.Location = new Point(89, 361);
            bdayLbl.Margin = new Padding(4, 0, 4, 0);
            bdayLbl.Name = "bdayLbl";
            bdayLbl.Size = new Size(108, 40);
            bdayLbl.TabIndex = 10;
            bdayLbl.Text = "Birthday";
            bdayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // positionLbl
            // 
            positionLbl.BackColor = SystemColors.ButtonHighlight;
            positionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            positionLbl.ForeColor = SystemColors.Highlight;
            positionLbl.Location = new Point(89, 224);
            positionLbl.Margin = new Padding(4, 0, 4, 0);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(108, 40);
            positionLbl.TabIndex = 11;
            positionLbl.Text = "Position";
            positionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fnameTxt
            // 
            fnameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameTxt.Location = new Point(267, 97);
            fnameTxt.Margin = new Padding(4);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(170, 38);
            fnameTxt.TabIndex = 12;
            // 
            // dtp_bday
            // 
            dtp_bday.CalendarFont = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_bday.Location = new Point(246, 361);
            dtp_bday.Name = "dtp_bday";
            dtp_bday.Size = new Size(339, 34);
            dtp_bday.TabIndex = 13;
            // 
            // lnameTxt
            // 
            lnameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnameTxt.Location = new Point(267, 160);
            lnameTxt.Margin = new Padding(4);
            lnameTxt.Name = "lnameTxt";
            lnameTxt.Size = new Size(170, 38);
            lnameTxt.TabIndex = 14;
            // 
            // PositTxt
            // 
            PositTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PositTxt.Location = new Point(267, 224);
            PositTxt.Margin = new Padding(4);
            PositTxt.Name = "PositTxt";
            PositTxt.Size = new Size(170, 38);
            PositTxt.TabIndex = 15;
            // 
            // inertBtn
            // 
            inertBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inertBtn.ForeColor = Color.Chocolate;
            inertBtn.Location = new Point(38, 514);
            inertBtn.Name = "inertBtn";
            inertBtn.Size = new Size(154, 54);
            inertBtn.TabIndex = 16;
            inertBtn.Text = "Insert";
            inertBtn.UseVisualStyleBackColor = true;
            inertBtn.Click += inertBtn_Click;
            // 
            // dgv_employee
            // 
            dgv_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_employee.Location = new Point(657, 97);
            dgv_employee.Name = "dgv_employee";
            dgv_employee.ReadOnly = true;
            dgv_employee.RightToLeft = RightToLeft.No;
            dgv_employee.RowHeadersWidth = 51;
            dgv_employee.Size = new Size(916, 471);
            dgv_employee.TabIndex = 17;
            dgv_employee.RowEnter += dgv_employee_RowEnter;
            // 
            // dgv_lbl
            // 
            dgv_lbl.BackColor = SystemColors.ButtonHighlight;
            dgv_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_lbl.ForeColor = SystemColors.Highlight;
            dgv_lbl.Location = new Point(1064, 26);
            dgv_lbl.Margin = new Padding(4, 0, 4, 0);
            dgv_lbl.Name = "dgv_lbl";
            dgv_lbl.Size = new Size(154, 57);
            dgv_lbl.TabIndex = 18;
            dgv_lbl.Text = "Employees";
            dgv_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Chocolate;
            deleteBtn.Location = new Point(235, 514);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(154, 54);
            deleteBtn.TabIndex = 19;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Chocolate;
            updateBtn.Location = new Point(432, 514);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(154, 54);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1592, 685);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(dgv_lbl);
            Controls.Add(dgv_employee);
            Controls.Add(inertBtn);
            Controls.Add(PositTxt);
            Controls.Add(lnameTxt);
            Controls.Add(dtp_bday);
            Controls.Add(fnameTxt);
            Controls.Add(positionLbl);
            Controls.Add(bdayLbl);
            Controls.Add(airIdLbl);
            Controls.Add(lastLbl);
            Controls.Add(fnameLbl);
            Controls.Add(panel1);
            Controls.Add(AirCombo);
            Controls.Add(ssnTxt);
            Controls.Add(SSN_lbl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Employees";
            Text = "InsertEmployees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SSN_lbl;
        private TextBox ssnTxt;
        private ComboBox AirCombo;
        private RadioButton MaleRD;
        private Panel panel1;
        private Label fnameLbl;
        private Label lastLbl;
        private Label GenderLbl;
        private Label airIdLbl;
        private Label bdayLbl;
        private Label positionLbl;
        private TextBox fnameTxt;
        private DateTimePicker dtp_bday;
        private TextBox lnameTxt;
        private TextBox PositTxt;
        private RadioButton FemaleRD;
        private Button inertBtn;
        private DataGridView dgv_employee;
        private Label dgv_lbl;
        private Button deleteBtn;
        private Button updateBtn;
    }
}