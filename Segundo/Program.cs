using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo
{
    internal class Program
    {

        public static void crearMarcoDeAsteriscos()
        {
            int colum, fil, colum2, fil2;
            for (colum = 1; colum < 23; colum++)
            {
                Console.SetCursorPosition(15, colum);
                Console.Write("*");
            }
            for (colum2 = 1; colum2 < 23; colum2++)
            {
                Console.SetCursorPosition(60, colum2);
                Console.Write("*");
            }
            for (fil = 16; fil < 60; fil++)
            {
                Console.SetCursorPosition(fil, 1);
                Console.Write("*");
            }
            for (fil2 = 16; fil2 < 60; fil2++)
            {
                Console.SetCursorPosition(fil2, 22);
                Console.Write("*");
            }
        }

        public static int menuPrincipal()
        {
            int op = 0;
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("MENU DE OPCIONES");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("1-Cálculo de edad");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("2-Masa Corporal IMC");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("3-Diguito Verificador de la Cédula");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("4-Conversor");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("5-Reemplazador de Letras");
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("6-Salir");
            Console.SetCursorPosition(35, 18);
            Console.Write("Elija Una opción: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            int op = 0;
            string can = "";
            int con = 0;
            while (can != "no")
            {
                do
                {
                    crearMarcoDeAsteriscos();
                    op = menuPrincipal();
                    do
                    {
                        switch (op)
                        {
                            case 1:

                                int dian, mesn, añon, diac, mesac, añoac, diar, mesr, añor;
                                Console.Clear();
                                Console.SetCursorPosition(30, 3);
                                Console.WriteLine("Diguito Verificador de la Cédula");
                                Console.SetCursorPosition(20, 6);
                                Console.Write("Ingrese el día de su nacimiento: ");
                                dian = int.Parse(Console.ReadLine());
                                Console.SetCursorPosition(20, 8);
                                Console.Write("Ingrese el mes en el que nacio: ");
                                mesn = int.Parse(Console.ReadLine());
                                Console.SetCursorPosition(20, 10);
                                Console.Write("Ingrese el año de su nacimiento: ");
                                añon = int.Parse(Console.ReadLine());
                                Console.SetCursorPosition(20, 12);
                                Console.Write("Ingrese el dia actual: ");
                                diac = int.Parse(Console.ReadLine());
                                Console.SetCursorPosition(20, 14);
                                Console.Write("Ingrese el mes actual: ");
                                mesac = int.Parse(Console.ReadLine());
                                Console.SetCursorPosition(20, 16);
                                Console.Write("Ingrese el año actual: ");
                                añoac = int.Parse(Console.ReadLine());
                                //Condicion
                                if (dian != 0)
                                {
                                    diac = diac + 30;
                                    mesac = mesac - 1;
                                }
                                diar = diac - dian;
                                if (mesn != 0)
                                {
                                    mesac = mesac + 12;
                                    añoac = añoac - 1;
                                }
                                mesr = mesac - mesn;
                                añor = añoac - añon;
                                Console.SetCursorPosition(20, 20);
                                Console.Write("Tu edad actual es: {0} años, {1} meses, con {2} días.", añor, mesr, diar);
                                break;
                            case 2:
                                Console.Clear();
                                Double alt, peso, imc;
                                Console.SetCursorPosition(30, 3);
                                Console.Write("Indice de masa corporal (IMC)");
                                Console.SetCursorPosition(20, 6);
                                Console.Write("Ingrese tu estatura (Metros): ");
                                alt = Convert.ToDouble(Console.ReadLine());
                                Console.SetCursorPosition(20, 8);
                                Console.Write("Ingresa tu peso (kg): ");
                                peso = Convert.ToDouble(Console.ReadLine());
                                imc = peso / (alt * alt);
                                Console.SetCursorPosition(20, 14);
                                Console.Write("Su IMC es: {0}", imc);
                                Console.SetCursorPosition(20, 16);
                                if (alt != 0)
                                {
                                    if (imc < 18)
                                    {
                                        Console.Write(" Usted posee un bajo de lo normal, desnutrición");
                                    }
                                    else if (imc >= 18 && imc < 25)
                                    {
                                        Console.Write("Usted posee un peso optimo, esta saludable");
                                    }
                                    else if (imc <= 25 && imc < 27)
                                    {
                                        Console.Write(" Usted posee sobrepeso, advertencia");
                                    }
                                    else if (imc >= 27)
                                    {
                                        Console.Write("Usted posee Obesidad, No esta nada saludable.");
                                    }
                                }
                                break;
                            case 6:
                                if (op == 6)
                                {
                                    return;
                                }
                                break;
                            default:
                                Console.Write(" solo se admiten numeros del 1 al 6, ingrese opcion correcta");
                                break;
                        }
                        con = op;
                        if (con <= 6)
                        {
                            Console.WriteLine("¿De nuevo? si/no: ");
                            can = Console.ReadLine();
                            if (can == "si")
                            {
                                Console.Clear();
                            }
                        }
                    } while (can == "no");

                    con = op;
                    if (con <= 6)
                    {

                        Console.SetCursorPosition(20, 20);
                        Console.Write("¿Desea Continuar con el menu principal? si/no: ");
                        can = Console.ReadLine();
                        if (can == "si")
                        {
                            Console.Clear();
                        }
                    }
                } while (can == "no");
            }
        }
    }
}
