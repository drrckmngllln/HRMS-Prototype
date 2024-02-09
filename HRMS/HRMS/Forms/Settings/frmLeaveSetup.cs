using HRMS.Entities;
using HRMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.Forms.Settings
{
    public partial class frmLeaveSetup : Form
    {
        StoreContext _context = new StoreContext();
        public frmLeaveSetup()
        {
            InitializeComponent();
        }

        private async void frmLeaveSetup_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task<List<LeaveSetup>> GetLeaveSetupAsync()
        {
            var leave = _context.LeaveSetups.ToListAsync();
            return await leave;
        }

        private async Task loadRecords()
        {
            dgv.DataSource = await GetLeaveSetupAsync();
            dgv.Columns["Id"].Visible = false;
        }
    }
}
