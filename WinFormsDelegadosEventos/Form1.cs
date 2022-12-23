using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDelegadosEventos
{
    public delegate void ActualizarBarraProgreso(object sender, ProgressChangedEventArgs e);
    public delegate void FinalizarBarraProgreso(Object sender, RunWorkerCompletedEventArgs e);

    public partial class Form1 : Form
    {
        private Background bg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bg = new Background();
        }

        public void FinalizarProgreso(Object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker bgw = (BackgroundWorker)sender;
            this.bg.Eliminar(bgw);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Add("Click!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Ejecutar(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bg.Detener(0);
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            this.Ejecutar(1);
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            this.bg.Detener(1);
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            this.Ejecutar(2);
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            this.bg.Detener(2);
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            this.Ejecutar(3);
        }

        private void btnStop4_Click(object sender, EventArgs e)
        {
            this.bg.Detener(3);
        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            this.Ejecutar(4);
        }

        private void btnStop5_Click(object sender, EventArgs e)
        {
            this.bg.Detener(4);
        }

        private void Ejecutar(int numero)
        {
            this.bg.Ejecutar(this.ActualizarProgreso, this.FinalizarProgreso, numero);
        }

        public void ActualizarProgreso(object sender, ProgressChangedEventArgs e)
        {

            switch ((int)e.UserState)
            {
                case 0:
                    this.progressBar1.Value = e.ProgressPercentage;
                    break;
                case 1:
                    this.progressBar2.Value = e.ProgressPercentage;
                    break;
                case 2:
                    this.progressBar3.Value = e.ProgressPercentage;
                    break;
                case 3:
                    this.progressBar4.Value = e.ProgressPercentage;
                    break;
                case 4:
                    this.progressBar5.Value = e.ProgressPercentage;
                    break;
            }
        }
    }
}
