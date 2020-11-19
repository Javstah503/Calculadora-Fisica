using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace CalculadoraFisica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenu1.SelectedIndex == 0)
            {
                groupRelatividad.Show();             //GRUPO DE REALITIVIDAD
                FormulaRelatividad.Show();
                FormulaNewton.Hide();
                groupInfoRelatividad.Show();
                ImagenRelatividad.Show();
                ImagenRelatividad2.Show();
                InfoRelatividad.Show();
                GramosRelatividad.Show();
                Masa.Show();
                VelocidadLuz.Show();
                CalcularRelatividad.Show();
                CalcularNewton.Hide();
                CalcularPitagoras.Hide();
                textBox1.Show();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                
                //GRUPO DE NEWTON
                InfoNewton.Hide();
                ImagenNewton.Hide();
                Masa_1.Hide();
                Masa_2.Hide();
                Radio.Hide();
                Gravedad.Hide();
                KgNewton1.Hide();
                KgNewton2.Hide();
                MetrosNewton.Hide();

                //GRUPO DE PITAGORAS
                LadoA.Hide();
                LadoB.Hide();
                LadoC.Hide();
                InfoPitagoras.Hide();
                ImagenDePitagoras.Hide();
                EnunciadoPitagoras.Hide();
                comboPitagoras.Hide();

                //GRUPO DE DILATACION
                DTVLongiud.Hide();
                DTVVelocidad.Hide();
                InfoDTV.Hide();

                Foto1.Hide();
                pictureBox2.Hide();
                Indicacion1.Hide();
                Indicacion2.Hide();
                panel2.Hide();

            }
            if (cmbMenu1.SelectedIndex == 1)
            {
                groupRelatividad.Show();             //GRUPO DE RELATIVIDAD
                Formula.Show();
                FormulaNewton.Show();
                FormulaRelatividad.Hide();
                groupInfoRelatividad.Show();
                ImagenRelatividad.Hide();
                ImagenRelatividad2.Hide();
                InfoRelatividad.Hide();
                GramosRelatividad.Hide();
                Masa.Hide();
                VelocidadLuz.Hide();
                CalcularRelatividad.Hide();
                CalcularNewton.Show();
                CalcularPitagoras.Hide();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Hide();
                CalcularRelatividad.Hide();
                //GRUPO DE NEWTON
                InfoNewton.Show();
                ImagenNewton.Show();
                Masa_1.Show();
                Masa_2.Show();
                Radio.Show();
                Gravedad.Hide();
                KgNewton1.Show();
                KgNewton2.Show();
                MetrosNewton.Show();
               
                //GRUPO DE PITAGORAS
                LadoA.Hide();
                LadoB.Hide();
                LadoC.Hide();
                InfoPitagoras.Hide();
                ImagenDePitagoras.Hide();
                EnunciadoPitagoras.Hide();
                comboPitagoras.Hide();
                
                //GRUPO DE DILATACION
                DTVLongiud.Hide();
                DTVVelocidad.Hide();
                InfoDTV.Hide();

                Foto1.Hide();
                pictureBox2.Hide();
                Indicacion1.Hide();
                Indicacion2.Hide();
                panel2.Hide();

            }
            if(cmbMenu1.SelectedIndex == 2)
            {
                groupRelatividad.Show();             //GRUPO DE RELATIVIDAD
                Formula.Show();
                FormulaNewton.Hide();
                FormulaRelatividad.Hide();
                groupInfoRelatividad.Show();
                ImagenRelatividad.Hide();
                ImagenRelatividad2.Hide();
                InfoRelatividad.Hide();
                GramosRelatividad.Hide();
                Masa.Hide();
                VelocidadLuz.Hide();
                CalcularRelatividad.Hide();
                CalcularNewton.Hide();
                CalcularPitagoras.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Hide();
                CalcularRelatividad.Hide();
                //GRUPO DE NEWTON
                InfoNewton.Hide();
                ImagenNewton.Hide();
                Masa_1.Hide();
                Masa_2.Hide();
                Radio.Hide();
                Gravedad.Hide();
                KgNewton1.Hide();
                KgNewton2.Hide();
                MetrosNewton.Hide();

                //GRUPO DE PITAGORAS
                LadoA.Show();
                LadoB.Show();
                LadoC.Show();
                InfoPitagoras.Show();
                ImagenDePitagoras.Show();
                EnunciadoPitagoras.Show();
                comboPitagoras.Show();

                //GRUPO DE DILATACION
                DTVLongiud.Hide();
                DTVVelocidad.Hide();
                InfoDTV.Hide();

                Foto1.Hide();
                pictureBox2.Hide();
                Indicacion1.Hide();
                Indicacion2.Hide();
                panel2.Hide();
            }
            if (cmbMenu1.SelectedIndex == 3)
            {
                groupRelatividad.Show();             //GRUPO DE RELATIVIDAD
                Formula.Show();
                FormulaNewton.Hide();
                FormulaRelatividad.Hide();
                groupInfoRelatividad.Show();
                ImagenRelatividad.Hide();
                ImagenRelatividad2.Hide();
                InfoRelatividad.Hide();
                GramosRelatividad.Hide();
                Masa.Hide();
                VelocidadLuz.Hide();
                CalcularRelatividad.Hide();
                CalcularNewton.Hide();
                CalcularPitagoras.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Hide();
                textBox4.Hide();
                CalcularRelatividad.Hide();
                //GRUPO DE NEWTON
                InfoNewton.Hide();
                ImagenNewton.Hide();
                Masa_1.Hide();
                Masa_2.Hide();
                Radio.Hide();
                Gravedad.Hide();
                KgNewton1.Hide();
                KgNewton2.Hide();
                MetrosNewton.Hide();

                //GRUPO DE PITAGORAS
                LadoA.Hide();
                LadoB.Hide();
                LadoC.Hide();
                InfoPitagoras.Hide();
                ImagenDePitagoras.Hide();
                EnunciadoPitagoras.Hide();
                comboPitagoras.Hide();

                //GRUPO DE DILATACION
                DTVLongiud.Show();
                DTVVelocidad.Show();
                InfoDTV.Show();

                Foto1.Hide();
                pictureBox2.Hide();
                Indicacion1.Hide();
                Indicacion2.Hide();
                panel2.Hide();

            }
            if (cmbMenu1.SelectedIndex == 4)
            {
                groupRelatividad.Hide();             //GRUPO DE RELATIVIDAD
                Formula.Hide();
                FormulaNewton.Hide();
                FormulaRelatividad.Hide();
                groupInfoRelatividad.Hide();
                ImagenRelatividad.Hide();
                ImagenRelatividad2.Hide();
                InfoRelatividad.Hide();
                GramosRelatividad.Hide();
                Masa.Hide();
                VelocidadLuz.Hide();
                CalcularRelatividad.Hide();
                CalcularNewton.Hide();
                CalcularPitagoras.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                CalcularRelatividad.Hide();
                //GRUPO DE NEWTON
                InfoNewton.Hide();
                ImagenNewton.Hide();
                Masa_1.Hide();
                Masa_2.Hide();
                Radio.Hide();
                Gravedad.Hide();
                KgNewton1.Hide();
                KgNewton2.Hide();
                MetrosNewton.Hide();

                //GRUPO DE PITAGORAS
                LadoA.Hide();
                LadoB.Hide();
                LadoC.Hide();
                InfoPitagoras.Hide();
                ImagenDePitagoras.Hide();
                EnunciadoPitagoras.Hide();
                comboPitagoras.Hide();

                //GRUPO DE DILATACION
                DTVLongiud.Hide();
                DTVVelocidad.Hide();
                InfoDTV.Hide();

                Foto1.Hide();
                pictureBox2.Hide();
                Indicacion1.Hide();
                Indicacion2.Hide();
                panel2.Hide();
            }

            
        }
       
        private void CalcularEx (Label BotonHigh)
        {
            

        } 
        private void Calcular_Click(object sender, EventArgs e)
        {
            double C = 3e10;
            double PrimerText = Convert.ToDouble(textBox1.Text);
            double resultado = PrimerText*(C*C);
            total.Text = resultado.ToString();
            StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt",true);
            try
            {
                escribir.WriteLine("------------------------");
                escribir.WriteLine("Teoria de Relatividad");
                escribir.WriteLine("Masa=" + PrimerText+"g");
                escribir.WriteLine("Valor=" + resultado);
            }
            catch
            {
                escribir.WriteLine("Error");
            }
            escribir.Close();
        }
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            double g = 6.67e-11;
            double Masa1Text = Convert.ToDouble(textBox1.Text);
            double Masa2Text = Convert.ToDouble(textBox2.Text);
            double RadioText = Convert.ToDouble(textBox3.Text);
            double resultado = g*((Masa1Text * Masa2Text )/ (RadioText * RadioText));
            total.Text = resultado.ToString();
            StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
            try
            {
                escribir.WriteLine("------------------------");
                escribir.WriteLine("Ley de Gravitacion universal de Newton");
                escribir.WriteLine("Masa 1 =" + Masa1Text + "g");
                escribir.WriteLine("Masa 2 =" + Masa2Text + "g");
                escribir.WriteLine("Radio =" + RadioText + "m");
                escribir.WriteLine("Valor=" + resultado);
            }
            catch
            {
                escribir.WriteLine("Error");
            }
            escribir.Close();

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Inicio pantalla1 = new Inicio();
            pantalla1.Show();
            this.Hide();
        }

        private void LadoA_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
     

            
            
            
            
            
            
            groupRelatividad.Hide();             //GRUPO DE RELATIVIDAD
            Formula.Hide();
            FormulaNewton.Hide();
            FormulaRelatividad.Hide();
            groupInfoRelatividad.Hide();
            ImagenRelatividad.Hide();
            ImagenRelatividad2.Hide();
            InfoRelatividad.Hide();
            GramosRelatividad.Hide();
            Masa.Hide();
            VelocidadLuz.Hide();
            CalcularRelatividad.Hide();
            CalcularNewton.Hide();
            CalcularPitagoras.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            CalcularRelatividad.Hide();
            //GRUPO DE NEWTON
            InfoNewton.Hide();
            ImagenNewton.Hide();
            Masa_1.Hide();
            Masa_2.Hide();
            Radio.Hide();
            Gravedad.Hide();
            KgNewton1.Hide();
            KgNewton2.Hide();
            MetrosNewton.Hide();

            //GRUPO DE PITAGORAS
            LadoA.Hide();
            LadoB.Hide();
            LadoC.Hide();
            InfoPitagoras.Hide();
            ImagenDePitagoras.Hide();
            EnunciadoPitagoras.Hide();
            comboPitagoras.Hide();

            //GRUPO DE DILATACION
            DTVLongiud.Hide();
            DTVVelocidad.Hide();
            InfoDTV.Hide();


            Foto1.Show();
            pictureBox2.Show();
            Indicacion1.Show();
            Indicacion2.Show();
          

        }

        private void CalcularPitagoras_Click(object sender, EventArgs e)
        {
     
            
            double respuesta;
            if (comboPitagoras.SelectedIndex == 0)
            {
                double LadoBText = Convert.ToDouble(textBox2.Text);
                double LadoCText = Convert.ToDouble(textBox3.Text);
                respuesta = Math.Pow((LadoCText) * (LadoCText) - (LadoBText) * (LadoBText), 0.5);
                total.Text = respuesta.ToString();
                StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
                try
                {
                    escribir.WriteLine("------------------------");
                    escribir.WriteLine("Pitagoras Lado A");
                    escribir.WriteLine("Lado B=" + LadoBText  + "m");
                    escribir.WriteLine("Lado C=" + LadoCText + "m");
                    escribir.WriteLine("Resultado=" + respuesta + "m");
                }
                catch
                {
                    escribir.WriteLine("Error");
                }
                escribir.Close();
            }
            if (comboPitagoras.SelectedIndex == 1)
            {
                double LadoAText = Convert.ToDouble(textBox1.Text);
                double LadoCText = Convert.ToDouble(textBox3.Text);
                respuesta = Math.Pow((LadoCText) * (LadoCText) - (LadoAText) * (LadoAText), 0.5);
                total.Text = respuesta.ToString();
                StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
                try
                {
                    escribir.WriteLine("------------------------");
                    escribir.WriteLine("Pitagoras Lado B");
                    escribir.WriteLine("Lado A=" + LadoAText + "m");
                    escribir.WriteLine("Lado C=" + LadoCText + "m");
                    escribir.WriteLine("Resultado=" + respuesta + "m");
                }
                catch
                {
                    escribir.WriteLine("Error");
                }
                escribir.Close();
            }
            if (comboPitagoras.SelectedIndex == 2)
            {
                double LadoAText = Convert.ToDouble(textBox1.Text);
                double LadoBText = Convert.ToDouble(textBox2.Text);
                respuesta = Math.Pow((LadoAText)*(LadoAText)+(LadoBText)*(LadoBText),0.5);
                total.Text = respuesta.ToString();
                StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
                try
                {
                    escribir.WriteLine("------------------------");
                    escribir.WriteLine("Pitagoras Lado C");
                    escribir.WriteLine("Lado A=" + LadoAText + "m");
                    escribir.WriteLine("Lado B=" + LadoBText + "m");
                    escribir.WriteLine("Resultado=" + respuesta + "m");
                }
                catch
                {
                    escribir.WriteLine("Error");
                }
                escribir.Close();
            }


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void comboPitagoras_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboPitagoras.SelectedIndex == 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }

            if (comboPitagoras.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }

            if (comboPitagoras.SelectedIndex == 2)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            Reporte pantalla1 = new Reporte();
            pantalla1.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Reporte pantalla1 = new Reporte();
            pantalla1.Show();
            this.Hide();
        }
    }
}
