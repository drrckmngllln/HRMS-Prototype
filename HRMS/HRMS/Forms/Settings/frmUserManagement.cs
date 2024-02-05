using HRMS.DTO;
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
    public partial class frmUserManagement : Form
    {
        StoreContext _context = new StoreContext();
        public frmUserManagement()
        {
            InitializeComponent();
        }

        private async void frmUserManagement_Load(object sender, EventArgs e)
        {
            await loadAccessLevels();
            await loadRecords();
        }

        private async Task loadAccessLevels()
        {
            tAccessLevels.ValueMember = "Id";
            tAccessLevels.DisplayMember = "Name";
            tAccessLevels.DataSource = await GetAccessLevelsAsync();
        }

        private async Task loadRecords()
        {
            dgv.DataSource = await GetUserManagementsAsync();
            dgv.Columns["AccessLevelId"].Visible = false;
        }

        private async Task<List<AccessLevels>> GetAccessLevelsAsync()
        {
            var accessLevels = await _context.AccessLevels.ToListAsync();
            return accessLevels;
        }

        private async Task<List<UserManagementDTO>> GetUserManagementsAsync()
        {
            var users = await _context.Users
                .Include(a => a.AccessLevel)
                .ToListAsync();
            return users.Select(x => new UserManagementDTO
            {
                Name = x.Name,
                Username = x.Username,
                Password = "Prohibited",
                AccessLevel = x.AccessLevel.Name
            }).ToList();
        }
    }
}
