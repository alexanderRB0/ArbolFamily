using System;
using System.Collections.Generic;

namespace Arbol
{
    internal class Abuelos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public static List<Padres> Padre { get; internal set; } = new List<Padres>();
         
        public static int ObtenerÑetos()
        {
            var totalÑetos = 0;
            foreach (Padres actual in Padre)
            {
                int Tñetos = actual.ObtenerÑetos();
                totalÑetos += Tñetos;
            }
            return totalÑetos;
        }
    }
}
