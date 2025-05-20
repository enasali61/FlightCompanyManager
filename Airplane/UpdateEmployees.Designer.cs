namespace Airplane
{
    partial class UpdateEmployees
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
            updateBtn = new Button();
            PositTxt = new TextBox();
            lnameTxt = new TextBox();
            dtp_bday = new DateTimePicker();
            fnameTxt = new TextBox();
            positionLbl = new Label();
            bdayLbl = new Label();
            airIdLbl = new Label();
            lastLbl = new Label();
            fnameLbl = new Label();
            panel1 = new Panel();
            FemaleRD = new RadioButton();
            MaleRD = new RadioButton();
            GenderLbl = new Label();
            AirCombo = new ComboBox();
            newSsnTxt = new TextBox();
            SSN_lbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Chocolate;
            updateBtn.Location = new Point(195, 586);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(154, 54);
            updateBtn.TabIndex = 38;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // PositTxt
            // 
            PositTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PositTxt.Location = new Point(259, 296);
            PositTxt.Margin = new Padding(4);
            PositTxt.Name = "PositTxt";
            PositTxt.Size = new Size(170, 38);
            PositTxt.TabIndex = 33;
            // 
            // lnameTxt
            // 
            lnameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnameTxt.Location = new Point(259, 232);
            lnameTxt.Margin = new Padding(4);
            lnameTxt.Name = "lnameTxt";
            lnameTxt.Size = new Size(170, 38);
            lnameTxt.TabIndex = 32;
            // 
            // dtp_bday
            // 
            dtp_bday.CalendarFont = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_bday.Location = new Point(238, 433);
            dtp_bday.Name = "dtp_bday";
            dtp_bday.Size = new Size(339, 27);
            dtp_bday.TabIndex = 31;
            // 
            // fnameTxt
            // 
            fnameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameTxt.Location = new Point(259, 169);
            fnameTxt.Margin = new Padding(4);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(170, 38);
            fnameTxt.TabIndex = 30;
            // 
            // positionLbl
            // 
            positionLbl.BackColor = SystemColors.ButtonHighlight;
            positionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            positionLbl.ForeColor = SystemColors.Highlight;
            positionLbl.Location = new Point(81, 296);
            positionLbl.Margin = new Padding(4, 0, 4, 0);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(108, 40);
            positionLbl.TabIndex = 29;
            positionLbl.Text = "Position";
            positionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bdayLbl
            // 
            bdayLbl.BackColor = SystemColors.ButtonHighlight;
            bdayLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bdayLbl.ForeColor = SystemColors.Highlight;
            bdayLbl.Location = new Point(81, 433);
            bdayLbl.Margin = new Padding(4, 0, 4, 0);
            bdayLbl.Name = "bdayLbl";
            bdayLbl.Size = new Size(108, 40);
            bdayLbl.TabIndex = 28;
            bdayLbl.Text = "Birthday";
            bdayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // airIdLbl
            // 
            airIdLbl.BackColor = SystemColors.ButtonHighlight;
            airIdLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            airIdLbl.ForeColor = SystemColors.Highlight;
            airIdLbl.Location = new Point(81, 502);
            airIdLbl.Margin = new Padding(4, 0, 4, 0);
            airIdLbl.Name = "airIdLbl";
            airIdLbl.Size = new Size(134, 40);
            airIdLbl.TabIndex = 27;
            airIdLbl.Text = "AirLine Id";
            airIdLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastLbl
            // 
            lastLbl.BackColor = SystemColors.ButtonHighlight;
            lastLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastLbl.ForeColor = SystemColors.Highlight;
            lastLbl.Location = new Point(61, 230);
            lastLbl.Margin = new Padding(4, 0, 4, 0);
            lastLbl.Name = "lastLbl";
            lastLbl.Size = new Size(154, 40);
            lastLbl.TabIndex = 26;
            lastLbl.Text = "Last Name";
            lastLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fnameLbl
            // 
            fnameLbl.BackColor = SystemColors.ButtonHighlight;
            fnameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameLbl.ForeColor = SystemColors.Highlight;
            fnameLbl.Location = new Point(61, 169);
            fnameLbl.Margin = new Padding(4, 0, 4, 0);
            fnameLbl.Name = "fnameLbl";
            fnameLbl.Size = new Size(154, 40);
            fnameLbl.TabIndex = 25;
            fnameLbl.Text = "First Name";
            fnameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(FemaleRD);
            panel1.Controls.Add(MaleRD);
            panel1.Controls.Add(GenderLbl);
            panel1.Location = new Point(67, 355);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 59);
            panel1.TabIndex = 24;
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
            // AirCombo
            // 
            AirCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AirCombo.FormattingEnabled = true;
            AirCombo.Location = new Point(280, 502);
            AirCombo.Margin = new Padding(4);
            AirCombo.Name = "AirCombo";
            AirCombo.Size = new Size(206, 36);
            AirCombo.TabIndex = 23;
            // 
            // newSsnTxt
            // 
            newSsnTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newSsnTxt.Location = new Point(259, 97);
            newSsnTxt.Margin = new Padding(4);
            newSsnTxt.Name = "newSsnTxt";
            newSsnTxt.Size = new Size(170, 38);
            newSsnTxt.TabIndex = 22;
            // 
            // SSN_lbl
            // 
            SSN_lbl.BackColor = SystemColors.ButtonHighlight;
            SSN_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SSN_lbl.ForeColor = SystemColors.Highlight;
            SSN_lbl.Location = new Point(81, 95);
            SSN_lbl.Margin = new Padding(4, 0, 4, 0);
            SSN_lbl.Name = "SSN_lbl";
            SSN_lbl.Size = new Size(108, 40);
            SSN_lbl.TabIndex = 21;
            SSN_lbl.Text = "SSN";
            SSN_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 666);
            Controls.Add(updateBtn);
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
            Controls.Add(newSsnTxt);
            Controls.Add(SSN_lbl);
            Name = "UpdateEmployees";
            Text = "UpdateEmployees";
            Load += UpdateEmployees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private TextBox PositTxt;
        private TextBox lnameTxt;
        private DateTimePicker dtp_bday;
        private TextBox fnameTxt;
        private Label positionLbl;
        private Label bdayLbl;
        private Label airIdLbl;
        private Label lastLbl;
        private Label fnameLbl;
        private Panel panel1;
        private RadioButton FemaleRD;
        private RadioButton MaleRD;
        private Label GenderLbl;
        private ComboBox AirCombo;
        private TextBox newSsnTxt;
        private Label SSN_lbl;
    }
}