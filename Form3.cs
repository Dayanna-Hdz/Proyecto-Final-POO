using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final_POO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            input_rol_usuario.Items.Add("Estudiante");
            input_rol_usuario.Items.Add("Maestro");
            input_rol_usuario.SelectedIndex = 0;
        }

        private void btn_regresar_a_inicio_reg_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btn_registrar_cuenta_Click(object sender, EventArgs e)
        {
            if (input_nombre_completo.Text == "" || input_nuevo_usuario.Text == "" || input_nueva_password.Text == "" || input_rol_usuario.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
            }
            else
            {
                int pos = Program.contadorUsuarios;
                Program.nombres[pos] = input_nombre_completo.Text;
                Program.usuarios[pos] = input_nuevo_usuario.Text;
                Program.passwords[pos] = input_nueva_password.Text;
                Program.roles[pos] = input_rol_usuario.SelectedItem.ToString();
                Program.contadorUsuarios++;

                MessageBox.Show("Usuario registrado con éxito. Inicie sesión.");

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
    }
}
