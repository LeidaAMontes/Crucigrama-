using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crucigrama
{
    public static class Util
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public interface IMenu
    {
        List<FormNivel> Niveles { get; set; }
    }

    public class FormNivel
    {
        public bool Activo { get; set; } = false;

        public bool Jugado { get; set; } = false;

        public Form Nivel { get; set; }
    }
}
