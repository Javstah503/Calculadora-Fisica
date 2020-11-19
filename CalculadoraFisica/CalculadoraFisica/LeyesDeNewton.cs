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
    public partial class LeyesDeNewton : Form
    {
        public LeyesDeNewton()
        {
            InitializeComponent();
        }

        private void LeyesDeNewton_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNewton.SelectedIndex == 0)
            {
                groupNewton.Show();
                groupSabiasQue.Show();
                comboBoxMovRec.Hide();
                //
                SabiasQueCentripeta.Show();
                labelMovimientoRec.Hide();
                //
                textBoxN1.Show();
                textBoxN2.Show();
                textBoxN3.Show();
                textBoxN4.Hide();
                //
                labelMasa.Show();
                labelRadio.Show();
                labelVelocidad.Show();
                labelMovimientoRec.Hide();
                TiempoMovRec.Hide();
                //
                RespuestaN.Show();
                pictureCentripeta.Show();
                pictureMovRec.Hide();
                iconButtonMovRec.Hide();
                BotonCalcularNew.Show();
                //
                labelAceleracion.Hide();
                labelTiempoAce.Hide();
                labelAceleracion.Hide();
            }
            if (comboNewton.SelectedIndex == 1)
            {
                groupNewton.Show();
                groupSabiasQue.Show();
                comboBoxMovRec.Show();
                //
                SabiasQueCentripeta.Hide();
                labelMovimientoRec.Show();
                //
                textBoxN1.Show();
                textBoxN2.Show();
                textBoxN3.Show();
                textBoxN4.Hide();
                //
                labelMasa.Hide();
                labelRadio.Hide();
                labelVelocidad.Show();
                labelMovimientoRec.Show();
                TiempoMovRec.Show();
                labelDistancia.Show();
                labelVelocidadIni.Hide();
                //
                RespuestaN.Show();
                //
                pictureCentripeta.Hide();
                pictureMovRec.Show();
                iconButtonMovRec.Show();
                BotonCalcularNew.Hide();
                //
                labelAceleracion.Hide();
                labelTiempoAce.Hide();
                labelAceleracion.Hide();
                labelDistancia.Hide();
            }
            if (comboNewton.SelectedIndex == 2)
            {
                groupNewton.Show();
                groupSabiasQue.Show();
                comboBoxMovRec.Hide();
                //
                SabiasQueCentripeta.Hide();
                labelMovimientoRec.Show();
                //
                textBoxN1.Show();
                textBoxN2.Show();
                textBoxN3.Show();
                textBoxN4.Show();
                //
                labelMasa.Hide();
                labelRadio.Hide();
                labelVelocidad.Hide();
                labelMovimientoRec.Hide();
                TiempoMovRec.Hide();
                //
                RespuestaN.Show();
                //
                pictureCentripeta.Hide();
                pictureMovRec.Hide();
                iconButtonMovRec.Hide();
                BotonCalcularNew.Show();
                iconButtonMovRec.Hide();
                //
                labelAceleracion.Show();
                labelTiempoAce.Show();
                labelAceleracion.Show();
                labelDistancia.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonCalcularNew_Click(object sender, EventArgs e)
        {
            double Masa = Convert.ToDouble(textBoxN1.Text);
            double Velocidad = Convert.ToDouble(textBoxN2.Text);
            double Radio = Convert.ToDouble(textBoxN3.Text);
            double resultado = Masa*((Velocidad)*(Velocidad)/(Radio));
            RespuestaTotal.Text = resultado.ToString();
            StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
            try
            {
                escribir.WriteLine("------------------------");
                escribir.WriteLine("Fuerza centripeta");
                escribir.WriteLine("Masa=" + Masa + "g");
                escribir.WriteLine("Velocidad=" + Velocidad + "m/s");
                escribir.WriteLine("Radio=" + Radio + "m");
                escribir.WriteLine("Resultado=" + resultado);
            }
            catch
            {
                escribir.WriteLine("Error");
            }
            escribir.Close();
        }

    

        private void iconButtonMovRec_Click(object sender, EventArgs e)
        {
            double respuesta;
            if (comboBoxMovRec.SelectedIndex == 0)
            {
                double Velocidad = Convert.ToDouble(textBoxN2.Text);
                double Tiempo = Convert.ToDouble(textBoxN3.Text);
                respuesta = (Velocidad) * (Tiempo);
                RespuestaTotal.Text = respuesta.ToString();
                StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
                try
                {
                    escribir.WriteLine("------------------------");
                    escribir.WriteLine("Fuerza centripeta");
                    escribir.WriteLine("Tiempo=" + Tiempo + "s");
                    escribir.WriteLine("Velocidad=" + Velocidad + "m/s");
                    escribir.WriteLine("Resultado=" + respuesta);
                }
                catch
                {
                    escribir.WriteLine("Error");
                }
                escribir.Close();
            }

            if (comboBoxMovRec.SelectedIndex == 1)
            {
                double Distancia = Convert.ToDouble(textBoxN1.Text);
                double Tiempo = Convert.ToDouble(textBoxN3.Text);
                respuesta = (Distancia) / (Tiempo);
                RespuestaTotal.Text = respuesta.ToString();
                StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
                try
                {
                    escribir.WriteLine("------------------------");
                    escribir.WriteLine("Fuerza centripeta");
                    escribir.WriteLine("Tiempo=" + Tiempo + "s");
                    escribir.WriteLine("Distancia=" + Distancia + "m");
                    escribir.WriteLine("Resultado=" + respuesta);
                }
                catch
                {
                    escribir.WriteLine("Error");
                }
                escribir.Close();
            }

            if (comboBoxMovRec.SelectedIndex == 2)
            {
                double Distancia = Convert.ToDouble(textBoxN1.Text);
                double Velocidad = Convert.ToDouble(textBoxN2.Text);
                respuesta = (Distancia) / (Velocidad);
                RespuestaTotal.Text = respuesta.ToString();
                StreamWriter escribir = new StreamWriter(@"C:\Users\50370\Desktop\Reporte.txt", true);
                try
                {
                    escribir.WriteLine("------------------------");
                    escribir.WriteLine("Fuerza centripeta");
                    escribir.WriteLine("Distancia=" + Distancia + "m");
                    escribir.WriteLine("Velocidad=" + Velocidad + "m/s");
                    escribir.WriteLine("Resultado=" + respuesta);
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
            if (comboBoxMovRec.SelectedIndex == 0)
            {
                textBoxN1.Enabled = false;
                textBoxN2.Enabled = true;
                textBoxN3.Enabled = true;
            }

            if (comboBoxMovRec.SelectedIndex == 1)
            {
                textBoxN1.Enabled = true;
                textBoxN2.Enabled = false;
                textBoxN3.Enabled = true;
            }

            if (comboBoxMovRec.SelectedIndex == 2)
            {
                textBoxN1.Enabled = true;
                textBoxN2.Enabled = true;
                textBoxN3.Enabled = false;
            }
        }

        private void comboBoxAcelerado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAcelerado.SelectedIndex == 0)
            {
                textBoxN1.Enabled = true;
                textBoxN2.Enabled = true;
                textBoxN3.Enabled = true;
                textBoxN4.Enabled = false;
            }

            if (comboBoxAcelerado.SelectedIndex == 1)
            {
                textBoxN1.Enabled = true;
                textBoxN2.Enabled = true;
                textBoxN3.Enabled = false;
                textBoxN4.Enabled = true;
            }

            if (comboBoxAcelerado.SelectedIndex == 2)
            {
                textBoxN1.Enabled = true;
                textBoxN2.Enabled = true;
                textBoxN3.Enabled = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Inicio pantalla1 = new Inicio();
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
