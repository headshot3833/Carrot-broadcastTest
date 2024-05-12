using Carrot_broadcast.DAL.AplicationDbContext;
using Carrot_broadcast.Domain.Entity;
using Carrot_broadcast.Parser.GetByAPI;
using Carrot_broadcast.Parser.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Metrics;
using Timer = System.Threading.Timer;


namespace Carrot_broadcastTest
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly GetByApi _api;
        public Form1()
        {

            InitializeComponent();
            _dbContext = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            _api = new GetByApi();
            var users = _dbContext.Set<User>().ToList();
            var observableUsers = new ObservableCollection<User>(users);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = observableUsers;
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void GetDataApi_Click(object sender, EventArgs e)
        {
            List<ModelResult> dataList = new List<ModelResult>();
            try
            {

                dataList = await _api.GetDataAsync();

                CountryBox.Clear();
                StateBox.Clear();
                FirstNameBox.Clear();
                LastNameBox.Clear();
                CityBox.Clear();
                MailBox.Clear();

                foreach (var item in dataList)
                {
                    CountryBox.AppendText($"{item.Location.Country}");
                    FirstNameBox.AppendText($"{item.Name.First}");
                    LastNameBox.AppendText($"{item.Name.Last}");
                    MailBox.AppendText($"{item.Email}");
                    StateBox.AppendText($"{item.Location.State}");
                    CityBox.AppendText($"{item.Location.City}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных из API: " + ex.Message);
            }
        }

        private async void DeleteFromDb_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var IdFromDataGrid = selectedRow.Cells[0].Value;
            var userToRemove = _dbContext.Set<User>().FirstOrDefault(x => x.Id == (int)IdFromDataGrid);

            if (userToRemove != null)
            {
                _dbContext.Set<User>().Remove(userToRemove);
                _dbContext.SaveChanges();
            }
            var users = _dbContext.Set<User>().ToList();
            var observableUsers = new ObservableCollection<User>(users);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = observableUsers;
            dataGridView1.DataSource = bindingSource;
        }

        private void SaveDb_Click(object sender, EventArgs e)
        {

            try
            {
                var data = new User
                {
                    First = FirstNameBox.Text,
                    Last = LastNameBox.Text,
                    City = CityBox.Text,
                    Country = CountryBox.Text,
                    State = StateBox.Text,
                    Email = MailBox.Text,
                    Time = DateTime.Now.Date,
                };
                if (FirstNameBox.Text != string.Empty)
                {
                    _dbContext.Add(data);
                    _dbContext.SaveChanges();
                    var users = _dbContext.Set<User>().ToList();
                    var observableUsers = new ObservableCollection<User>(users);
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = observableUsers;
                    dataGridView1.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("нажмите получить данные перед сохранением");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранении " + ex.Message);
            }

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (CheckFilterDate.Checked)
            {
                try
                {

                    if (!DateTime.TryParse(FilterBox.Text, out DateTime filterDate))
                    {
                        MessageBox.Show("Неверный формат даты и времени.");
                        return;
                    }

                    var users = _dbContext.Set<User>().Where(x => x.Time == filterDate).ToList();
                    dataGridView1.DataSource = users;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при поиске пользователя: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Фильтр даты не установлен.");
            }
            if (CheckFilterName.Checked)
            {

                    var filterName = FilterBox.Text;

                    var users = _dbContext.Set<User>().Where(x => x.First == filterName).ToList();
                    dataGridView1.DataSource = users;

               
            }
            else
            {
                MessageBox.Show("фильтр имени не установлен");
            }
        }

        private void UpdateDbData_Click(object sender, EventArgs e)
        {
            var users = _dbContext.Set<User>().ToList();
            var observableUsers = new ObservableCollection<User>(users);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = observableUsers;
            dataGridView1.DataSource = bindingSource;
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var IdFromDataGrid = selectedRow.Cells[0].Value;
            var User = _dbContext.Set<User>().FirstOrDefault(x => x.Id == (int)IdFromDataGrid);

            UpdateUserForm userform = new UpdateUserForm(User);

            userform.Text = User.Id.ToString();


            userform.Show();
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
