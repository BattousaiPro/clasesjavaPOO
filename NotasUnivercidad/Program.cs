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
            loadInitData();
            int op = 0;
            string can = "";
            do
            {
                int cantidadRamos = 0;
                int cantidadNotas = 0;
                can = "";

                op = menuPrincipal();
                switch (op)
                {
                    case 1:
                        Console.WriteLine(" OPCIÓN 1: AGREGAR CANTIDAD DE RAMOS");
                        Console.WriteLine(" 1.- Cuantos Ramos Decea Ingresar  : ");
                        cantidadRamos = int.Parse(Console.ReadLine());

                        agregarRamos(cantidadRamos);
                        break;
                    case 2:
                        Console.WriteLine(" OPCIÓN 2: AGREGAR UN RAMO");
                        agregarRamos(1);
                        break;
                    case 3:
                        Console.WriteLine(" OPCIÓN 3: MODIFICAR UN RAMO");
                        modificarRamos();
                        break;
                    case 4:
                        Console.WriteLine(" OPCIÓN 4: ELIMINAR UN RAMO");
                        eliminarRamos();
                        break;
                    case 5:
                        Console.WriteLine(" OPCIÓN 5: LISTAR RAMOS");
                        ListarRamos();
                        break;
                    case 6:
                        Console.WriteLine(" OPCIÓN 6: LISTAR RAMOS CON NOTAS");
                        listarRamosConNotas();
                        break;
                    case 7:
                        return;
                        break;
                    default:
                        Console.Write(" solo se admiten numeros del 1 al 5, ingrese opcion correcta");
                        break;
                }
                /*
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
                */
                if (op <= 6)
                {
                    Console.WriteLine("¿De nuevo? si/no: ");
                    can = Console.ReadLine();
                    if ("si"==can || "SI"==can || "s"==can || "S"==can)
                    {
                        Console.Clear();
                    } else if ("no"==can || "NO"==can || "n"==can || "N"==can)
                    {
                        return;
                    }
                }
            } while (!("no"==can || "NO" == can || "n" == can || "N" == can));

            /*
             int opcion;
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

        public static int menuPrincipal()
        {
            int op = 0;
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("MENU DE OPCIONES RAMOS");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("1-AGREGAR CANTIDAD DE RAMOS");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("2-AGREGAR UN RAMO");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("3-MODIFICAR UN RAMO");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("4-ELIMINAR UN RAMO");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("5-LISTAR RAMOS");
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("6-LISTAR RAMOS CON NOTAS");
            Console.SetCursorPosition(20, 18);
            Console.WriteLine("7-Salir");
            Console.SetCursorPosition(35, 20);
            Console.Write("Elija Una opción: ");
            op = int.Parse(Console.ReadLine());
            return op;

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
        private static void eliminarRamos()
        {
            ListarRamos();
            int indexRamo = 0;
            Console.WriteLine("Que ramo quiere eliminar: ");
            indexRamo = int.Parse(Console.ReadLine());
            listRamos.RemoveAt(indexRamo - 1);
        }

        private static void modificarRamos()
        {
            ListarRamos();
            int indexRamo = 0;
            Console.WriteLine("Que ramo quiere modificar: ");
            indexRamo = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el nombre a modificar del rao: ");
            String nuevoNombreRamo = Console.ReadLine();

            listRamos[indexRamo - 1].NombreDeRamo = nuevoNombreRamo;
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
                Console.WriteLine("Nombre del Ramo [" + (i + 1) + "]: " + listRamos[i].NombreDeRamo);
                if (listRamos[i].Notas.Count > 0)
                {
                    for (int j = 0; j < listRamos[i].Notas.Count; j++)
                    {
                        Console.WriteLine("      Nota [" + (i + 1) + "]: " + listRamos[i].Notas[j]);
                    }
                    listRamos[i].calcularPromedio();
                    Console.WriteLine("   Promedio: " + listRamos[i].Promedio);
                }
                else {
                    Console.WriteLine("          Ramo no presenta Notas");
                }
            }
        }

        private static void loadInitData()
        {
            
            Ramo ramo = new Ramo();
            ramo.NombreDeRamo = "Programación .net";
            List<Double> notas = new List<Double>();
            notas.Add(5);
            notas.Add(5.5);
            notas.Add(3.5);
            ramo.Notas = notas;
            listRamos.Add(ramo);
            ramo = new Ramo();
            ramo.NombreDeRamo = "Desarrollo Dde Habilidades Cominicativas";
            listRamos.Add(ramo);
            ramo = new Ramo();
            ramo.NombreDeRamo = "Ética Profecional";
            listRamos.Add(ramo);
            ramo = new Ramo();
            ramo.NombreDeRamo = "Patrones De Diseño";
            listRamos.Add(ramo);
            ramo = new Ramo();
            ramo.NombreDeRamo = "Programación Web";
            listRamos.Add(ramo);
            ramo = new Ramo();
            ramo.NombreDeRamo = "Sistema Operativo";
            listRamos.Add(ramo);
        }
    }
}