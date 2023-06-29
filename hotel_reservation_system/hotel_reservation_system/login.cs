using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//including the sql data

namespace hotel_reservation_system
{
    public partial class login : Form
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;

        public login()
        {
            //establishing the connection
            server = "localhost";
            username = "root";
            password = "";
            database = "hotel_reservation_system";
            InitializeComponent();
        }
        private bool validate()
        {
            if (usertextbox.Text == string.Empty || passtextbox.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Please fill in all spaces"); //ensuring all fileds are filled
            }
            else
            {
                
                string user = usertextbox.Text;
                string pass = passtextbox.Text;
                string connectionstring = $"SERVER={server};USERNAME={username};PASSWORD={password};DATABASE={database}";
                connection = new MySqlConnection(connectionstring);//creating new connection
                string confirmdetails = $"SELECT * FROM users WHERE username= '{user}' AND password= '{pass}'"; //selecting details of the user that logs in
                MySqlCommand cmd = new MySqlCommand(confirmdetails, connection);
                MySqlDataReader confirm;
                try
                {
                    connection.Open();
                    confirm = cmd.ExecuteReader();
                    if (confirm.Read())
                    {
                        MessageBox.Show("Login Successful");
                        this.Close();
                        
                        dashboard dashboard = new dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }

            }
        }
        //commands for handling other events
        private void usertextbox_TextChanged(object sender, EventArgs e)
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
