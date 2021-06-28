using System.Collections.Generic;

namespace Arbol
{
    public class Padres
    {
        public string Nombre { get; set; }
        public List<Hijos> Hijo { get; internal set; } = new List<Hijos>();

        public int ObtenerÑetos()
        {
            //return new Random().Next();
            var totalÑetos = 0;
            foreach (Hijos actual in Hijo)
            {
                int Tñetos = actual.ObtenerÑetos();
                totalÑetos += Tñetos;
            }
            return totalÑetos;
            // alex, termina aqui.

        }
    }
}