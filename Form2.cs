using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final_POO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_regresar_a_inicio_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string user = input_usuario_login.Text;
            string pass = input_password_login.Text;
            bool loginValido = false;

            for (int i = 0; i < Program.contadorUsuarios; i++)
            {
                if (Program.usuarios[i] == user && Program.passwords[i] == pass)
                {
                    Program.usuarioActivo = Program.usuarios[i];
                    Program.nombreActivo = Program.nombres[i];
                    Program.rolActivo = Program.roles[i];
                    loginValido = true;
                }
            }

            if (loginValido)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
