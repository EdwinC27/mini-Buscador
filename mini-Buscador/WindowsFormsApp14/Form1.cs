using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ir_Click(object sender, EventArgs e)
        {
            // Te manda a la URL que este en el textBox
            webBrowser1.Navigate(textURL.Text);
        }

        private void atrasar_Click(object sender, EventArgs e)
        {
            // Te manda a la pagina anterior 
¿            webBrowser1.GoBack();
        }

        private void adelantar_Click(object sender, EventArgs e)
        {
            // Te manda a la sigiente pagina  
            webBrowser1.GoForward();
        }

        private void parar_Click(object sender, EventArgs e)
        {
            // Te para de cargar la pagina
            webBrowser1.Stop();
        }

        private void paginaPrincipal_Click(object sender, EventArgs e)
        {
            // Te manda a la pagina principal de edge
            webBrowser1.GoHome();
        }

        private void recargar_Click(object sender, EventArgs e)
        {
            // Te refresca la pagina 
            webBrowser1.Refresh();
        }
    }
}
