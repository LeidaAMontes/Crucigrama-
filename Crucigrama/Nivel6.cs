using System;
using System.Linq;
using System.Windows.Forms;

namespace Crucigrama
{
    public partial class Nivel6 : Form {

        const string PREGUNTA_1 = "RUNGE-KUTTA";
        const string PREGUNTA_2 = "MODIFICADO";
        const string PREGUNTA_3 = "1/3DESIMPSON";
        const string PREGUNTA_4 = "3/8DESIMPSON";
        const string PREGUNTA_5 = "EULER";
        const string PREGUNTA_6 = "ORDENSUPERIOR";
        const string PREGUNTA_7 = "4TOORDEN";
        const string PREGUNTA_8 = "HACIAATRAS";
        const string PREGUNTA_9 = "HACIAADELANTE";
        const string PREGUNTA_10 = "2DOORDEN";
        const string PREGUNTA_11 = "3ERORDEN";

        private string respuesta1;
        private string respuesta2;
        private string respuesta3;
        private string respuesta4;
        private string respuesta5;
        private string respuesta6;
        private string respuesta7;
        private string respuesta8;
        private string respuesta9;
        private string respuesta10;
        private string respuesta11;

        private DateTime Fecha = DateTime.Now;

        public Nivel6()
        {
            InitializeComponent();
        }

        private void Nivel6_Load(object sender, EventArgs e)
        {
            imgBox.Image = Crucigrama.Properties.Resources.N6_1;
            HabilitarPreguntas(1, true);
            this.timer1.Enabled = true;
            this.Fecha = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tiempo = (DateTime.Now - this.Fecha);
            this.lblTiempo.Text = tiempo.ToString("mm\\:ss");
            if (tiempo.Minutes == 2) { this.timer1.Stop(); MessageBox.Show("¡Se terminó el tiempo!"); this.Close(); }

            ConstructorRespuestas();

            if (respuesta1.ToUpper() == PREGUNTA_1)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_2;
                HabilitarPreguntas(1, false);
                HabilitarPreguntas(2, true);
            }

            if (respuesta2.ToUpper() == PREGUNTA_2)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_3;
                HabilitarPreguntas(2, false);
                HabilitarPreguntas(3, true);
            }

