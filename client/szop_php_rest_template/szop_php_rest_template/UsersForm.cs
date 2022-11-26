using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace szop_php_rest_template
{
    public partial class UsersForm : Form
    {
        // formok konstruktora tetszés szerin változtatható
        public UsersForm(User currentUser, LoginForm loginForm)
        {
            InitializeComponent();
            InitializeUsersDGV();
            this.currentUser = currentUser;
            this.loginForm = loginForm;
            RefreshUsersDGV();
        }
        User currentUser;
        LoginForm loginForm;
        RestClient usersClient = new RestClient("http://localhost/szop-template/users.php");

        void InitializeUsersDGV() // tábla alapértelmezett oszlopainak beállítása
        {
            usersDGV.Columns.Add("id", "Id");
            usersDGV.Columns["id"].Width = 50;
            usersDGV.Columns.Add("name", "Username");
            usersDGV.Columns["name"].Width = 225;
            usersDGV.Columns.Add("pwd", "Password");
            usersDGV.Columns["pwd"].Width = 225;
            //usersDGV.Columns["pwd"].Visible = false; // ha kell oszlopot el is tüntethetek
        }

        void RefreshUsersDGV() // a tábla feltöltését segíti, több helyen kell, ezért 
        {                      // kiszedtem külön metódusba
            RestRequest request = new RestRequest();
            request.AddParameter("current_user_name", currentUser.Username);
            request.AddParameter("current_user_password", currentUser.Password);
            try
            {
                RestResponse response = usersClient.Get(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = usersClient.Deserialize<Response>(response).Data;
                    if (res.Error != 0)
                    {
                        MessageBox.Show(res.Message);
                    }
                    else
                    {
                        usersDGV.Rows.Clear();
                        foreach (User u in res.Users)
                        {
                            usersDGV.Rows.Add(u.Id, u.Username, u.Password);
                        }
                    }
                }
            }
            catch (DeserializationException)
            {
                MessageBox.Show("Deserialization error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close(); // kijelentkezésnél csak bezárjuk az ablakot
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            RefreshUsersDGV();
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            request.AddParameter("current_user_name", currentUser.Username);
            request.AddParameter("current_user_password", currentUser.Password);
            request.AddParameter("new_user_name", usernameTB.Text);
            request.AddParameter("new_user_password", passwordTB.Text);
            try
            {
                RestResponse response = usersClient.Post(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = usersClient.Deserialize<Response>(response).Data;
                    if (res.Error == 0)
                    {
                        RefreshUsersDGV();
                    }
                    MessageBox.Show(res.Message);
                }
            }
            catch (DeserializationException)
            {
                MessageBox.Show("Deserialization error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            // put és delete műveleteknél így kell külön paramétereket adni
            request.AddBody(new
            {
                current_user_name = currentUser.Username,
                current_user_password = currentUser.Password,
                id = int.Parse(idTB.Text),
                new_user_name = usernameTB.Text,
                new_user_password = passwordTB.Text,
            });
            try
            {
                RestResponse response = usersClient.Put(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = usersClient.Deserialize<Response>(response).Data;
                    if (res.Error == 0)
                    {
                        RefreshUsersDGV();
                    }
                    MessageBox.Show(res.Message);
                }
            }
            catch (DeserializationException)
            {
                MessageBox.Show("Deserialization error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            request.AddBody(new
            {
                current_user_name = currentUser.Username,
                current_user_password = currentUser.Password,
                id = int.Parse(idTB.Text),
            });
            try
            {
                RestResponse response = usersClient.Delete(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = usersClient.Deserialize<Response>(response).Data;
                    if (res.Error == 0)
                    {
                        RefreshUsersDGV();
                    }
                    MessageBox.Show(res.Message);
                }
            }
            catch (DeserializationException)
            {
                MessageBox.Show("Deserialization error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ha bezáródik az ablakunk (logout vagy bezárás), akkor a loginFormot jelenítsük meg
            loginForm.Show();
        }

        private void usersDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // a táblázatban való kiválasztás
                idTB.Text = usersDGV.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                usernameTB.Text = usersDGV.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
                passwordTB.Text = "";
            }
            catch (Exception)
            { }
        }
    }
}
