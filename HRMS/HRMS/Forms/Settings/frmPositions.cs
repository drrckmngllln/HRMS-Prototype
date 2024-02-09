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
    public partial class frmPositions : Form
    {
        StoreContext _context = new StoreContext();
        public frmPositions()
        {
            InitializeComponent();
        }

        private async void frmPositions_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            dgv.DataSource = await GetPositionsAsync();
            dgv.Columns["Id"].Visible = false;
        }

        private async Task<List<Position>> GetPositionsAsync()
        {
            var positions = _context.Positions.ToListAsync();
            return await positions;
        }
    }
}
