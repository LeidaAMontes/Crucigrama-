using System;
using System.Linq;
using System.Windows.Forms;

namespace Crucigrama
{
    public partial class Nivel3 : Form
    {
        const string PREGUNTA_1 = "RAICESDEPOLINOMIOS";
        const string PREGUNTA_2 = "ELIMINACIONGAUSSIANA";
        const string PREGUNTA_3 = "MONTANTE";
        const string PREGUNTA_4 = "GAUSSJORDAN";
        const string PREGUNTA_5 = "JACOBI";
        const string PREGUNTA_6 = "GAUSSSEIDEL";

        private string respuesta1;
        private string respuesta2;
        private string respuesta3;
        private string respuesta4;
        private string respuesta5;
        private string respuesta6;

        private DateTime Fecha = DateTime.Now;

        public Nivel3()
        {
            InitializeComponent();
            imgBox.Image = Crucigrama.Properties.Resources.N3_1;
            HabilitarPreguntas(1, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tiempo = (DateTime.Now - this.Fecha);
            this.lblTiempo.Text = tiempo.ToString("mm\\:ss");
            if (tiempo.Minutes == 2) { this.timer1.Stop(); MessageBox.Show("¡Se terminó el tiempo!"); this.Close(); }

            ConstructorRespuestas();

            if (respuesta1.ToUpper() == PREGUNTA_1)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N3_2;
                HabilitarPreguntas(1, false);
                HabilitarPreguntas(2, true);
            }

            if (respuesta2.ToUpper() == PREGUNTA_2)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N3_3;
                HabilitarPreguntas(2, false);
                HabilitarPreguntas(3, true);
            }

            if (respuesta3.ToUpper() == PREGUNTA_3)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N3_4;
                HabilitarPreguntas(3, false);
                HabilitarPreguntas(4, true);
            }

            if (respuesta4.ToUpper() == PREGUNTA_4)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N3_5;
                HabilitarPreguntas(4, false);
                HabilitarPreguntas(5, true);
            }

            if (respuesta5.ToUpper() == PREGUNTA_5)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N3_6;
                HabilitarPreguntas(5, false);
                HabilitarPreguntas(6, true);
            }

            if (respuesta6.ToUpper() == PREGUNTA_6)
            {
                HabilitarPreguntas(6, false);
                GoToNextLevel();
            }
        }

        private void ConstructorRespuestas()
        {
            this.respuesta1 = res1_1.Text + res1_2.Text + res1_3.Text + res1_4.Text + res1_5.Text +
                res1_7.Text + res1_8.Text + res1_9.Text + res1_10.Text + res1_11.Text + res1_12.Text +
                res1_13.Text + res1_14.Text + res1_15.Text + res1_16.Text + res1_17.Text +
                res1_18.Text + res1_19.Text;

            this.respuesta2 = res2_1.Text + res2_2.Text + res2_3.Text + res2_4.Text + res2_5.Text +
                res2_6.Text + res1_2.Text + res2_7.Text + res2_8.Text + res2_9.Text + res2_10.Text + 
                res2_11.Text + res2_12.Text + res2_13.Text + res2_14.Text + res2_15.Text + res2_16.Text +
                res2_17.Text + res2_18.Text + res2_19.Text;

            this.respuesta3 = res3_1.Text + res2_9.Text + res3_2.Text + res3_3.Text + res3_4.Text +
                res3_5.Text + res3_6.Text + res3_7.Text;

            this.respuesta4 = res2_11.Text + res4_1.Text + res4_2.Text + res4_3.Text +
                res4_4.Text + res4_5.Text + res4_6.Text + res4_7.Text + res4_8.Text + res4_9.Text +
                res4_10.Text;

            this.respuesta5 = res4_5.Text + res5_1.Text + res5_2.Text + res5_3.Text +
                res5_4.Text + res5_5.Text;

            this.respuesta6 = res6_1.Text + res6_2.Text + res6_3.Text + res6_4.Text + res6_5.Text +
                 res6_6.Text + res6_7.Text + res6_8.Text + res6_9.Text + res6_10.Text + res6_11.Text;
        }

        private void HabilitarPreguntas(int respuesta = 0, bool habilitar = false)
        {
            if (respuesta == 0) return;

            if (respuesta == 1)
            {
                res1_1.Enabled = res1_2.Enabled = res1_3.Enabled = res1_4.Enabled = res1_5.Enabled =
                res1_7.Enabled = res1_8.Enabled = res1_9.Enabled = res1_10.Enabled = res1_11.Enabled = res1_12.Enabled =
                res1_13.Enabled = res1_14.Enabled = res1_14.Enabled = res1_15.Enabled = res1_16.Enabled = res1_17.Enabled =
                res1_18.Enabled = res1_19.Enabled = habilitar;
            }

            if (respuesta == 2)
            {
                res2_1.Enabled = res2_2.Enabled = res2_3.Enabled = res2_4.Enabled = res2_5.Enabled =
                res2_6.Enabled = res2_7.Enabled = res2_8.Enabled = res2_9.Enabled = res2_10.Enabled =
                res2_11.Enabled = res2_12.Enabled = res2_13.Enabled = res2_14.Enabled = res2_15.Enabled = res2_16.Enabled =
                res2_17.Enabled = res2_18.Enabled = res2_19.Enabled = habilitar;
            }

            if (respuesta == 3)
            {
                res3_1.Enabled = res3_2.Enabled = res3_3.Enabled = res3_4.Enabled =
                res3_5.Enabled = res3_6.Enabled = res3_7.Enabled = habilitar;
            }

            if (respuesta == 4)
            {
                res2_11.Enabled = res4_1.Enabled = res4_2.Enabled = res4_3.Enabled =
                res4_4.Enabled = res4_5.Enabled = res4_6.Enabled = res4_7.Enabled = res4_8.Enabled = res4_9.Enabled =
                res4_10.Enabled = habilitar;
            }

            if (respuesta == 5)
            {
                res4_5.Enabled = res5_1.Enabled = res5_2.Enabled = res5_3.Enabled =
                res5_4.Enabled = res5_5.Enabled = habilitar;
            }

            if (respuesta == 6)
            {
                res6_1.Enabled = res6_2.Enabled = res6_3.Enabled = res6_4.Enabled = res6_5.Enabled =
                 res6_6.Enabled = res6_7.Enabled = res6_8.Enabled = res6_9.Enabled = res6_10.Enabled = res6_11.Enabled = habilitar;
            }
        }

        private void GoToNextLevel()
        {
            this.timer1.Stop();
            Problema3 problema = new Problema3();
            problema.ShowDialog();

            var actual = ((IMenu)this.Owner)
                .Niveles
                .FirstOrDefault(x => x.Activo == true);
            actual.Activo = false;
            actual.Jugado = true;

            var nuevo = ((IMenu)this.Owner)
                .Niveles
                .FirstOrDefault(x => x.Activo == false && x.Jugado == false);

            if (nuevo == null) { MessageBox.Show("¡Completaste el juego!"); return; };
            nuevo.Activo = true;
            nuevo.Nivel.ShowDialog(this.Owner);
        }

        private void Nivel3_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.Fecha = DateTime.Now;
        }
    }
}
