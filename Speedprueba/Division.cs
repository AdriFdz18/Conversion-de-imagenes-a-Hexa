using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speedprueba
{
    public partial class Division : Form
    {
        public Division()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textsize.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = int.Parse(comboBox1.Text);
            string aux = size.ToString();
            textBox1.Text = aux;




        }

      
    }
 }

