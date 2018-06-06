using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pruevaapp
{
    public partial class registro : Form
    {
        validacion v = new validacion();
        public registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void btnsitioweb_Click(object sender, EventArgs e)
        {
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textmatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }
    }
}
    