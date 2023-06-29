using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //adding the mysql database

namespace hotel_reservation_system
{
    public partial class rooms : Form
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;
        public rooms()
        { 
            //creating the connection
            server = "localhost";
            username = "root";
            password = "";
            database = "hotel_reservation_system";
            InitializeComponent();
        }
        private bool validate() //Validating to ensure all fields are properly filled
        {
            if (telephonetextbox.Text.Trim() == string.Empty || comboBoxType.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e) //The add room button
        {
            if (!validate())
            {
                MessageBox.Show("Please fill in appropriate places");
            }
            else
            {
                string telephone = telephonetextbox.Text;
                string type = comboBoxType.SelectedItem.ToString();

                if (!Yesbutton.Checked && !Nobutton.Checked) //if no radio button is clicked
                {

                    MessageBox.Show("Please select an option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (Yesbutton.Checked) //if the room is free
                {
                    string free = Yesbutton.Text.ToString();
                    string connectionstring = $"SERVER={server};USERNAME={username};PASSWORD={password};DATABASE={database}";
                    connection = new MySqlConnection(connectionstring);
                    string add = $"INSERT INTO rooms (no, type, telephone, free) VALUES ('',@type,@telephone,@free)";
                    MySqlCommand cmd = new MySqlCommand(add, connection);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@telephone", telephone);
                    cmd.Parameters.AddWithValue("@free", free);


                    try
                    {
                        connection.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Room has been added to database");
                            this.Hide();
                            dashboard dashboard = new dashboard();
                            dashboard.Show();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (Nobutton.Checked) //if the room is not free
                {
                    string free = Nobutton.Text.ToString();
                    string connectionstring = $"SERVER={server};USERNAME={username};PASSWORD={password};DATABASE={database}";
                    connection = new MySqlConnection(connectionstring);
                    string newroom = $"INSERT INTO rooms (no, type, telephone, free) VALUES ('',@type,@telephone,@free)";
                    MySqlCommand cmd = new MySqlCommand(newroom, connection);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@telephone", telephone);
                    cmd.Parameters.AddWithValue("@free", free);


                    try
                    {
                        connection.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Room Added successfully");
                            this.Hide();
                            dashboard dashboard = new dashboard();
                            dashboard.Show();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                
            }

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void telephonetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
