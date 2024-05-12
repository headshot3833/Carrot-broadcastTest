using Carrot_broadcast.DAL.AplicationDbContext;
using Carrot_broadcast.Domain.Entity;
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

namespace Carrot_broadcastTest
{
    public partial class UpdateUserForm : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private User _user;
        public UpdateUserForm(User User)
        {
            _user = User;
            InitializeComponent();
            _dbContext = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            FirstUpdate.Text = _user.First;
            LastUpdate.Text = _user.Last;
            StateUpdate.Text = _user.State;
            CityUpdate.Text = _user.City;
            MailUpdate.Text = _user.Email;
            CountryUpdate.Text = _user.Country;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            _user.First = FirstUpdate.Text;
            _user.Last = LastUpdate.Text;
            _user.State = StateUpdate.Text;
            _user.City = CityUpdate.Text;
            _user.Email = MailUpdate.Text;
            _user.Country = CountryUpdate.Text;

            _dbContext.SaveChanges();
            this.Close();
        }
    }
}
