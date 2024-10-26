using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelos
{
    class Chofer
    {
        private int IdChofer;
        private string apellido;
        private string nombre;
        private string licenciaConducir;
        private bool activo;

        public int idchofer
        {
            get { return IdChofer; }
            set { IdChofer = value; }
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;

        }
        public string LicenciaConducir
        {
            get => licenciaConducir;
            set => licenciaConducir = value;
        }
        public bool Activo
        {
            get => activo;
            set => activo = value;
        }
    }
}
