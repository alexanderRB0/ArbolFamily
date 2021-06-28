using System.Collections.Generic;

namespace Arbol
{
    public class Hijos
    {
        public string Nombre { get; set; }
        public List<Ñetos> Ñeto { get; internal set; } = new List<Ñetos>();

        public int ObtenerÑetos()
        {
            var totalÑetos = 0;
            foreach (Ñetos actual in Ñeto)
            {
                int Tñetos = actual.ObtenerÑetos();
                totalÑetos += Tñetos;
            }
            return totalÑetos;
        }
    }
}