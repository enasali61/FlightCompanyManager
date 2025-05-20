namespace Airplane.AirLine_Phones
{
    partial class UpdateAirLinePhonesForm
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
            phoTXT = new TextBox();
            combo_airId = new ComboBox();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.DarkOrange;
            UpdateBtn.Location = new Point(367, 254);
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
            label_id.Location = new Point(231, 105);
            label_id.Name = "label_id";
            label_id.Size = new Size(156, 33);
            label_id.TabIndex = 19;
            label_id.Text = "Airline Id";
            label_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Addlabel
            // 
            Addlabel.BackColor = SystemColors.ControlLightLight;
            Addlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addlabel.ForeColor = SystemColors.Highlight;
            Addlabel.Location = new Point(231, 163);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(156, 39);
            Addlabel.TabIndex = 18;
            Addlabel.Text = "Airline Phone";
            Addlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoTXT
            // 
            phoTXT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoTXT.Location = new Point(448, 163);
            phoTXT.Name = "phoTXT";
            phoTXT.Size = new Size(151, 31);
            phoTXT.TabIndex = 17;
            // 
            // combo_airId
            // 
            combo_airId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_airId.FormattingEnabled = true;
            combo_airId.Location = new Point(448, 105);
            combo_airId.Name = "combo_airId";
            combo_airId.Size = new Size(151, 33);
            combo_airId.TabIndex = 16;
            // 
            // UpdateAirLinePhonesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateBtn);
            Controls.Add(label_id);
            Controls.Add(Addlabel);
            Controls.Add(phoTXT);
            Controls.Add(combo_airId);
            Name = "UpdateAirLinePhonesForm";
            Text = "UpdateAirLinePhonesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Label label_id;
        private Label Addlabel;
        private TextBox phoTXT;
        private ComboBox combo_airId;
    }
}