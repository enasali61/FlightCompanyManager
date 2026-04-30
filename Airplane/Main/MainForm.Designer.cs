namespace Airplane.Main
{
    partial class MainForm
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
            lblWelcome = new Label();
            btnAirline = new Button();
            btnRoutes = new Button();
            btnAirlineAdd = new Button();
            btnAirlinePhones = new Button();
            btnAirplanes = new Button();
            btnAirplaneRoute = new Button();
            btnEmployees = new Button();
            btnEmpAdd = new Button();
            btnLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(271, 38);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnAirline
            // 
            btnAirline.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAirline.ForeColor = Color.Chocolate;
            btnAirline.Location = new Point(60, 121);
            btnAirline.Name = "btnAirline";
            btnAirline.Size = new Size(169, 54);
            btnAirline.TabIndex = 17;
            btnAirline.Text = "Airline";
            btnAirline.UseVisualStyleBackColor = true;
            btnAirline.Click += btnAirline_Click_1;
            // 
            // btnRoutes
            // 
            btnRoutes.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoutes.ForeColor = Color.Chocolate;
            btnRoutes.Location = new Point(316, 121);
            btnRoutes.Name = "btnRoutes";
            btnRoutes.Size = new Size(154, 54);
            btnRoutes.TabIndex = 18;
            btnRoutes.Text = "Routes";
            btnRoutes.UseVisualStyleBackColor = true;
            btnRoutes.Click += btnRoutes_Click_1;
            // 
            // btnAirlineAdd
            // 
            btnAirlineAdd.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAirlineAdd.ForeColor = Color.Chocolate;
            btnAirlineAdd.Location = new Point(43, 279);
            btnAirlineAdd.Name = "btnAirlineAdd";
            btnAirlineAdd.Size = new Size(199, 54);
            btnAirlineAdd.TabIndex = 19;
            btnAirlineAdd.Text = "Add Airline Address";
            btnAirlineAdd.UseVisualStyleBackColor = true;
            btnAirlineAdd.Click += btnAirlineAdd_Click_1;
            // 
            // btnAirlinePhones
            // 
            btnAirlinePhones.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAirlinePhones.ForeColor = Color.Chocolate;
            btnAirlinePhones.Location = new Point(43, 194);
            btnAirlinePhones.Name = "btnAirlinePhones";
            btnAirlinePhones.Size = new Size(199, 54);
            btnAirlinePhones.TabIndex = 20;
            btnAirlinePhones.Text = "Airline Phones";
            btnAirlinePhones.UseVisualStyleBackColor = true;
            btnAirlinePhones.Click += btnAirlinePhones_Click_1;
            // 
            // btnAirplanes
            // 
            btnAirplanes.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAirplanes.ForeColor = Color.Chocolate;
            btnAirplanes.Location = new Point(316, 194);
            btnAirplanes.Name = "btnAirplanes";
            btnAirplanes.Size = new Size(154, 54);
            btnAirplanes.TabIndex = 21;
            btnAirplanes.Text = "Airplanes";
            btnAirplanes.UseVisualStyleBackColor = true;
            btnAirplanes.Click += btnAirplanes_Click_1;
            // 
            // btnAirplaneRoute
            // 
            btnAirplaneRoute.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAirplaneRoute.ForeColor = Color.Chocolate;
            btnAirplaneRoute.Location = new Point(535, 194);
            btnAirplaneRoute.Name = "btnAirplaneRoute";
            btnAirplaneRoute.Size = new Size(208, 54);
            btnAirplaneRoute.TabIndex = 22;
            btnAirplaneRoute.Text = "Airplane Routes";
            btnAirplaneRoute.UseVisualStyleBackColor = true;
            btnAirplaneRoute.Click += btnAirplaneRoute_Click_1;
            // 
            // btnEmployees
            // 
            btnEmployees.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = Color.Chocolate;
            btnEmployees.Location = new Point(316, 279);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(154, 54);
            btnEmployees.TabIndex = 23;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click_1;
            // 
            // btnEmpAdd
            // 
            btnEmpAdd.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpAdd.ForeColor = Color.Chocolate;
            btnEmpAdd.Location = new Point(535, 121);
            btnEmpAdd.Name = "btnEmpAdd";
            btnEmpAdd.Size = new Size(208, 54);
            btnEmpAdd.TabIndex = 24;
            btnEmpAdd.Text = "Add Employee Address";
            btnEmpAdd.UseVisualStyleBackColor = true;
            btnEmpAdd.Click += btnEmpAdd_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Chocolate;
            btnLogout.Location = new Point(563, 279);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(154, 54);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(195, 31);
            label1.Name = "label1";
            label1.Size = new Size(450, 40);
            label1.TabIndex = 26;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 440);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnEmpAdd);
            Controls.Add(btnEmployees);
            Controls.Add(btnAirplaneRoute);
            Controls.Add(btnAirplanes);
            Controls.Add(btnAirlinePhones);
            Controls.Add(btnAirlineAdd);
            Controls.Add(btnRoutes);
            Controls.Add(btnAirline);
            Controls.Add(lblWelcome);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAirline;
        private Button btnRoutes;
        private Button btnAirlineAdd;
        private Button btnAirlinePhones;
        private Button btnAirplanes;
        private Button btnAirplaneRoute;
        private Button btnEmployees;
        private Button btnEmpAdd;
        private Button btnLogout;
        private Label label1;
    }
}