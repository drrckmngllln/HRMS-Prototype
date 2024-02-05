using HRMS.Forms.Settings;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Forms
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (panelSettings.Visible == false)
            {
                panelSettings.Visible = true;
            }
            else
            {
                panelSettings.Visible = false;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmEmployees();
            panelTask.Controls.Clear();
            frm.TopLevel = false;
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {

        }

        private void btnAccessLevels_Click(object sender, EventArgs e)
        {
            var frm = new frmAccessLevels();
            panelTask.Controls.Clear();
            frm.TopLevel = false;
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmUserManagement();
            panelTask.Controls.Clear();
            frm.TopLevel = false;
            panelTask.Controls.Add(frm);
            frm.Show();
        }
    }
}
