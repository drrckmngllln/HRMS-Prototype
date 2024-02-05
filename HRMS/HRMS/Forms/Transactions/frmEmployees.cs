using HRMS.DTO;
using HRMS.Entities;
using HRMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Text.Json.Serialization;

namespace HRMS
{
    public partial class frmEmployees : Form
    {
        private StoreContext _context = new StoreContext();
        public frmEmployees()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadRecords();
        }

        private async Task<List<EmployeeDTO>> GetEmployeesAsync()
        {
            var employees = await _context.Employees
                .Include(x => x.Department)
                .Include(p => p.Position)
                .ToListAsync();
            return employees.Select(x => new EmployeeDTO
            {
                EmployeeNumber = x.EmployeeNumber,
                LastName = x.LastName,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                Position = x.Position.Name,
                Department = x.Department.Name,
                ContractStart = x.ContractStart,
                ContractExpiration = x.ContractExpiration,
                Status = x.Status
            }).ToList();
        }

        private async Task LoadRecords()
        {
            dgv.DataSource = await GetEmployeesAsync();
        }
    }
}
