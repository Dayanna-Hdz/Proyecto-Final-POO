using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final_POO
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void input_lista_libros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.libros.Length; i++)
            {
                input_lista_libros.Items.Add(Program.libros[i]);
            }
            input_lista_libros.SelectedIndex = 0;
        }

        private void btn_buscar_ubicacion_Click(object sender, EventArgs e)
        {
            int indice = input_lista_libros.SelectedIndex;

            Program.libroSeleccionado = Program.libros[indice];
            Program.idSeleccionado = Program.ids[indice];
            Program.pasilloSeleccionado = Program.pasillos[indice];
            Program.seccionSeleccionado = Program.secciones[indice];
            Program.estanteSeleccionado = Program.estantes[indice];

            lbl_info_id.Text = "Título con ID: " + Program.idSeleccionado + " - " + Program.libroSeleccionado;
            lbl_info_pasillo.Text = "Pasillo: " + Program.pasilloSeleccionado;
            lbl_info_seccion.Text = "Sección: " + Program.seccionSeleccionado;
            lbl_info_estante.Text = "Estante: " + Program.estanteSeleccionado;
        }

        private void btn_cerrar_sesion_f4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btn_ir_a_renta_Click(object sender, EventArgs e)
        {
            
        }
    }
}
