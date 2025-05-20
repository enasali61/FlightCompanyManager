namespace Airplane.AirLine
{
    partial class UpdateAirline
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
            NameTXT = new TextBox();
            AiridTXT = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // NameTXT
            // 
            NameTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTXT.Location = new Point(328, 143);
            NameTXT.Margin = new Padding(2);
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(118, 34);
            NameTXT.TabIndex = 14;
            // 
            // AiridTXT
            // 
            AiridTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AiridTXT.Location = new Point(328, 62);
            AiridTXT.Margin = new Padding(2);
            AiridTXT.Name = "AiridTXT";
            AiridTXT.Size = new Size(118, 34);
            AiridTXT.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(161, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(138, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 11;
            label1.Text = "AirLine Id";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(230, 229);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UpdateAirline
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(button2);
            Controls.Add(NameTXT);
            Controls.Add(AiridTXT);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateAirline";
            Text = "UpdateAirline";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTXT;
        private TextBox AiridTXT;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}