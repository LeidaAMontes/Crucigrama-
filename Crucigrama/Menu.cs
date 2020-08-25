using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Crucigrama
{
    public partial class Menu : Form, IMenu
    {
        public List<FormNivel> Niveles { get; set; } = new List<FormNivel>();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            var existente = Niveles
                .FirstOrDefault(x => x.Activo == true);

            if (existente != null)
            {
                existente.Nivel.ShowDialog(this);
            }
            else
            {
                Niveles.Clear();
                Niveles.Add(new FormNivel() { Nivel = new Nivel1() });
                Niveles.Add(new FormNivel() { Nivel = new Nivel2() });
                Niveles.Add(new FormNivel() { Nivel = new Nivel3() });
                Niveles.Add(new FormNivel() { Nivel = new Nivel4() });
                Niveles.Add(new FormNivel() { Nivel = new Nivel5() });
                Niveles.Add(new FormNivel() { Nivel = new Nivel6() });
                Niveles.Shuffle();

                var form = Niveles
                    .FirstOrDefault(x => x.Jugado == false);
                form.Activo = true;
                form.Nivel.ShowDialog(this);
            }
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            Respuestas form = new Respuestas();
            form.ShowDialog(this);
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            Instrucciones form = new Instrucciones();
            form.ShowDialog(this);
        }
    }
}
