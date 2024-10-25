using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelos
{
    class Cliente
    {
        private int idCliente;
        private string apellido;
        private string nombre;
        private string telefono;
        private string direccion;
        private string email;
        private bool activo;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }

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
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Dirreccion
        {
            get => direccion;
            set => direccion = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public bool Acivo
        {
            get => activo;
            set => activo = value;
        }


        public Cliente() { }
        public Cliente(int idCliente, string apellido, string nombre, string telefono, string direccion, string email, bool activo);
        {

        this.idCliente = idCliente;

         }

    }
}
