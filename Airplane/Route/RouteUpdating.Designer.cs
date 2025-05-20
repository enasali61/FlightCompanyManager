namespace Airplane.Route
{
    partial class RouteUpdating
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
            updateBtn = new Button();
            distanceTXT = new TextBox();
            destinationTXT = new TextBox();
            routeIdTXT = new TextBox();
            txt_diste = new Label();
            txt_destance = new Label();
            routeIdLBL = new Label();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Chocolate;
            updateBtn.Location = new Point(270, 305);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(154, 54);
            updateBtn.TabIndex = 33;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // distanceTXT
            // 
            distanceTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            distanceTXT.Location = new Point(367, 126);
            distanceTXT.Margin = new Padding(3, 4, 3, 4);
            distanceTXT.Name = "distanceTXT";
            distanceTXT.Size = new Size(215, 34);
            distanceTXT.TabIndex = 30;
            // 
            // destinationTXT
            // 
            destinationTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            destinationTXT.Location = new Point(367, 218);
            destinationTXT.Margin = new Padding(3, 4, 3, 4);
            destinationTXT.Name = "destinationTXT";
            destinationTXT.Size = new Size(215, 34);
            destinationTXT.TabIndex = 29;
            // 
            // routeIdTXT
            // 
            routeIdTXT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeIdTXT.Location = new Point(367, 35);
            routeIdTXT.Margin = new Padding(3, 4, 3, 4);
            routeIdTXT.Name = "routeIdTXT";
            routeIdTXT.Size = new Size(215, 34);
            routeIdTXT.TabIndex = 28;
            // 
            // txt_diste
            // 
            txt_diste.BackColor = SystemColors.ControlLightLight;
            txt_diste.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_diste.ForeColor = SystemColors.Highlight;
            txt_diste.Location = new Point(151, 218);
            txt_diste.Name = "txt_diste";
            txt_diste.Size = new Size(145, 34);
            txt_diste.TabIndex = 27;
            txt_diste.Text = "Destination ";
            txt_diste.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_destance
            // 
            txt_destance.BackColor = SystemColors.ControlLightLight;
            txt_destance.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_destance.ForeColor = SystemColors.Highlight;
            txt_destance.Location = new Point(164, 126);
            txt_destance.Name = "txt_destance";
            txt_destance.Size = new Size(116, 34);
            txt_destance.TabIndex = 26;
            txt_destance.Text = "Distance";
            txt_destance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // routeIdLBL
            // 
            routeIdLBL.BackColor = SystemColors.ControlLightLight;
            routeIdLBL.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeIdLBL.ForeColor = SystemColors.Highlight;
            routeIdLBL.Location = new Point(177, 35);
            routeIdLBL.Name = "routeIdLBL";
            routeIdLBL.Size = new Size(94, 36);
            routeIdLBL.TabIndex = 25;
            routeIdLBL.Text = "Route Id";
            routeIdLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RouteUpdating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateBtn);
            Controls.Add(distanceTXT);
            Controls.Add(destinationTXT);
            Controls.Add(routeIdTXT);
            Controls.Add(txt_diste);
            Controls.Add(txt_destance);
            Controls.Add(routeIdLBL);
            Name = "RouteUpdating";
            Text = "RouteUpdating";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private TextBox distanceTXT;
        private TextBox destinationTXT;
        private TextBox routeIdTXT;
        private Label txt_diste;
        private Label txt_destance;
        private Label routeIdLBL;
    }
}