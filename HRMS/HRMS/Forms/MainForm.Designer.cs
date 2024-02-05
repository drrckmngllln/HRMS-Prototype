namespace HRMS.Forms
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
            panelSidebar = new Panel();
            panelMenu = new Panel();
            panelSettings = new Panel();
            button1 = new Button();
            btnAccessLevels = new Button();
            btnLeaveCredits = new Button();
            btnAttendance = new Button();
            btnPositions = new Button();
            btnDepartments = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnAttendanceMonitoring = new Button();
            btnLeaveMgmt = new Button();
            btnEmployee = new Button();
            panelUser = new Panel();
            panelTask = new Panel();
            panelSidebar.SuspendLayout();
            panelMenu.SuspendLayout();
            panelSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(25, 25, 25);
            panelSidebar.Controls.Add(panelMenu);
            panelSidebar.Controls.Add(panelUser);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(265, 778);
            panelSidebar.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(panelSettings);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnAttendanceMonitoring);
            panelMenu.Controls.Add(btnLeaveMgmt);
            panelMenu.Controls.Add(btnEmployee);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 199);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(265, 579);
            panelMenu.TabIndex = 1;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(button1);
            panelSettings.Controls.Add(btnAccessLevels);
            panelSettings.Controls.Add(btnLeaveCredits);
            panelSettings.Controls.Add(btnAttendance);
            panelSettings.Controls.Add(btnPositions);
            panelSettings.Controls.Add(btnDepartments);
            panelSettings.Dock = DockStyle.Top;
            panelSettings.Location = new Point(0, 240);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(265, 303);
            panelSettings.TabIndex = 6;
            panelSettings.Visible = false;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 240);
            button1.Name = "button1";
            button1.Padding = new Padding(45, 0, 0, 0);
            button1.Size = new Size(265, 48);
            button1.TabIndex = 11;
            button1.Text = "User Managment";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAccessLevels
            // 
            btnAccessLevels.Dock = DockStyle.Top;
            btnAccessLevels.FlatAppearance.BorderSize = 0;
            btnAccessLevels.FlatStyle = FlatStyle.Flat;
            btnAccessLevels.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccessLevels.ForeColor = SystemColors.Control;
            btnAccessLevels.Location = new Point(0, 192);
            btnAccessLevels.Name = "btnAccessLevels";
            btnAccessLevels.Padding = new Padding(45, 0, 0, 0);
            btnAccessLevels.Size = new Size(265, 48);
            btnAccessLevels.TabIndex = 10;
            btnAccessLevels.Text = "Access Levels";
            btnAccessLevels.TextAlign = ContentAlignment.MiddleLeft;
            btnAccessLevels.UseVisualStyleBackColor = true;
            btnAccessLevels.Click += btnAccessLevels_Click;
            // 
            // btnLeaveCredits
            // 
            btnLeaveCredits.Dock = DockStyle.Top;
            btnLeaveCredits.FlatAppearance.BorderSize = 0;
            btnLeaveCredits.FlatStyle = FlatStyle.Flat;
            btnLeaveCredits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeaveCredits.ForeColor = SystemColors.Control;
            btnLeaveCredits.Location = new Point(0, 144);
            btnLeaveCredits.Name = "btnLeaveCredits";
            btnLeaveCredits.Padding = new Padding(45, 0, 0, 0);
            btnLeaveCredits.Size = new Size(265, 48);
            btnLeaveCredits.TabIndex = 9;
            btnLeaveCredits.Text = "Leave Credit";
            btnLeaveCredits.TextAlign = ContentAlignment.MiddleLeft;
            btnLeaveCredits.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttendance.ForeColor = SystemColors.Control;
            btnAttendance.Location = new Point(0, 96);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(45, 0, 0, 0);
            btnAttendance.Size = new Size(265, 48);
            btnAttendance.TabIndex = 8;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnPositions
            // 
            btnPositions.Dock = DockStyle.Top;
            btnPositions.FlatAppearance.BorderSize = 0;
            btnPositions.FlatStyle = FlatStyle.Flat;
            btnPositions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPositions.ForeColor = SystemColors.Control;
            btnPositions.Location = new Point(0, 48);
            btnPositions.Name = "btnPositions";
            btnPositions.Padding = new Padding(45, 0, 0, 0);
            btnPositions.Size = new Size(265, 48);
            btnPositions.TabIndex = 7;
            btnPositions.Text = "Positions";
            btnPositions.TextAlign = ContentAlignment.MiddleLeft;
            btnPositions.UseVisualStyleBackColor = true;
            // 
            // btnDepartments
            // 
            btnDepartments.Dock = DockStyle.Top;
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepartments.ForeColor = SystemColors.Control;
            btnDepartments.Location = new Point(0, 0);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Padding = new Padding(45, 0, 0, 0);
            btnDepartments.Size = new Size(265, 48);
            btnDepartments.TabIndex = 6;
            btnDepartments.Text = "Departments";
            btnDepartments.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.Control;
            btnSettings.Location = new Point(0, 192);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(35, 0, 0, 0);
            btnSettings.Size = new Size(265, 48);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.Control;
            btnReports.Location = new Point(0, 144);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(35, 0, 0, 0);
            btnReports.Size = new Size(265, 48);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnAttendanceMonitoring
            // 
            btnAttendanceMonitoring.Dock = DockStyle.Top;
            btnAttendanceMonitoring.FlatAppearance.BorderSize = 0;
            btnAttendanceMonitoring.FlatStyle = FlatStyle.Flat;
            btnAttendanceMonitoring.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAttendanceMonitoring.ForeColor = SystemColors.Control;
            btnAttendanceMonitoring.Location = new Point(0, 96);
            btnAttendanceMonitoring.Name = "btnAttendanceMonitoring";
            btnAttendanceMonitoring.Padding = new Padding(35, 0, 0, 0);
            btnAttendanceMonitoring.Size = new Size(265, 48);
            btnAttendanceMonitoring.TabIndex = 3;
            btnAttendanceMonitoring.Text = "Attendance Monitoring";
            btnAttendanceMonitoring.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendanceMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnLeaveMgmt
            // 
            btnLeaveMgmt.Dock = DockStyle.Top;
            btnLeaveMgmt.FlatAppearance.BorderSize = 0;
            btnLeaveMgmt.FlatStyle = FlatStyle.Flat;
            btnLeaveMgmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLeaveMgmt.ForeColor = SystemColors.Control;
            btnLeaveMgmt.Location = new Point(0, 48);
            btnLeaveMgmt.Name = "btnLeaveMgmt";
            btnLeaveMgmt.Padding = new Padding(35, 0, 0, 0);
            btnLeaveMgmt.Size = new Size(265, 48);
            btnLeaveMgmt.TabIndex = 2;
            btnLeaveMgmt.Text = "Leave Management";
            btnLeaveMgmt.TextAlign = ContentAlignment.MiddleLeft;
            btnLeaveMgmt.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.Control;
            btnEmployee.Location = new Point(0, 0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(35, 0, 0, 0);
            btnEmployee.Size = new Size(265, 48);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Employees";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panelUser
            // 
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(265, 199);
            panelUser.TabIndex = 0;
            // 
            // panelTask
            // 
            panelTask.BackgroundImage = Properties.Resources.Untitled_design;
            panelTask.BackgroundImageLayout = ImageLayout.Center;
            panelTask.Dock = DockStyle.Fill;
            panelTask.Location = new Point(265, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1054, 778);
            panelTask.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 778);
            ControlBox = false;
            Controls.Add(panelTask);
            Controls.Add(panelSidebar);
            CornerRoundingRadius = 10F;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Back.Color1 = Color.FromArgb(25, 25, 25);
            StateActive.Back.Color2 = Color.FromArgb(25, 25, 25);
            StateActive.Border.Color1 = Color.FromArgb(25, 25, 25);
            StateActive.Border.Color2 = Color.FromArgb(25, 25, 25);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Header.Back.Color1 = Color.FromArgb(25, 25, 25);
            StateActive.Header.Back.Color2 = Color.FromArgb(25, 25, 25);
            StateActive.Header.Border.Color1 = Color.FromArgb(25, 25, 25);
            StateActive.Header.Border.Color2 = Color.FromArgb(25, 25, 25);
            StateActive.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Header.Content.ShortText.Color1 = SystemColors.Control;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 10F;
            StateInactive.Back.Color1 = Color.FromArgb(25, 25, 25);
            StateInactive.Back.Color2 = Color.FromArgb(25, 25, 25);
            StateInactive.Border.Color1 = Color.FromArgb(25, 25, 25);
            StateInactive.Border.Color2 = Color.FromArgb(25, 25, 25);
            StateInactive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateInactive.Header.Back.Color1 = Color.FromArgb(25, 25, 25);
            StateInactive.Header.Back.Color2 = Color.FromArgb(25, 25, 25);
            Text = "MainForm";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelUser;
        private Panel panelMenu;
        private Panel panelSettings;
        private Button btnDepartments;
        private Button btnSettings;
        private Button btnReports;
        private Button btnAttendanceMonitoring;
        private Button btnLeaveMgmt;
        private Button btnEmployee;
        private Button btnAccessLevels;
        private Button btnLeaveCredits;
        private Button btnAttendance;
        private Button btnPositions;
        private Button button1;
        private Panel panelTask;
    }
}