            if (respuesta3.ToUpper() == PREGUNTA_3)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_4;
                HabilitarPreguntas(3, false);
                HabilitarPreguntas(4, true);
            }

            if (respuesta4.ToUpper() == PREGUNTA_4)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_5;
                HabilitarPreguntas(4, false);
                HabilitarPreguntas(5, true);
            }

            if (respuesta5.ToUpper() == PREGUNTA_5)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_6;
                HabilitarPreguntas(5, false);
                HabilitarPreguntas(6, true);
            }

            if (respuesta6.ToUpper() == PREGUNTA_6)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_7;
                HabilitarPreguntas(6, false);
                HabilitarPreguntas(7, true);
            }

            if (respuesta7.ToUpper() == PREGUNTA_7)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_8;
                HabilitarPreguntas(7, false);
                HabilitarPreguntas(8, true);
            }

            if (respuesta8.ToUpper() == PREGUNTA_8)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_9;
                HabilitarPreguntas(8, false);
                HabilitarPreguntas(9, true);
            }

            if (respuesta9.ToUpper() == PREGUNTA_9)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_10;
                HabilitarPreguntas(9, false);
                HabilitarPreguntas(10, true);
            }

            if (respuesta10.ToUpper() == PREGUNTA_10)
            {
                imgBox.Image = Crucigrama.Properties.Resources.N6_11;
                HabilitarPreguntas(10, false);
                HabilitarPreguntas(11, true);
            }

            if (respuesta11.ToUpper() == PREGUNTA_11)
            {
                HabilitarPreguntas(11, false);
                GoToNextLevel();
            }
        }

        private void ConstructorRespuestas()
        {
            this.respuesta1 = res1_1.Text + res1_2.Text + res1_3.Text + res1_4.Text + res1_5.Text +
                res1_6.Text + res1_7.Text + res1_8.Text + res1_9.Text + res1_10.Text + res1_11.Text;

            this.respuesta2 = res2_1.Text + res2_2.Text + res2_3.Text + res2_4.Text + res2_5.Text +
                res2_6.Text + res2_7.Text + res2_8.Text + res2_9.Text + res2_10.Text;

            this.respuesta3 = res3_1.Text + res3_2.Text + res3_3.Text + res3_4.Text + res3_5.Text +
                res3_6.Text + res3_7.Text + res3_8.Text + res3_9.Text + res3_10.Text + res3_11.Text +
                res3_12.Text;

            this.respuesta4 = res4_1.Text + res4_2.Text + res4_3.Text + res4_4.Text + res4_5.Text +
                res4_6.Text + res4_7.Text + res4_8.Text + res4_9.Text + res4_10.Text + res4_11.Text +
                res4_12.Text;

            this.respuesta5 = res5_1.Text + res5_2.Text + res5_3.Text + res5_4.Text + res5_5.Text;

            this.respuesta6 = res6_1.Text + res6_2.Text + res6_3.Text + res6_4.Text + res6_5.Text +
                res6_6.Text + res6_7.Text + res6_8.Text + res6_9.Text + res6_10.Text + res6_11.Text +
                res6_12.Text + res6_13.Text;

            this.respuesta7 = res7_1.Text + res7_2.Text + res7_3.Text + res7_4.Text + res7_5.Text +
                res7_6.Text + res7_7.Text + res7_8.Text;

            this.respuesta8 = res8_1.Text + res8_2.Text + res8_3.Text + res8_4.Text + res8_5.Text +
                res8_6.Text + res8_7.Text + res8_8.Text + res8_9.Text + res8_10.Text;

            this.respuesta9 = res9_1.Text + res9_2.Text + res9_3.Text + res9_4.Text + res9_5.Text +
                res9_6.Text + res9_7.Text + res9_8.Text + res9_9.Text + res9_10.Text + res9_11.Text +
                res9_12.Text + res9_13.Text;

            this.respuesta10 = res10_1.Text + res10_2.Text + res2_10.Text + res7_3.Text + res10_3.Text + res10_4.Text + res4_5.Text + res6_5.Text;

            this.respuesta11 = res3_3.Text + res5_1.Text + res11_1.Text + res2_2.Text + res11_2.Text + res11_3.Text + res1_5.Text + res11_4.Text;
        }

        private void HabilitarPreguntas(int respuesta = 0, bool habilitar = false)
        {
            if (respuesta == 0) return;

            if (respuesta == 1)
            {
                res1_1.Enabled = res1_1.Enabled = res1_2.Enabled = res1_3.Enabled = res1_4.Enabled = res1_5.Enabled =
                res1_6.Enabled = res1_7.Enabled = res1_8.Enabled = res1_9.Enabled = res1_10.Enabled = res1_11.Enabled = habilitar;
            }

            if (respuesta == 2)
            {
                res2_1.Enabled = res2_1.Enabled = res2_2.Enabled = res2_3.Enabled = res2_4.Enabled = res2_5.Enabled =
                res2_6.Enabled = res2_7.Enabled = res2_8.Enabled = res2_9.Enabled = res2_10.Enabled = habilitar;
            }

            if (respuesta == 3)
            {
                res3_1.Enabled = res2_2.Enabled = res3_2.Enabled = res3_3.Enabled = res3_4.Enabled = res3_5.Enabled =
                res3_6.Enabled = res3_7.Enabled = res3_8.Enabled = res3_9.Enabled = res3_10.Enabled = res3_11.Enabled =
                res3_12.Enabled = habilitar;
            }

            if (respuesta == 4)
            {
                res4_1.Enabled = res2_2.Enabled = res4_2.Enabled = res4_3.Enabled = res4_4.Enabled = res4_5.Enabled =
                res4_6.Enabled = res4_7.Enabled = res4_8.Enabled = res4_9.Enabled = res4_10.Enabled = res4_11.Enabled =
                res4_12.Enabled = habilitar;
            }

            if (respuesta == 5)
            {
                res5_1.Enabled = res5_2.Enabled = res5_3.Enabled = res5_4.Enabled = res5_5.Enabled = habilitar;
            }

            if (respuesta == 6)
            {
                res6_1.Enabled = res6_2.Enabled = res6_3.Enabled = res6_4.Enabled = res6_5.Enabled =
                res6_6.Enabled = res6_7.Enabled = res6_8.Enabled = res6_9.Enabled = res6_10.Enabled = res6_11.Enabled =
                res6_12.Enabled = res6_13.Enabled = habilitar;
            }

            if (respuesta == 7)
            {
                res7_1.Enabled = res7_2.Enabled = res7_3.Enabled = res7_4.Enabled = res7_5.Enabled =
                res7_6.Enabled = res7_7.Enabled = res7_8.Enabled = habilitar;
            }

            if (respuesta == 8)
            {
                res8_1.Enabled = res8_2.Enabled = res8_3.Enabled = res8_4.Enabled = res8_5.Enabled =
                res8_6.Enabled = res8_7.Enabled = res8_8.Enabled = res8_9.Enabled = res8_10.Enabled = habilitar;
            }

            if (respuesta == 9)
            {
                res9_1.Enabled = res9_2.Enabled = res9_3.Enabled = res9_4.Enabled = res9_5.Enabled =
                res9_6.Enabled = res9_7.Enabled = res9_8.Enabled = res9_9.Enabled = res9_10.Enabled = res9_11.Enabled =
                res9_12.Enabled = res9_13.Enabled = habilitar;
            }

            if (respuesta == 10)
            {
                res10_1.Enabled = res10_2.Enabled = res10_3.Enabled = res10_4.Enabled = habilitar;
            }

            if (respuesta == 11)
            {
                res11_1.Enabled = res11_2.Enabled = res11_2.Enabled = res11_3.Enabled = res11_4.Enabled = habilitar;
            }
        }

        private void GoToNextLevel()
        {
            this.timer1.Stop();
            Problema6 problema = new Problema6();
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
    }
}
