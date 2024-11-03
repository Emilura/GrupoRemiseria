using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelos
{
    class Cliente
    {
        private string apellido;
        private string nombre;
        private string telefono;
        private string direccion;
        private string email;
        private bool activo;

        public int IdCliente { get; set; }

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


        public Cliente() { }// es para generar constructor
        public Cliente(string apellido, string nombre, string telefono, string direccion, string email, bool activo)
        {
            this.apellido = apellido;
             this.nombre = nombre;
           this. telefono = telefono;
            this.direccion = direccion;
           this. email = email;
           this. activo = activo;

        }



    }
}



