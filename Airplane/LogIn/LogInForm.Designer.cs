namespace Airplane.LogIn
{
    partial class LogInForm
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
            PositTxt = new TextBox();
            lnameTxt = new TextBox();
            fnameTxt = new TextBox();
            positionLbl = new Label();
            lastLbl = new Label();
            fnameLbl = new Label();
            ssnTxt = new TextBox();
            SSN_lbl = new Label();
            LogInbutton = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // PositTxt
            // 
            PositTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PositTxt.Location = new Point(440, 294);
            PositTxt.Margin = new Padding(4);
            PositTxt.Name = "PositTxt";
            PositTxt.Size = new Size(170, 38);
            PositTxt.TabIndex = 23;
            // 
            // lnameTxt
            // 
            lnameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnameTxt.Location = new Point(440, 167);
            lnameTxt.Margin = new Padding(4);
            lnameTxt.Name = "lnameTxt";
            lnameTxt.Size = new Size(170, 38);
            lnameTxt.TabIndex = 22;
            // 
            // fnameTxt
            // 
            fnameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameTxt.Location = new Point(440, 97);
            fnameTxt.Margin = new Padding(4);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(170, 38);
            fnameTxt.TabIndex = 21;
            // 
            // positionLbl
            // 
            positionLbl.BackColor = SystemColors.ButtonHighlight;
            positionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            positionLbl.ForeColor = SystemColors.Highlight;
            positionLbl.Location = new Point(242, 294);
            positionLbl.Margin = new Padding(4, 0, 4, 0);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(139, 40);
            positionLbl.TabIndex = 20;
            positionLbl.Text = "Position";
            positionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastLbl
            // 
            lastLbl.BackColor = SystemColors.ButtonHighlight;
            lastLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastLbl.ForeColor = SystemColors.Highlight;
            lastLbl.Location = new Point(242, 167);
            lastLbl.Margin = new Padding(4, 0, 4, 0);
            lastLbl.Name = "lastLbl";
            lastLbl.Size = new Size(154, 40);
            lastLbl.TabIndex = 19;
            lastLbl.Text = "Last Name";
            lastLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fnameLbl
            // 
            fnameLbl.BackColor = SystemColors.ButtonHighlight;
            fnameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameLbl.ForeColor = SystemColors.Highlight;
            fnameLbl.Location = new Point(242, 96);
            fnameLbl.Margin = new Padding(4, 0, 4, 0);
            fnameLbl.Name = "fnameLbl";
            fnameLbl.Size = new Size(154, 40);
            fnameLbl.TabIndex = 18;
            fnameLbl.Text = "First Name";
            fnameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ssnTxt
            // 
            ssnTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ssnTxt.Location = new Point(440, 232);
            ssnTxt.Margin = new Padding(4);
            ssnTxt.Name = "ssnTxt";
            ssnTxt.Size = new Size(170, 38);
            ssnTxt.TabIndex = 17;
            // 
            // SSN_lbl
            // 
            SSN_lbl.BackColor = SystemColors.ButtonHighlight;
            SSN_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SSN_lbl.ForeColor = SystemColors.Highlight;
            SSN_lbl.Location = new Point(242, 230);
            SSN_lbl.Margin = new Padding(4, 0, 4, 0);
            SSN_lbl.Name = "SSN_lbl";
            SSN_lbl.Size = new Size(139, 40);
            SSN_lbl.TabIndex = 16;
            SSN_lbl.Text = "Password";
            SSN_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInbutton
            // 
            LogInbutton.BackColor = SystemColors.Info;
            LogInbutton.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInbutton.Location = new Point(214, 399);
            LogInbutton.Name = "LogInbutton";
            LogInbutton.Size = new Size(137, 43);
            LogInbutton.TabIndex = 24;
            LogInbutton.Text = "Log In";
            LogInbutton.UseVisualStyleBackColor = false;
            LogInbutton.Click += LogInbutton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(484, 399);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 25;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(357, 32);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 26;
            label1.Text = "Log In Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 603);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(LogInbutton);
            Controls.Add(PositTxt);
            Controls.Add(lnameTxt);
            Controls.Add(fnameTxt);
            Controls.Add(positionLbl);
            Controls.Add(lastLbl);
            Controls.Add(fnameLbl);
            Controls.Add(ssnTxt);
            Controls.Add(SSN_lbl);
            Name = "LogInForm";
            Text = "LogIn";
            Load += LogInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PositTxt;
        private TextBox lnameTxt;
        private TextBox fnameTxt;
        private Label positionLbl;
        private Label lastLbl;
        private Label fnameLbl;
        private TextBox ssnTxt;
        private Label SSN_lbl;
        private Button LogInbutton;
        private Button button1;
        private Label label1;
    }
}