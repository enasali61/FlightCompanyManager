namespace Airplane.AirLine
{
    partial class Airline
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            NameTXT = new TextBox();
            AiridTXT = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgv_airline = new DataGridView();
            airlineLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_airline).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(474, 326);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(116, 42);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(289, 326);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(92, 326);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(116, 42);
            button1.TabIndex = 11;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NameTXT
            // 
            NameTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTXT.Location = new Point(314, 183);
            NameTXT.Margin = new Padding(2);
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(118, 34);
            NameTXT.TabIndex = 10;
            // 
            // AiridTXT
            // 
            AiridTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AiridTXT.Location = new Point(314, 102);
            AiridTXT.Margin = new Padding(2);
            AiridTXT.Name = "AiridTXT";
            AiridTXT.Size = new Size(118, 34);
            AiridTXT.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(147, 183);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(124, 104);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 7;
            label1.Text = "AirLine Id";
            // 
            // dgv_airline
            // 
            dgv_airline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_airline.Location = new Point(697, 57);
            dgv_airline.Name = "dgv_airline";
            dgv_airline.RowHeadersWidth = 51;
            dgv_airline.Size = new Size(625, 311);
            dgv_airline.TabIndex = 14;
            dgv_airline.RowEnter += dataGridView1_RowEnter;
            // 
            // airlineLbl
            // 
            airlineLbl.AutoSize = true;
            airlineLbl.BackColor = SystemColors.ButtonHighlight;
            airlineLbl.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            airlineLbl.ForeColor = SystemColors.Highlight;
            airlineLbl.Location = new Point(745, 9);
            airlineLbl.Margin = new Padding(2, 0, 2, 0);
            airlineLbl.Name = "airlineLbl";
            airlineLbl.Size = new Size(106, 32);
            airlineLbl.TabIndex = 15;
            airlineLbl.Text = "AirLines";
            // 
            // Airline
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 450);
            Controls.Add(airlineLbl);
            Controls.Add(dgv_airline);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NameTXT);
            Controls.Add(AiridTXT);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Airline";
            Text = "Airline";
            ((System.ComponentModel.ISupportInitialize)dgv_airline).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox NameTXT;
        private TextBox AiridTXT;
        private Label label2;
        private Label label1;
        private DataGridView dgv_airline;
        private Label airlineLbl;
    }
}