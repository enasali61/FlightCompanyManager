namespace Airplane.AirplaneRoute
{
    partial class AirplaneRouteForm
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
            AP_label = new Label();
            combRoute = new ComboBox();
            button1 = new Button();
            dgv_airRoute = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboAirplene = new ComboBox();
            PriceTXT = new TextBox();
            DurationTXT = new TextBox();
            dltbutton = new Button();
            updateBtn = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_airRoute).BeginInit();
            SuspendLayout();
            // 
            // AP_label
            // 
            AP_label.BackColor = SystemColors.ControlLightLight;
            AP_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AP_label.ForeColor = SystemColors.Highlight;
            AP_label.Location = new Point(116, 116);
            AP_label.Name = "AP_label";
            AP_label.Size = new Size(166, 40);
            AP_label.TabIndex = 0;
            AP_label.Text = "Airplane Id";
            AP_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combRoute
            // 
            combRoute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combRoute.FormattingEnabled = true;
            combRoute.Location = new Point(348, 52);
            combRoute.Name = "combRoute";
            combRoute.Size = new Size(178, 36);
            combRoute.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SandyBrown;
            button1.Location = new Point(249, 352);
            button1.Name = "button1";
            button1.Size = new Size(115, 51);
            button1.TabIndex = 2;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv_airRoute
            // 
            dgv_airRoute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_airRoute.Location = new Point(617, 64);
            dgv_airRoute.Name = "dgv_airRoute";
            dgv_airRoute.RowHeadersWidth = 51;
            dgv_airRoute.Size = new Size(566, 339);
            dgv_airRoute.TabIndex = 3;
            dgv_airRoute.RowEnter += dgv_airRoute_RowEnter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(116, 52);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 4;
            label1.Text = "Route Id";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(116, 251);
            label2.Name = "label2";
            label2.Size = new Size(166, 40);
            label2.TabIndex = 5;
            label2.Text = "Duration";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(116, 182);
            label3.Name = "label3";
            label3.Size = new Size(166, 40);
            label3.TabIndex = 6;
            label3.Text = "Price";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboAirplene
            // 
            comboAirplene.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboAirplene.FormattingEnabled = true;
            comboAirplene.Location = new Point(348, 116);
            comboAirplene.Name = "comboAirplene";
            comboAirplene.Size = new Size(178, 36);
            comboAirplene.TabIndex = 7;
            // 
            // PriceTXT
            // 
            PriceTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceTXT.Location = new Point(348, 182);
            PriceTXT.Name = "PriceTXT";
            PriceTXT.Size = new Size(178, 34);
            PriceTXT.TabIndex = 8;
            // 
            // DurationTXT
            // 
            DurationTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DurationTXT.Location = new Point(348, 251);
            DurationTXT.Name = "DurationTXT";
            DurationTXT.Size = new Size(178, 34);
            DurationTXT.TabIndex = 9;
            // 
            // dltbutton
            // 
            dltbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dltbutton.ForeColor = Color.SandyBrown;
            dltbutton.Location = new Point(432, 352);
            dltbutton.Name = "dltbutton";
            dltbutton.Size = new Size(115, 51);
            dltbutton.TabIndex = 10;
            dltbutton.Text = "Delete";
            dltbutton.UseVisualStyleBackColor = true;
            dltbutton.Click += dltbutton_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.SandyBrown;
            updateBtn.Location = new Point(73, 352);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(115, 51);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(681, 14);
            label4.Name = "label4";
            label4.Size = new Size(166, 40);
            label4.TabIndex = 12;
            label4.Text = "Airplane Routes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AirplaneRouteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 465);
            Controls.Add(label4);
            Controls.Add(updateBtn);
            Controls.Add(dltbutton);
            Controls.Add(DurationTXT);
            Controls.Add(PriceTXT);
            Controls.Add(comboAirplene);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_airRoute);
            Controls.Add(button1);
            Controls.Add(combRoute);
            Controls.Add(AP_label);
            Name = "AirplaneRouteForm";
            Text = "AirplaneRouteForm";
            ((System.ComponentModel.ISupportInitialize)dgv_airRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AP_label;
        private ComboBox combRoute;
        private Button button1;
        private DataGridView dgv_airRoute;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboAirplene;
        private TextBox PriceTXT;
        private TextBox DurationTXT;
        private Button dltbutton;
        private Button updateBtn;
        private Label label4;
    }
}