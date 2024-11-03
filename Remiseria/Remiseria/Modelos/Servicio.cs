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
        public Servicio() { }
        public Servicio(int id_Servicio, int id_Cliente, int id_Vehiculo, int id_chofer, DateTime fecha, DateTime horaInicio, DateTime horaFin,
            string origen, string destino, float precio, string estado, bool activo)
     
        {
            this.Id_servicio  = id_Servicio;
            this.id_Cliente = id_Cliente;
            this.id_Vehiculo = id_Vehiculo;
            this.id_chofer = id_chofer;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.Horafin = horaFin;
            this.origen = origen;
            this.destino=destino;
            this.precio = precio;
            this.estado = estado;
            this.activo = activo;



            }



        }

    }

