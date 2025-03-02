using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonlendirmeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnCar.Location = new Point(btnCar.Location.X, btnCar.Location.Y-5);
            btnCar.BackColor = Color.Green;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnCar.Location = new Point(btnCar.Location.X, btnCar.Location.Y + 5);
            btnCar.BackColor= Color.Red;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnCar.Location = new Point(btnCar.Location.X + 5, btnCar.Location.Y);
            btnCar.BackColor= Color.Blue;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnCar.Location = new Point(btnCar.Location.X - 5, btnCar.Location.Y);
            btnCar.BackColor=Color.Yellow;
        }
    }
}
