using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_programación
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Este evento permite procesar el evento clic 
        /// </summary>
        


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var form = new FormularioPaciente();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Este código permite mostrar el caracter ingresado por el usuario 
             
            if (txtContraseña.PasswordChar == (char)0)
                txtContraseña.PasswordChar = '*';
            else
                txtContraseña.PasswordChar = (char)0;
        }
    }
}
