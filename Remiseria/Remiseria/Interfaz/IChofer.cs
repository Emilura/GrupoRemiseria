using Remiseria.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Interfaz
{
    interface IChofer
    {
        string agregarChofer(Chofer _chofer);
        bool eliminarChofer(int _id);
        string actualizarChofer(Chofer _chofer);

        Chofer buscarporChofer(string _dni);

        DataTable ListasChoferes();

        List<Chofer> listadoXapellido(string _apellido);



    }
}
