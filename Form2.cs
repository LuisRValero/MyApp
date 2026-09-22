using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string correo)
        {
            InitializeComponent();
            textNombre.Text = nombre;
            textCorreo.Text = correo;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
