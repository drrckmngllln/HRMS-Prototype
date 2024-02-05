namespace HRMS.Forms.Auth
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            tUsername = new Krypton.Toolkit.KryptonTextBox();
            tPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_design;
            pictureBox1.Location = new Point(193, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tUsername
            // 
            tUsername.CornerRoundingRadius = 10F;
            tUsername.CueHint.CueHintText = "Username";
            tUsername.CueHint.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tUsername.Location = new Point(163, 250);
            tUsername.Name = "tUsername";
            tUsername.Size = new Size(336, 29);
            tUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tUsername.StateCommon.Border.Rounding = 10F;
            tUsername.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tUsername.TabIndex = 1;
            // 
            // tPassword
            // 
            tPassword.CornerRoundingRadius = 10F;
            tPassword.CueHint.CueHintText = "Password";
            tPassword.CueHint.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tPassword.Location = new Point(163, 285);
            tPassword.Name = "tPassword";
            tPassword.Size = new Size(336, 29);
            tPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tPassword.StateCommon.Border.Rounding = 10F;
            tPassword.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tPassword.TabIndex = 2;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 10F;
            kryptonButton1.Location = new Point(183, 332);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(290, 41);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonButton1.TabIndex = 3;
            kryptonButton1.Values.Text = "Login";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(kryptonButton1);
            Controls.Add(tPassword);
            Controls.Add(tUsername);
            Controls.Add(pictureBox1);
            CornerRoundingRadius = 10F;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Back.Color1 = SystemColors.Control;
            StateActive.Back.Color2 = SystemColors.Control;
            StateCommon.Back.Color1 = SystemColors.Control;
            StateCommon.Back.Color2 = SystemColors.Control;
            StateCommon.Border.Color1 = SystemColors.Control;
            StateCommon.Border.Color2 = SystemColors.Control;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 10F;
            StateCommon.Header.Back.Color1 = SystemColors.Control;
            StateCommon.Header.Back.Color2 = SystemColors.Control;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox tUsername;
        private Krypton.Toolkit.KryptonTextBox tPassword;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}