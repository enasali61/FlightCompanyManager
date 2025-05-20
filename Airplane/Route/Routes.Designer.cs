namespace Airplane.Route
{
    partial class Routes
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
            dgv_Route = new DataGridView();
            routeIdTXT = new TextBox();
            txt_diste = new Label();
            txt_destance = new Label();
            routeIdLBL = new Label();
            destinationTXT = new TextBox();
            distanceTXT = new TextBox();
            updateBtn = new Button();
            deleteBtn = new Button();
            inertBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Route).BeginInit();
            SuspendLayout();
            // 
            // dgv_Route
            // 
            dgv_Route.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Route.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Route.Location = new Point(644, 115);
            dgv_Route.Margin = new Padding(3, 4, 3, 4);
            dgv_Route.Name = "dgv_Route";
            dgv_Route.ReadOnly = true;
            dgv_Route.RowHeadersWidth = 51;
            dgv_Route.Size = new Size(650, 381);
            dgv_Route.TabIndex = 15;
            dgv_Route.RowEnter += dgv_Route_RowEnter;
            // 
            // routeIdTXT
            // 
            routeIdTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeIdTXT.Location = new Point(300, 115);
            routeIdTXT.Margin = new Padding(3, 4, 3, 4);
            routeIdTXT.Name = "routeIdTXT";
            routeIdTXT.Size = new Size(215, 34);
            routeIdTXT.TabIndex = 12;
            // 
            // txt_diste
            // 
            txt_diste.BackColor = SystemColors.ControlLightLight;
            txt_diste.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_diste.ForeColor = SystemColors.Highlight;
            txt_diste.Location = new Point(84, 298);
            txt_diste.Name = "txt_diste";
            txt_diste.Size = new Size(145, 34);
            txt_diste.TabIndex = 11;
            txt_diste.Text = "Destination ";
            txt_diste.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_destance
            // 
            txt_destance.BackColor = SystemColors.ControlLightLight;
            txt_destance.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_destance.ForeColor = SystemColors.Highlight;
            txt_destance.Location = new Point(97, 206);
            txt_destance.Name = "txt_destance";
            txt_destance.Size = new Size(116, 34);
            txt_destance.TabIndex = 10;
            txt_destance.Text = "Distance";
            txt_destance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // routeIdLBL
            // 
            routeIdLBL.BackColor = SystemColors.ControlLightLight;
            routeIdLBL.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeIdLBL.ForeColor = SystemColors.Highlight;
            routeIdLBL.Location = new Point(110, 115);
            routeIdLBL.Name = "routeIdLBL";
            routeIdLBL.Size = new Size(94, 36);
            routeIdLBL.TabIndex = 9;
            routeIdLBL.Text = "Route Id";
            routeIdLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // destinationTXT
            // 
            destinationTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            destinationTXT.Location = new Point(300, 298);
            destinationTXT.Margin = new Padding(3, 4, 3, 4);
            destinationTXT.Name = "destinationTXT";
            destinationTXT.Size = new Size(215, 34);
            destinationTXT.TabIndex = 20;
            // 
            // distanceTXT
            // 
            distanceTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            distanceTXT.Location = new Point(300, 206);
            distanceTXT.Margin = new Padding(3, 4, 3, 4);
            distanceTXT.Name = "distanceTXT";
            distanceTXT.Size = new Size(215, 34);
            distanceTXT.TabIndex = 21;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Chocolate;
            updateBtn.Location = new Point(453, 442);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(154, 54);
            updateBtn.TabIndex = 24;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Chocolate;
            deleteBtn.Location = new Point(256, 442);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(154, 54);
            deleteBtn.TabIndex = 23;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // inertBtn
            // 
            inertBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inertBtn.ForeColor = Color.Chocolate;
            inertBtn.Location = new Point(59, 442);
            inertBtn.Name = "inertBtn";
            inertBtn.Size = new Size(154, 54);
            inertBtn.TabIndex = 22;
            inertBtn.Text = "Insert";
            inertBtn.UseVisualStyleBackColor = true;
            inertBtn.Click += inertBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(721, 52);
            label1.Name = "label1";
            label1.Size = new Size(104, 48);
            label1.TabIndex = 25;
            label1.Text = "Routes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Routes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 682);
            Controls.Add(label1);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(inertBtn);
            Controls.Add(distanceTXT);
            Controls.Add(destinationTXT);
            Controls.Add(dgv_Route);
            Controls.Add(routeIdTXT);
            Controls.Add(txt_diste);
            Controls.Add(txt_destance);
            Controls.Add(routeIdLBL);
            Name = "Routes";
            Text = "Routes";
            ((System.ComponentModel.ISupportInitialize)dgv_Route).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Route;
        private TextBox routeIdTXT;
        private Label txt_diste;
        private Label txt_destance;
        private Label routeIdLBL;
        private TextBox destinationTXT;
        private TextBox distanceTXT;
        private Button updateBtn;
        private Button deleteBtn;
        private Button inertBtn;
        private Label label1;
    }
}