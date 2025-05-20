namespace Airplane.AirplaneRoute
{
    partial class UpdateAirplaneRouteForm
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
            DurationTXT = new TextBox();
            PriceTXT = new TextBox();
            comboAirplene = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            combRoute = new ComboBox();
            AP_label = new Label();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // DurationTXT
            // 
            DurationTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DurationTXT.Location = new Point(425, 248);
            DurationTXT.Name = "DurationTXT";
            DurationTXT.Size = new Size(178, 34);
            DurationTXT.TabIndex = 17;
            // 
            // PriceTXT
            // 
            PriceTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceTXT.Location = new Point(425, 179);
            PriceTXT.Name = "PriceTXT";
            PriceTXT.Size = new Size(178, 34);
            PriceTXT.TabIndex = 16;
            // 
            // comboAirplene
            // 
            comboAirplene.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboAirplene.FormattingEnabled = true;
            comboAirplene.Location = new Point(425, 113);
            comboAirplene.Name = "comboAirplene";
            comboAirplene.Size = new Size(178, 36);
            comboAirplene.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(193, 179);
            label3.Name = "label3";
            label3.Size = new Size(166, 40);
            label3.TabIndex = 14;
            label3.Text = "Price";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(193, 248);
            label2.Name = "label2";
            label2.Size = new Size(166, 40);
            label2.TabIndex = 13;
            label2.Text = "Duration";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(193, 49);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 12;
            label1.Text = "Route Id";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combRoute
            // 
            combRoute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combRoute.FormattingEnabled = true;
            combRoute.Location = new Point(425, 49);
            combRoute.Name = "combRoute";
            combRoute.Size = new Size(178, 36);
            combRoute.TabIndex = 11;
            // 
            // AP_label
            // 
            AP_label.BackColor = SystemColors.ControlLightLight;
            AP_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AP_label.ForeColor = SystemColors.Highlight;
            AP_label.Location = new Point(193, 113);
            AP_label.Name = "AP_label";
            AP_label.Size = new Size(166, 40);
            AP_label.TabIndex = 10;
            AP_label.Text = "Airplane Id";
            AP_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.SandyBrown;
            updateBtn.Location = new Point(340, 329);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(115, 51);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // UpdateAirplaneRouteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateBtn);
            Controls.Add(DurationTXT);
            Controls.Add(PriceTXT);
            Controls.Add(comboAirplene);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combRoute);
            Controls.Add(AP_label);
            Name = "UpdateAirplaneRouteForm";
            Text = "UpdateAirplaneRouteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DurationTXT;
        private TextBox PriceTXT;
        private ComboBox comboAirplene;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combRoute;
        private Label AP_label;
        private Button updateBtn;
    }
}