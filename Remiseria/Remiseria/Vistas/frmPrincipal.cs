﻿using MySql.Data.MySqlClient;
using Remiseria.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baseDatos = new MySqlConnection();

            baseDatos = (new Conexion()).crearConexion();
            baseDatos.Open();
            MessageBox.Show(baseDatos.State.ToString());
            baseDatos.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funciones.logs("prueba","esta es una  prueba de logs" );
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //miss click
        }

        private void menuPrincipal_Click(object sender, EventArgs e)
        {
            //no eliminar, se jode todo
        }

    }
}
