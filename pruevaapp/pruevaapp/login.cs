using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruevaapp
{
    public partial class login : Form
    {
        validacion v = new validacion();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La pantalla se esta cerrando");
            this.Close();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informacion informacion = new Informacion();
            informacion.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void bntregistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            registro registro = new registro();
            registro.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Contraseña_Olvidada Contraseña = new Contraseña_Olvidada();
            Contraseña.ShowDialog();
        }
    }
}
