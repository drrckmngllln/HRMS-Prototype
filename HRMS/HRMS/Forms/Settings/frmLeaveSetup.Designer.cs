namespace HRMS.Forms.Settings
{
    partial class frmLeaveSetup
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
            tLeaveType = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            dgv = new DataGridView();
            tCredits = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // tLeaveType
            // 
            tLeaveType.CueHint.CueHintText = "Leave Type";
            tLeaveType.Location = new Point(40, 90);
            tLeaveType.Name = "tLeaveType";
            tLeaveType.Size = new Size(228, 23);
            tLeaveType.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 25;
            label1.Text = "Leave Setup";
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = 10F;
            kryptonButton2.Location = new Point(157, 165);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(111, 34);
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 10F;
            kryptonButton2.TabIndex = 24;
            kryptonButton2.Values.Text = "Clear";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 10F;
            kryptonButton1.Location = new Point(40, 165);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(111, 34);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.TabIndex = 23;
            kryptonButton1.Values.Text = "Save";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(342, 90);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(446, 350);
            dgv.TabIndex = 22;
            // 
            // tCredits
            // 
            tCredits.CueHint.CueHintText = "Credits";
            tCredits.Location = new Point(40, 119);
            tCredits.Name = "tCredits";
            tCredits.Size = new Size(228, 23);
            tCredits.TabIndex = 27;
            // 
            // frmLeaveSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tCredits);
            Controls.Add(tLeaveType);
            Controls.Add(label1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLeaveSetup";
            Text = "frmLeaveSetup";
            WindowState = FormWindowState.Maximized;
            Load += frmLeaveSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox tLeaveType;
        private Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private DataGridView dgv;
        private Krypton.Toolkit.KryptonTextBox tCredits;
    }
}