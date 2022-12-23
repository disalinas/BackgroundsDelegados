using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDelegadosEventos
{
    delegate void ActualizarProgreso(int progreso, int numero);
    delegate bool DetenerProgreso(int numero);

    public class Background
    {
        List<Modelos.Background> backgrounds;

        public Background()
        {
            this.backgrounds = new List<Modelos.Background>();
        }

        public void Ejecutar(ActualizarBarraProgreso actualizarProgreso, FinalizarBarraProgreso finalizarProgreso, int numero)
        {
            Modelos.Background bg = this.backgrounds.Where(item => numero == item.numero).FirstOrDefault();

            if (null != bg && bg.background.IsBusy)
                return;

            bg = new Modelos.Background(numero);
            bg.background.DoWork += new DoWorkEventHandler(this.ObtenerDatos);
            bg.background.ProgressChanged += new ProgressChangedEventHandler(actualizarProgreso);
            bg.background.RunWorkerCompleted += new RunWorkerCompletedEventHandler(finalizarProgreso);
            bg.background.WorkerSupportsCancellation = true;
            bg.background.WorkerReportsProgress = true;
            bg.background.RunWorkerAsync(argument: numero);

            this.backgrounds.Add(bg);
        }

        public void Detener(int numero)
        {
            Modelos.Background bg = this.backgrounds.Where(item => item.numero == numero).FirstOrDefault();
            
            if (null != bg)
                bg.background.CancelAsync();
        }

        public void Eliminar(BackgroundWorker bgw)
        {
            Modelos.Background bg = this.backgrounds.Where(item => bgw == item.background).FirstOrDefault();

            if (null != bg && !bg.background.IsBusy)
            {
                this.backgrounds.Remove(bg);
            }
        }

        private void ObtenerDatos(object sender, DoWorkEventArgs e)
        {
            CargarDatos cargar = new CargarDatos(this.Actualizar, this.DetenerProgreso, (int)e.Argument);
            cargar.Procesar();
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------- DELEGADOS
        //-----------------------------------------------------------------------------------------------------------------------
        public void Actualizar(int progreso, int numero)
        {
            Modelos.Background bg = this.backgrounds.Where(item => numero == item.numero).FirstOrDefault();

            if (null != bg)
                bg.background.ReportProgress(progreso, numero);
        }

        public bool DetenerProgreso(int numero)
        {
            Modelos.Background bg = this.backgrounds.Where(item => numero == item.numero).FirstOrDefault();

            if (null != bg)
            {
                return bg.background.CancellationPending;
            }
            return false;
        }
    }
}
