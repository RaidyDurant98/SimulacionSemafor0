using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulaSemaforo
{
    public partial class Simulacion : Form
    {
        int estado = 0;

        public Simulacion()
        {
            InitializeComponent();
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            SemaforopictureBox.Image = Properties.Resources.SemaforoPrendido;
            Stopbutton.Enabled = false;
            ShutDownbutton.Enabled = false;
        }

        private void Semaforotimer_Tick(object sender, EventArgs e)
        {
            switch (estado)
            {
                case 0:
                    SemaforopictureBox.Image = Properties.Resources.SemaforoVerde;
                    Semaforotimer.Interval = 3500;
                    estado = 1;
                    Buttontimer.Start();
                    break;

                case 1:
                    SemaforopictureBox.Image = Properties.Resources.SemaforoAmarillo;
                    Semaforotimer.Interval = 800;
                    estado = 2;
                    break;

                case 2:
                    SemaforopictureBox.Image = Properties.Resources.SemaforoRojo;
                    Semaforotimer.Interval = 3500;

                    if (CarropictureBox.Location.X >= 280)
                    {
                        Buttontimer.Stop();
                    }

                    estado = 0;
                    break;

                default:
                    break;
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Semaforotimer.Start();
            SemaforopictureBox.Image = Properties.Resources.SemaforoVerde;
            Startbutton.Enabled = false;
            Stopbutton.Enabled = true;
            ShutDownbutton.Enabled = true;
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            if (Stopbutton.Text == "Stop")
            {
                Semaforotimer.Stop();
                Stopbutton.Text = "Continue";
            }
            else
            {
                Semaforotimer.Start();
                Stopbutton.Text = "Stop";
            }
        }

        private void ShutDownbutton_Click(object sender, EventArgs e)
        {
            Semaforotimer.Stop();
            SemaforopictureBox.Image = Properties.Resources.SemaforoPrendido;
            Startbutton.Enabled = true;
            Stopbutton.Enabled = false;
            ShutDownbutton.Enabled = false;
        }

        private void Buttontimer_Tick(object sender, EventArgs e)
        {
            CarropictureBox.Location = new Point(CarropictureBox.Location.X + 5, CarropictureBox.Location.Y);
        }
    }
}
