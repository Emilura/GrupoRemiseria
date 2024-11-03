using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelos
{
    class Vehiculo
    {
        private int idVehiculo;
        private string patente;
        private string marca;
        private string modelo;
        private string año;
        private string estado;
        private bool activo;


        public int Idvehiculo
        {
            get { return idVehiculo; }
            set { idVehiculo = value; }
        }
        public string Patente
        {
            get => patente;
            set => patente = value;
        }
        public string Marca
        {
            get => marca;
            set => marca = value;

        }
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public string Año
        {
            get => año;
            set => año = value;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public bool Activo
        {
            get => activo;
            set => activo = value;
        }
         public Vehiculo() { }
        public Vehiculo (int idVehiculo, string patente,string marca,string modelo,string año,string estado,bool activo )
        {
            this.idVehiculo = idVehiculo;
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.estado = estado;
            this.activo = activo;
            
        }
    }

}
