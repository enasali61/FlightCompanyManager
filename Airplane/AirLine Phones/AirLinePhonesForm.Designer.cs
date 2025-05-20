namespace Airplane.AirLine_Phones
{
    partial class AirLinePhonesForm
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
            addlbl = new Label();
            dgvAddress = new DataGridView();
            DeleteBTN = new Button();
            UpdateBtn = new Button();
            button1 = new Button();
            label_id = new Label();
            Addlabel = new Label();
            phoTXT = new TextBox();
            combo_airId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAddress).BeginInit();
            SuspendLayout();
            // 
            // addlbl
            // 
            addlbl.BackColor = SystemColors.ControlLightLight;
            addlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addlbl.ForeColor = SystemColors.Highlight;
            addlbl.Location = new Point(752, 58);
            addlbl.Name = "addlbl";
            addlbl.Size = new Size(246, 33);
            addlbl.TabIndex = 17;
            addlbl.Text = "Airline Phones";
            addlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAddress
            // 
            dgvAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddress.Location = new Point(717, 103);
            dgvAddress.Name = "dgvAddress";
            dgvAddress.RowHeadersWidth = 51;
            dgvAddress.Size = new Size(564, 290);
            dgvAddress.TabIndex = 16;
            dgvAddress.RowEnter += dgvAddress_RowEnter_1;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBTN.ForeColor = Color.DarkOrange;
            DeleteBTN.Location = new Point(305, 303);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(108, 41);
            DeleteBTN.TabIndex = 15;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click_1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.DarkOrange;
            UpdateBtn.Location = new Point(456, 303);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(108, 41);
            UpdateBtn.TabIndex = 14;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(149, 303);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_id
            // 
            label_id.BackColor = SystemColors.ControlLightLight;
            label_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_id.ForeColor = SystemColors.Highlight;
            label_id.Location = new Point(187, 103);
            label_id.Name = "label_id";
            label_id.Size = new Size(156, 33);
            label_id.TabIndex = 12;
            label_id.Text = "Airline Id";
            label_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Addlabel
            // 
            Addlabel.BackColor = SystemColors.ControlLightLight;
            Addlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addlabel.ForeColor = SystemColors.Highlight;
            Addlabel.Location = new Point(187, 161);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(156, 39);
            Addlabel.TabIndex = 11;
            Addlabel.Text = "Airline Phone";
            Addlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoTXT
            // 
            phoTXT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoTXT.Location = new Point(404, 161);
            phoTXT.Name = "phoTXT";
            phoTXT.Size = new Size(151, 31);
            phoTXT.TabIndex = 10;
            // 
            // combo_airId
            // 
            combo_airId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_airId.FormattingEnabled = true;
            combo_airId.Location = new Point(404, 103);
            combo_airId.Name = "combo_airId";
            combo_airId.Size = new Size(151, 33);
            combo_airId.TabIndex = 9;
            // 
            // AirLinePhonesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 450);
            Controls.Add(addlbl);
            Controls.Add(dgvAddress);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBtn);
            Controls.Add(button1);
            Controls.Add(label_id);
            Controls.Add(Addlabel);
            Controls.Add(phoTXT);
            Controls.Add(combo_airId);
            Name = "AirLinePhonesForm";
            Text = "AirLinePhonesForm";
            ((System.ComponentModel.ISupportInitialize)dgvAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addlbl;
        private DataGridView dgvAddress;
        private Button DeleteBTN;
        private Button UpdateBtn;
        private Button button1;
        private Label label_id;
        private Label Addlabel;
        private TextBox phoTXT;
        private ComboBox combo_airId;
    }
}