using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_reservation_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            rooms room = new rooms(); 
            room.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Reservation reserve = new Reservation();
            reserve.Show();
        }
    }
}
