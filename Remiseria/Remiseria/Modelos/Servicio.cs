using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelos
{
    class Servicio
    {
        private int id_Servicio;
        private int id_Cliente;
        private int id_Vehiculo;
        private int id_chofer;
        private DateTime fecha;
        private DateTime horaInicio;
        private DateTime horaFin;
        private string origen;
        private string destino;
        private float precio;
        private string estado;
        private bool activo;

        public int Id_servicio
        {
            get { return id_Servicio; }
            set { id_Servicio = value; }

        }
        public int Id_cliente
        {
            get => id_Cliente;
            set => id_Cliente = value;
        }
        public int id_vehiculo
        {
            get => id_Vehiculo;
            set => id_Vehiculo = value;
        }
        public int id_Chofer
        {
            get => id_chofer;
            set => id_chofer = value;

        }
        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;

        }
        private DateTime Horainicio
        {
            get => horaInicio;
            set => horaInicio = value;

        }
        private DateTime Horafin
        {
            get => horaFin;
            set => horaFin = value;

        } 
        private string Origen
        {
            get => origen;
            set => origen = value;

        }
        private string Destino
        {
            get => destino;
            set => destino = value;
        }

        private float Precio
        {
            get => precio;
            set => precio = value;
        }
        private string Estado
        {
            get => estado;
            set => estado = value;

        }
        private bool Activo
        {
            get => activo;
            set => activo = value;

        }
        

    }
}
