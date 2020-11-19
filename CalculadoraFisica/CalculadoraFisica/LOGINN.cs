using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CalculadoraFisica
{
    public partial class LOGINN : Form
    {
        string contra;
        public LOGINN()
        {
            InitializeComponent();
        }

        private void LOGINN_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsu.Text,
                   contraseña = textBoxContra.Text,
                   url = "C:\\Loginv1\\" + usuario + ".txt";

            trabajo();

            void trabajo()
            {
                
                if (textBoxContra.Text.Length == 0 || textBoxUsu.Text.Length == 0)
                {
                    MessageBox.Show("Porfavor digite usario y contraseña correcta");
                    borrar();
                }
                else
                {
                    
                    if (File.Exists(url))
                    {
                        MessageBox.Show("El usuario ya existe, por favor inicie seción");
                        borrar();
                    }
                    else
                    {
                        File.WriteAllText(url, contraseña);
                        MessageBox.Show("Usuario registrado, inicie seccion");
                        borrar();
                    }
                }
                void borrar()
                {
                    textBoxContra.Clear();
                    textBoxUsu.Clear();
                    textBoxUsu.Focus();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Inicio ventana2 = new Inicio();
            string usuario = textBoxUsu.Text,
                   contraseña = textBoxContra.Text;
            
            string url = "C:\\Loginv1\\" + usuario + ".txt";

            if (File.Exists(url))
            {
                contra = File.ReadAllText(url);
                if (contraseña.Equals(contra))
                {
                   
                    borrar();
                    this.Hide();
                    ventana2.Show();
                }
                else
                {
                    MessageBox.Show("Constraseña incorrecta intente de nuevo");
                    borrar();
                }
            }
            else
            {
                
                MessageBox.Show("Usuario incorrecto");
                borrar();
            }
            void borrar()
            {
                textBoxContra.Clear();
                textBoxUsu.Clear();
                textBoxUsu.Focus();

            }
        }
    }
    }

