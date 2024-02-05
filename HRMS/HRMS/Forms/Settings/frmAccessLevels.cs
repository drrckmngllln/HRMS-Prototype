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
    public partial class frmAccessLevels : Form
    {
        private StoreContext _context = new StoreContext();
        public frmAccessLevels()
        {
            InitializeComponent();
        }

        private async void frmAccessLevels_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            dgv.DataSource = await GetAccessLevels();
        }

        private async Task<List<AccessLevelDTO>> GetAccessLevels()
        {
            var accesslevels = await _context.AccessLevels.ToListAsync();
            return accesslevels.Select(x => new AccessLevelDTO { Name = x.Name }).ToList();
        }
    }
}
