using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace hotel_reservation_system
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;


        public Form1()
        {
            server = "localhost";
            username = "root";
            password = "";
            database = "hotel_reservation_system";
            InitializeComponent();
        }

        private bool validate()
        {
            if(usernametextbox.Text == string.Empty || nametextbox.Text == string.Empty || numbertextbox.Text == string.Empty || passtextbox.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Please fill in all spaces");
            }
            else
            {
                string new_name = nametextbox.Text;
                string new_user_name = usernametextbox.Text;
                string new_pass = passtextbox.Text;
                string new_phone = numbertextbox.Text;
                string connectionstring = $"SERVER={server};USERNAME={username};PASSWORD={password};DATABASE={database}";
                connection = new MySqlConnection(connectionstring);
                string register = $" INSERT INTO users (Fullname, Phone_number, Username, id, Password) VALUES (@name, @phone, @user, '', @pass)";
                MySqlCommand cmd = new MySqlCommand(register, connection);
                cmd.Parameters.AddWithValue("@name", new_name);
                cmd.Parameters.AddWithValue("@phone", new_phone);
                cmd.Parameters.AddWithValue("@user", new_user_name);
                cmd.Parameters.AddWithValue("@pass", new_pass);

                try
                {
                    connection.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("You've been registered into the database");
                        this.Hide();
                        dashboard dashboard = new dashboard();
                        dashboard.Show();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Error");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        // command for handling other events
        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
