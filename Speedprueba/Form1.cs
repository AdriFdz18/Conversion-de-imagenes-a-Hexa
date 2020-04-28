using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace Speedprueba
{
    public partial class Form1 : Form
    {
        public static string hex = string.Empty;
        public static string base64;
        public static byte[] archivo = null;
        public static string ascii;
        public static string ruta;
        public int size = 0;
        public int sizeAux = 0;
        public string[] hexarr = null;
        public string arreglos = string.Empty;
        public string hexas = string.Empty;


        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            CheckForIllegalCrossThreadCalls = false;


        }


        private void CPUSpeed_Click_1(object sender, EventArgs e)
        {
            label7.Text = HardwareInfo.GetCpuSpeedInGHz().ToString();
        }


        private void CPUMkr_Click_1(object sender, EventArgs e)
        {
            label8.Text = HardwareInfo.GetCPUManufacturer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir Archivo 
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            textBox2.Text = open.FileName;

            // registro de Extension 
            //RegistryKey mona1 = Registry.CurrentUser.OpenSubKey("Software", true);
            //mona1.CreateSubKey("Classes");
            //mona1 = mona1.OpenSubKey("Classes", true);
            //mona1.CreateSubKey(".mona");
            //mona1 = mona1.OpenSubKey(".mona", true);
            //mona1.SetValue("", "archivo.mona");
            //mona1.Close();

            ///////////Creacion de Icono/////////////////
            //RegistryKey mona2 = Registry.CurrentUser.OpenSubKey("Software", true);
            //mona2.CreateSubKey("Classes");
            //mona2 = mona2.OpenSubKey("Classes", true);
            //mona2.CreateSubKey("archivo.mona");
            //mona2 = mona2.OpenSubKey("archivo.mona", true);
            //mona2.SetValue("", "Documento de Io-Exchange");
            //mona2.CreateSubKey("DefaultIcon");
            //mona2 = mona2.OpenSubKey("DefaultIcon", true);
            //mona2.SetValue("", Application.StartupPath + "\\Icono\\Mona.ico");
            //mona2.Close();

            ///////////Agregar software para leer tu extension//////////////
            //RegistryKey mona3 = Registry.CurrentUser.OpenSubKey("Software", true);
            //mona3.CreateSubKey("Classes");
            //mona3 = mona3.OpenSubKey("Classes", true);
            //mona3.CreateSubKey("archivo.mona");
            //mona3 = mona3.OpenSubKey("archivo.mona", true);
            //mona3.SetValue("", "Documento de Io-Exchange");
            //mona3.CreateSubKey("shell");
            //mona3 = mona3.OpenSubKey("shell", true);
            //mona3.CreateSubKey("open");
            //mona3 = mona3.OpenSubKey("open", true);
            //mona3.CreateSubKey("command");
            //mona3 = mona3.OpenSubKey("command", true);
            //mona3.SetValue("", "\"" + Application.StartupPath + "\\Speedprueba.exe\" \"%1\"");
            //mona3.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {

            ruta = textBox2.Text;
            archivo = System.IO.File.ReadAllBytes(ruta);
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Elige la vairable size");
            }
            else
            {
                size = Int32.Parse(comboBox1.Text);
                //Archivo a Base64
                base64 = Convert.ToBase64String(archivo);
                //Archivo a Hexa
                hex = BitConverter.ToString(archivo);
                //Quita los separadores 
                hexas = hex.Replace('-', ' ');
                //Hexadecimal en Array de 8 bits en 8 bits 
                //hexarr = hex.Split('-');
                //Division de bits para valores hexadecimales 
                switch (size)
                {
                    case 8:
                        sizeAux = 2;
                        break;
                    case 16:
                        sizeAux = 4;
                        break;
                    case 32:
                        sizeAux = 8;
                        break;
                    case 64:
                        sizeAux = 16;
                        break;
                    case 128:
                        sizeAux = 32;
                        break;
                    case 256:
                        sizeAux = 64;
                        break;
                    case 512:
                        sizeAux = 128;
                        break;
                    default:
                        MessageBox.Show("Error select a size");
                        break;
                }

                
                textBox1.Text = hexas;


                //Imprimir Archivo en hexa

            }
            Application.DoEvents();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Documento de Io-Exchange|*.mona";
            save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop";
            save.FileName = "Data";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, textBox1.Text);
            }
            //if (save.ShowDialog() == DialogResult.OK)
            //{
            //    string url = save.FileName;
            //    StreamWriter fichero = new StreamWriter(url);
            //    fichero.Write(textBox1.Text);
            //    fichero.Close();
            //    MessageBox.Show("La ruta del archivo" + save.FileName);


            //}



        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open= new OpenFileDialog();
            open.Filter = "Documento de Io-Exchange|*.mona";
            open.InitialDirectory = @"C:\Users\AdriFdez18\Desktop";
            open.FileName = "Data";

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = File.ReadAllText(open.FileName);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}





