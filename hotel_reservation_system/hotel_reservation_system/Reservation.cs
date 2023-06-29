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
    public partial class Reservation : Form
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;

        public Reservation()
        {
            server = "localhost";
            username = "root";
            password = "";
            database = "hotel_reservation_system";
            InitializeComponent();
        }

        private bool customervalidate()
        {
            if(nametextbox.Text == string.Empty || phonetextbox.Text == string.Empty || addresstextbox.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
        private bool bookingvalidate()
        {
            if(typecombobox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!customervalidate())
            {
                MessageBox.Show("Please FIll in Customer Detail");
            }
            else if (!bookingvalidate())
            {
                MessageBox.Show("Please fill in booking details");
            }
            else
            {
                string cus_name = nametextbox.Text;
                string cus_phone = phonetextbox.Text;
                string cus_address = addresstextbox.Text;
                string room_type = typecombobox.SelectedItem.ToString();
                DateTime indate = dateinTimePicker.Value;
                DateTime outdate = dateoutTimePicker.Value;
                if (!Nobutton.Checked && !Yesbutton.Checked)
                {
                    MessageBox.Show("Please select if you have pets or not");
                }
                if (Yesbutton.Checked)
                {
                    if(indate >= DateTime.Now && outdate >= indate)
                    {
                        string pet = Yesbutton.Text.ToString();
                        string connectionstring = $"SERVER={server};USERNAME={username};PASSWORD={password};DATABASE={database}";
                        connection = new MySqlConnection(connectionstring);
                        string reserve = $"INSERT INTO reservation (id,name,telephone,address,type,date_in,date_out,pet) VALUES ('',@name,@phone,@address,@type,@date_in,@date_out,@pet)";
                        string delete = $"DELETE * FROM rooms WHERE type={room_type} AND free=Yes";
                        MySqlCommand cmd_del = new MySqlCommand(delete, connection);
                        MySqlCommand cmd = new MySqlCommand(reserve, connection);
                        cmd.Parameters.AddWithValue("@name", cus_name);
                        cmd.Parameters.AddWithValue("@phone", cus_phone);
                        cmd.Parameters.AddWithValue("@address", cus_address);
                        cmd.Parameters.AddWithValue("@type", room_type);
                        cmd.Parameters.AddWithValue("@date_in", indate);
                        cmd.Parameters.AddWithValue("@date_out", outdate);
                        cmd.Parameters.AddWithValue("@pet", pet);

                        try
                        {
                            connection.Open();
                            if (cmd.ExecuteNonQuery() > 0 && cmd_del.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registered successfully");
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
                    else
                    {
                        MessageBox.Show("Invalid check out or check in dates");
                    }
                    
                }
                if (Nobutton.Checked)
                {
                    if (indate >= DateTime.Now && outdate >= indate)
                    {

                        string pet = Yesbutton.Text.ToString();
                        string connectionstring = $"SERVER={server};USERNAME={username};PASSWORD={password};DATABASE={database}";
                        connection = new MySqlConnection(connectionstring);
                        string reserve = $"INSERT INTO reservation (id,name,telephone,address,type,date_in,date_out,pet) VALUES ('',@name,@phone,@address,@type,@date_in,@date_out,@pet)";
                        string delete = $"DELETE * FROM rooms WHERE type={room_type} AND free=Yes";
                        MySqlCommand cmd_del = new MySqlCommand(delete, connection);
                        MySqlCommand cmd = new MySqlCommand(reserve, connection);
                        cmd.Parameters.AddWithValue("@name", cus_name);
                        cmd.Parameters.AddWithValue("@phone", cus_phone);
                        cmd.Parameters.AddWithValue("@address", cus_address);
                        cmd.Parameters.AddWithValue("@type", room_type);
                        cmd.Parameters.AddWithValue("@date_in", indate);
                        cmd.Parameters.AddWithValue("@date_out", outdate);
                        cmd.Parameters.AddWithValue("@pet", pet);

                        try
                        {
                            connection.Open();
                            if (cmd.ExecuteNonQuery() > 0 && cmd_del.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registered successfully");
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
                    else
                    {
                        MessageBox.Show("Invalid check out or check in dates");
                    }
                }

            }
        }

        //commands for handling other events
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateinTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateoutTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
