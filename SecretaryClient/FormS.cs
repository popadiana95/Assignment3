using Assignment3.Models;
using Assignment3.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SecretaryClient
{
    public partial class FormS : Form
    {
        public HttpClient client;
        public FormS()
        {
            InitializeComponent();
           /* ThreadStart threadDelagate = new ThreadStart(DoctorClient.Program.getNotify());
            Thread secThread = new Thread(threadDelagate);
            secThread.Start();*/
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60050/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public User getUser()
        {
            User user = new User();
            user.idUser = Convert.ToInt32(this.userID_tb.Text);
            user.password = this.password_tb.Text;
            user.tip = this.type_tb.Text;
            return user;
        }
        public void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                User user = dataGridViewUsers.SelectedRows[0].DataBoundItem as User;
                if (user != null)
                {

                    this.userID_tb.Text = user.idUser.ToString();
                    this.password_tb.Text = user.password;
                    this.type_tb.Text = user.tip;

                }
}
        }
        private void view_btn_Click(object sender, EventArgs e)
        {
            PopulateUsers();

        }

        private void PopulateUsers()
        {
            try
            {
                HttpResponseMessage response = client.GetAsync("api/user").Result;
                if (response.IsSuccessStatusCode)
                {
                    var users = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                    dataGridViewUsers.DataSource = users;

                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            User user = this.getUser();
            try
            {

                HttpResponseMessage response = client.PostAsJsonAsync("api/addUser", user).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Insert status: success");
                }
                PopulateUsers();
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            User user = this.getUser();
            try
            {
                HttpResponseMessage response = client.PostAsJsonAsync("api/updateUser", user).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update status: success");
                }
                PopulateUsers();
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            User user = this.getUser();
            try
            {

                HttpResponseMessage response = client.PostAsJsonAsync("api/deleteUser", user).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Delete status: success");
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void FormS_Load(object sender, EventArgs e)
        {
            PopulateUsers();
        }
    }
}
