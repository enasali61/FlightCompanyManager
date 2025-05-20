namespace Airplane.AirLine_Address
{
    partial class UpdateAddress
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
            combo_airId = new ComboBox();
            updateBtn = new Button();
            addTXT = new TextBox();
            addLBL = new Label();
            airIdLBL = new Label();
            SuspendLayout();
            // 
            // combo_airId
            // 
            combo_airId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_airId.FormattingEnabled = true;
            combo_airId.Location = new Point(380, 107);
            combo_airId.Name = "combo_airId";
            combo_airId.Size = new Size(151, 33);
            combo_airId.TabIndex = 33;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Bisque;
            updateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            updateBtn.ForeColor = Color.Maroon;
            updateBtn.Location = new Point(286, 268);
            updateBtn.Margin = new Padding(2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(104, 46);
            updateBtn.TabIndex = 31;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // addTXT
            // 
            addTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTXT.Location = new Point(380, 184);
            addTXT.Margin = new Padding(2);
            addTXT.Name = "addTXT";
            addTXT.Size = new Size(151, 34);
            addTXT.TabIndex = 29;
            // 
            // addLBL
            // 
            addLBL.BackColor = SystemColors.ControlLightLight;
            addLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addLBL.ForeColor = SystemColors.Highlight;
            addLBL.Location = new Point(120, 184);
            addLBL.Margin = new Padding(2, 0, 2, 0);
            addLBL.Name = "addLBL";
            addLBL.Size = new Size(196, 34);
            addLBL.TabIndex = 28;
            addLBL.Text = "Airline Address";
            addLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // airIdLBL
            // 
            airIdLBL.BackColor = SystemColors.ControlLightLight;
            airIdLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            airIdLBL.ForeColor = SystemColors.Highlight;
            airIdLBL.Location = new Point(120, 107);
            airIdLBL.Margin = new Padding(2, 0, 2, 0);
            airIdLBL.Name = "airIdLBL";
            airIdLBL.Size = new Size(196, 34);
            airIdLBL.TabIndex = 27;
            airIdLBL.Text = "AirLine Id";
            airIdLBL.TextAlign = ContentAlignment.MiddleCenter;
            airIdLBL.Click += airIdLBL_Click;
            // 
            // UpdateAddress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combo_airId);
            Controls.Add(updateBtn);
            Controls.Add(addTXT);
            Controls.Add(addLBL);
            Controls.Add(airIdLBL);
            Name = "UpdateAddress";
            Text = "UpdateAddress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_airId;
        private Button updateBtn;
        private TextBox addTXT;
        private Label addLBL;
        private Label airIdLBL;
    }
}