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
    public partial class frmDepartments : Form
    {
        StoreContext _context = new StoreContext();
        public frmDepartments()
        {
            InitializeComponent();
        }

        private async void frmDepartments_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            dgv.DataSource = await GetDepartmentsAsync();
            dgv.Columns["Id"].Visible = false;
        }

        private async Task<List<Department>> GetDepartmentsAsync()
        {
            var departments = _context.Departments.ToListAsync();
            return await departments;
        }
    }
}
