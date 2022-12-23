using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDelegadosEventos
{
    class CargarDatos
    {
        public int numero { get; }
        private ActualizarProgreso ActualizarProgreso;
        private DetenerProgreso DetenerEjecucion;

        public CargarDatos(ActualizarProgreso f1, DetenerProgreso f2, int numero)
        {
            if (null == f1)
                throw new ArgumentNullException("f1");

            if (null == f2)
                throw new ArgumentNullException("f2");

            if (numero < 0)
                throw new ArgumentException("numero");

            this.ActualizarProgreso = f1;
            this.DetenerEjecucion = f2;
            this.numero = numero;

            this.ActualizarProgreso(0, numero);
        }

        public void Procesar()
        {
            for (int i = 0; i < 101; i++)
            {
                if (this.DetenerEjecucion(numero))
                {
                    break;
                }

                this.ActualizarProgreso(i, numero);
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
