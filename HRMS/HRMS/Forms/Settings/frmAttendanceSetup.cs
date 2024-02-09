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
    public partial class frmAttendanceSetup : Form
    {
        StoreContext _context= new StoreContext();
        public frmAttendanceSetup()
        {
            InitializeComponent();
        }

        private async void frmAttendanceSetup_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task<List<AttendanceSetup>> GetAttendanceSetups()
        {
            var attendance = _context.AttendanceSetups.ToListAsync();
            return await attendance;
        }

        private async Task loadRecords()
        {
            dgv.DataSource = await GetAttendanceSetups();
            dgv.Columns["Id"].Visible = false;
        }
    }
}
