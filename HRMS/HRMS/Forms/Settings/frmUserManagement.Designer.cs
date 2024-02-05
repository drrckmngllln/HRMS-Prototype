namespace HRMS.Forms.Settings
{
    partial class frmUserManagement
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
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            dgv = new DataGridView();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            tAccessLevels = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tAccessLevels).BeginInit();
            SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.CueHint.CueHintText = "Name";
            kryptonTextBox1.Location = new Point(40, 88);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(228, 23);
            kryptonTextBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 12;
            label1.Text = "User Management";
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = 10F;
            kryptonButton2.Location = new Point(157, 227);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(111, 34);
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 10F;
            kryptonButton2.TabIndex = 11;
            kryptonButton2.Values.Text = "Clear";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 10F;
            kryptonButton1.Location = new Point(40, 227);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(111, 34);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.TabIndex = 10;
            kryptonButton1.Values.Text = "Save";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(342, 88);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(446, 350);
            dgv.TabIndex = 9;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.CueHint.CueHintText = "Username";
            kryptonTextBox2.Location = new Point(40, 117);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(228, 23);
            kryptonTextBox2.TabIndex = 14;
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.CueHint.CueHintText = "Password";
            kryptonTextBox3.Location = new Point(40, 146);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(228, 23);
            kryptonTextBox3.TabIndex = 15;
            // 
            // tAccessLevels
            // 
            tAccessLevels.DropDownWidth = 228;
            tAccessLevels.IntegralHeight = false;
            tAccessLevels.Location = new Point(40, 175);
            tAccessLevels.Name = "tAccessLevels";
            tAccessLevels.Size = new Size(228, 21);
            tAccessLevels.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            tAccessLevels.TabIndex = 16;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tAccessLevels);
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(label1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUserManagement";
            Text = "frmUserManagement";
            WindowState = FormWindowState.Maximized;
            Load += frmUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)tAccessLevels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private DataGridView dgv;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonComboBox tAccessLevels;
    }
}