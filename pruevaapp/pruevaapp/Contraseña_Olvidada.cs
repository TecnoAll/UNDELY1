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
    public partial class Contraseña_Olvidada : Form
    {
        public Contraseña_Olvidada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La pantalla se esta cerrando");
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}
