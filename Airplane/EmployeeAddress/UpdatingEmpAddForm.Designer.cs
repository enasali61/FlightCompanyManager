namespace Airplane.EmployeeAddress
{
    partial class UpdatingEmpAddForm
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
            UpdateBtn = new Button();
            label_id = new Label();
            Addlabel = new Label();
            addTXT = new TextBox();
            combo_ssn = new ComboBox();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.DarkOrange;
            UpdateBtn.Location = new Point(291, 262);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(108, 41);
            UpdateBtn.TabIndex = 21;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label_id
            // 
            label_id.BackColor = SystemColors.ControlLightLight;
            label_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_id.ForeColor = SystemColors.Highlight;
            label_id.Location = new Point(149, 107);
            label_id.Name = "label_id";
            label_id.Size = new Size(156, 33);
            label_id.TabIndex = 19;
            label_id.Text = "Employee SSN";
            label_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Addlabel
            // 
            Addlabel.BackColor = SystemColors.ControlLightLight;
            Addlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addlabel.ForeColor = SystemColors.Highlight;
            Addlabel.Location = new Point(93, 165);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(252, 39);
            Addlabel.TabIndex = 18;
            Addlabel.Text = "Employee Address";
            Addlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addTXT
            // 
            addTXT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTXT.Location = new Point(375, 165);
            addTXT.Name = "addTXT";
            addTXT.Size = new Size(151, 31);
            addTXT.TabIndex = 17;
            // 
            // combo_ssn
            // 
            combo_ssn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_ssn.FormattingEnabled = true;
            combo_ssn.Location = new Point(375, 107);
            combo_ssn.Name = "combo_ssn";
            combo_ssn.Size = new Size(151, 33);
            combo_ssn.TabIndex = 16;
            // 
            // UpdatingEmpAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(UpdateBtn);
            Controls.Add(label_id);
            Controls.Add(Addlabel);
            Controls.Add(addTXT);
            Controls.Add(combo_ssn);
            Name = "UpdatingEmpAddForm";
            Text = "UpdatingEmpAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Label label_id;
        private Label Addlabel;
        private TextBox addTXT;
        private ComboBox combo_ssn;
    }
}