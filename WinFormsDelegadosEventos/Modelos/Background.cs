using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDelegadosEventos.Modelos
{
    public class Background
    {
        public int numero { get; set; }
        public BackgroundWorker background { get; set; }

        public Background(int numero)
        {
            this.numero = numero;
            this.background = new BackgroundWorker();
        }
    }
}
