using System;
using System.Collections.Generic;

namespace Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            var abuelos = new Abuelos
            {
                Nombre = "Robert y Mary Martinez"
                
            };
            Abuelos.Padre.Add(
                new Padres
                {
                    Nombre = "Luis Martinez",
                    Hijo = new List<Hijos>
                    {
                        new Hijos
                        {
                            Nombre = "Karl Martinez",
                            Ñeto = new List<Ñetos>
                            {
                                new Ñetos
                                {
                                    Nombre ="Luis Martinez",
                                    Tñetos = 3
                                },
                                new Ñetos
                                {
                                    Nombre ="Evelyn Martinez",
                                    Tñetos = 2//5500

                                }
                            }
                        },
                        new Hijos
                        {
                            Nombre = "Emily Martinez",
                            Ñeto = new List<Ñetos>
                            {
                                new Ñetos
                                {
                                    Nombre ="Charlie Martinez",
                                    Tñetos = 3
                                },
                                new Ñetos
                                {
                                    Nombre ="David Martinez",
                                    Tñetos = 4//6

                                }
                            }
                        }
                    }
                }
               );
            Abuelos.Padre.Add(
                new Padres
                {
                    Nombre = "Jeremy y Leslie Smith",
                    Hijo = new List<Hijos>
                    {
                        new Hijos
                        {
                            Nombre = "Alisson Smith",
                            Ñeto = new List<Ñetos>
                            {
                                new Ñetos
                                {
                                    Nombre ="Aroon Fergunso",
                                    Tñetos = 1//2
                                },
                                new Ñetos
                                {
                                    Nombre ="Jade Fergunso",
                                    Tñetos = 4//6

                                }
                            }
                        },
                        new Hijos
                        {
                            Nombre = "Tehodoro Smith",
                            Ñeto = new List<Ñetos>
                            {
                                new Ñetos
                                {
                                    Nombre ="Kevin Smith",
                                    Tñetos = 2//4
                                },
                                new Ñetos
                                {
                                    Nombre ="Sasha Smith",
                                    Tñetos = 3//4

                                }
                            }
                        }
                    }
                });
            Console.WriteLine($"El total de ñietos de los abuelos {abuelos.Nombre} es:");
            Console.WriteLine(Abuelos.ObtenerÑetos());
        }
    }
}

