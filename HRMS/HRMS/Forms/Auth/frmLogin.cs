using HRMS.Infrastructure;
using Krypton.Toolkit;
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

namespace HRMS.Forms.Auth
{
    public partial class frmLogin : KryptonForm
    {
        private StoreContext _context = new StoreContext();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private async Task GetUsersAsync(string username, string password)
        {
            var user = await _context.Users
                .Include(a => a.AccessLevel)
                .FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                MessageBox.Show("Accepted");
                var frm = new MainForm();
                frm.Text = "Human Resource Management System - Prototype Version 1.0";
                frm.Show();
                this.Hide();
            }
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            await GetUsersAsync(tUsername.Text, tPassword.Text);
        }
    }
}
