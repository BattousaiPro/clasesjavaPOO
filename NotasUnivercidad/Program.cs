using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasUnivercidad
{
    internal class Program
    {
        public static List<Ramo> listRamos = new List<Ramo>();

        static void Main(string[] args)
        {

            int cantidadRamos = 0;
            int cantidadNotas = 0;
            
            Console.SetCursorPosition(30, 3);
            Console.WriteLine(" MENU DE OPCIONES ");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine(" 1.- Cuantos Ramos Decea Ingresar  : ");
            cantidadRamos = int.Parse(Console.ReadLine());

            agregarRamos(cantidadRamos);
            ListarRamos();
            aregarNotasPorRamo();
            listarRamosConNotas();

            Console.ReadLine();


            /* int opcion;
             Double opcion1;

              //BufferedReader lector = new BufferedReader(new InputStreamReader(System.in));


            do
             {
                 Console.SetCursorPosition(30, 3);
                 Console.WriteLine(" MENU DE OPCIONES ");
                 Console.SetCursorPosition(20, 6);
                 Console.WriteLine(" 1.- Leer La Informacion De La Carga Estudiante : ");
                 Console.SetCursorPosition(20, 8);
                 Console.WriteLine(" 2.- Matricular  Las Materias Del Estudiante : ");
                 Console.SetCursorPosition(20, 10);
                 Console.WriteLine(" 3.- Eliminar  Las Materias Del Estudiante : ");
                 Console.SetCursorPosition(20, 12);
                 Console.WriteLine(" 4.- Agregar o Modificar Notas Del Estudiante : ");
                 Console.SetCursorPosition(20, 14);
                 Console.WriteLine(" 5.- Calcular El Promedio De Notas : ");
                 Console.SetCursorPosition(20, 16);
                 Console.WriteLine(" 6.- Calcular el promedio general de toda la institucion : ");
                 Console.SetCursorPosition(20, 18);
                 Console.WriteLine(" 7.- Salir T-T");
                 Console.SetCursorPosition(35, 18);
                 Console.Write(" Digite La Opción : ");
                 opcion = int.Parse(Console.ReadLine());
                 opcion1 = Double.Parse(Console.ReadLine());

                 switch (opcion)
                 {

                     case 1: metodos.leerinformacion(); break;
                     case 2: metodos.matricular_materias(); break;
                     case 3: metodos.notas_docente(); break;
                     case 4: metodos.promedio_estudiante(); break;
                     case 5: metodos.promedio_institucion(); break;
                     case 6: metodos.estudiante_nota_baja(); break;

                     case 7: opcion = 7; break;
                     case 8:
                         Console.WriteLine(" 6.- Calcular elcion : {0}" , opcion1);
                         break;

                     default: break;
                 }
                 //Console.Clear();
             } while (opcion != 7);*/
        }

        private static void agregarRamos(int cantidadRamos) {
            // Cargar los namos que se solicitaron.
            for (int i = 0; i < cantidadRamos; i++)
            {
                String inputNomRamo = "";
                Console.WriteLine("Agregue nombr para el ramo : ");
                inputNomRamo = Console.ReadLine();
                Ramo ramo = new Ramo();
                ramo.NombreDeRamo = inputNomRamo;
                listRamos.Add(ramo);
            }
        }

        private static void ListarRamos()
        {
            Console.WriteLine("Ramos:");
            for (int i = 0; i < listRamos.Count; i++)
            {
                Console.WriteLine("[" + (i + 1) + "] -> " + listRamos[i].NombreDeRamo);
            }
        }

        private static void aregarNotasPorRamo()
        {
            int posisionRamo = 0;
            Console.WriteLine("Ingrese el número del ramo para ingrsar Notas.");
            posisionRamo = int.Parse(Console.ReadLine());

            int cantNotasingregar = 0;
            Console.WriteLine("Cuantas nota quiere agregar?");
            cantNotasingregar = int.Parse(Console.ReadLine());


            Console.WriteLine("Notas:");
            for (int i = 0; i < cantNotasingregar; i++)
            {

                Double NotaIn = 0;
                Console.WriteLine("Agregue Nota:[" + (i + 1) + " de " + cantNotasingregar + "]");
                NotaIn = Double.Parse(Console.ReadLine());
                listRamos[posisionRamo - 1].agregarNota(NotaIn);
            }
        }

        private static void listarRamosConNotas()
        {
            Console.WriteLine("Recorrer list:");
            for (int i = 0; i < listRamos.Count; i++)
            {
                //Console.SetCursorPosition(16, 3);
                Console.WriteLine("Nombre del Ramo:[" + (i + 1) + "]" + listRamos[i].NombreDeRamo);
                for (int j = 0; j < listRamos[i].Notas.Count; j++)
                {
                    //Console.SetCursorPosition(26, 3);
                    Console.WriteLine("nota:[" + (i + 1) + "]" + listRamos[i].Notas[j]);
                }
                //Console.SetCursorPosition(16, 3);
                Console.WriteLine("Promedio:" + listRamos[i].Promedio);
            }
        }

    }
}