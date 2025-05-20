namespace Airplane.AirLine_Address
{
    partial class AirlineAddForm
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
            addTXT = new TextBox();
            Addlabel = new Label();
            label_id = new Label();
            button1 = new Button();
            UpdateBtn = new Button();
            DeleteBTN = new Button();
            dgvAddress = new DataGridView();
            addlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAddress).BeginInit();
            SuspendLayout();
            // 
            // combo_airId
            // 
            combo_airId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_airId.FormattingEnabled = true;
            combo_airId.Location = new Point(404, 67);
            combo_airId.Name = "combo_airId";
            combo_airId.Size = new Size(151, 33);
            combo_airId.TabIndex = 0;
            // 
            // addTXT
            // 
            addTXT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTXT.Location = new Point(404, 125);
            addTXT.Name = "addTXT";
            addTXT.Size = new Size(151, 31);
            addTXT.TabIndex = 1;
            // 
            // Addlabel
            // 
            Addlabel.BackColor = SystemColors.ControlLightLight;
            Addlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addlabel.ForeColor = SystemColors.Highlight;
            Addlabel.Location = new Point(187, 125);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(156, 39);
            Addlabel.TabIndex = 2;
            Addlabel.Text = "Airline Address";
            Addlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_id
            // 
            label_id.BackColor = SystemColors.ControlLightLight;
            label_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_id.ForeColor = SystemColors.Highlight;
            label_id.Location = new Point(187, 67);
            label_id.Name = "label_id";
            label_id.Size = new Size(156, 33);
            label_id.TabIndex = 3;
            label_id.Text = "Airline Id";
            label_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(149, 267);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 4;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.DarkOrange;
            UpdateBtn.Location = new Point(456, 267);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(108, 41);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBTN.ForeColor = Color.DarkOrange;
            DeleteBTN.Location = new Point(305, 267);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(108, 41);
            DeleteBTN.TabIndex = 6;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // dgvAddress
            // 
            dgvAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddress.Location = new Point(717, 67);
            dgvAddress.Name = "dgvAddress";
            dgvAddress.RowHeadersWidth = 51;
            dgvAddress.Size = new Size(564, 290);
            dgvAddress.TabIndex = 7;
            dgvAddress.RowEnter += dgvAddress_RowEnter;
            // 
            // addlbl
            // 
            addlbl.BackColor = SystemColors.ControlLightLight;
            addlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addlbl.ForeColor = SystemColors.Highlight;
            addlbl.Location = new Point(752, 22);
            addlbl.Name = "addlbl";
            addlbl.Size = new Size(246, 33);
            addlbl.TabIndex = 8;
            addlbl.Text = "Airline Addresses";
            addlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AirlineAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 450);
            Controls.Add(addlbl);
            Controls.Add(dgvAddress);
            Controls.Add(DeleteBTN);
            Controls.Add(UpdateBtn);
            Controls.Add(button1);
            Controls.Add(label_id);
            Controls.Add(Addlabel);
            Controls.Add(addTXT);
            Controls.Add(combo_airId);
            Name = "AirlineAddForm";
            Text = "AirlineAddForm";
            ((System.ComponentModel.ISupportInitialize)dgvAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_airId;
        private TextBox addTXT;
        private Label Addlabel;
        private Label label_id;
        private Button button1;
        private Button UpdateBtn;
        private Button DeleteBTN;
        private DataGridView dgvAddress;
        private Label addlbl;
    }
}