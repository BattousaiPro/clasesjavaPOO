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
                Console.Clear();
                can = "";
                // Columna Izquierda.
                crearMarcoDeAsteriscosVertical(1, 25, 15);
                // Columna Derecha.
                crearMarcoDeAsteriscosVertical(1, 25, 60);
                // Fila Superior
                crearMarcoDeAsteriscosHorizontal(16, 60, 1);
                // Fila Inferior
                crearMarcoDeAsteriscosHorizontal(16, 60, 24);

                op = menuPrincipal();
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 1: AGREGAR VARIOS DE RAMOS");
                        agregarRamos();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 2: AGREGAR UN RAMO");
                        agregarRamos(1);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 3: MODIFICAR UN RAMO");
                        modificarRamos();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 4: ELIMINAR UN RAMO");
                        eliminarRamos();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 5: LISTAR RAMOS");
                        ListarRamos();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 6: LISTAR RAMOS CON NOTAS");
                        listarRamosConNotas();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 7: AGREGAR NOTAS A UN RAMOS");
                        agregarNotasALosRamos();
                        break;
                    case 8:
                        Console.Clear();
                        return;
                        break;
                    default:
                        Console.Write(" solo se admiten numeros del 1 al 8, ingrese opcion correcta");
                        break;
                }
                if (op <= 6)
                {
                    Console.WriteLine("¿De nuevo? si/no: ");
                    can = Console.ReadLine();
                    if ("si"==can || "SI"==can || "s"==can || "S"==can)
                    {
                        Console.Clear();
                    }
                    else if ("no"==can || "NO"==can || "n"==can || "N"==can)
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            } while (!("no"==can || "NO" == can || "n" == can || "N" == can));

        }

        public static int menuPrincipal()
        {
            int op = 0;
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("MENU DE OPCIONES RAMOS");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("1-AGREGAR VARIOS DE RAMOS");
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
            Console.WriteLine("7-AGREGAR NOTAS A LOS RAMOS");
            Console.SetCursorPosition(20, 20);
            Console.WriteLine("8-Salir");
            Console.SetCursorPosition(35, 22);
            Console.Write("Elija Una opción: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        private static void crearMarcoDeAsteriscosVertical(int intColumna, int finColumnas, int posicionCursor)
        {
            int colum;
            for (colum = intColumna; colum < finColumnas; colum++)
            {
                Console.SetCursorPosition(posicionCursor, colum);
                Console.Write("*");
            }
        }

        private static void crearMarcoDeAsteriscosHorizontal(int intFilas, int finFilas, int posicionCursor)
        {
            int fil;
            for (fil = intFilas; fil < finFilas; fil++)
            {
                Console.SetCursorPosition(fil, posicionCursor);
                Console.Write("*");
            }
        }

        private static void agregarRamos() {
            Console.WriteLine(" 1.- Cuantos Ramos Decea Ingresar  : ");
            int cantidadRamos = int.Parse(Console.ReadLine());
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

        private static void agregarRamos(int cantidadRamos)
        {
            // Cargar los namos que se solicitaron.
            for (int i = 0; i < cantidadRamos; i++)
            {
                String inputNomRamo = "";
                Console.WriteLine("Agregue nombre nuevo para el ramo: ");
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
            int index = 1;
            foreach (Ramo ram in listRamos) {
                Console.WriteLine("");
                Console.WriteLine("Nombre del Ramo [" + index + "]: " + ram.NombreDeRamo);
                if (ram.Notas.Count > 0)
                {
                    for (int j = 0; j < ram.Notas.Count; j++)
                    {
                        Console.WriteLine("      Nota [" + index + "]: " + ram.Notas[j]);
                    }
                    ram.calcularPromedio();
                    Console.WriteLine("   Promedio: " + ram.Promedio);
                }
                else
                {
                    Console.WriteLine("          Ramo no presenta Notas");
                }
                index++;
            }
        }

        // Metodos para la carga de notas
        public static int menuParaNotas()
        {
            int op = 0;
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("MENU DE OPCIONES PARA NOTAS");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("1-AGREGAR VARIAS NOTAS");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("2-AGREGAR UNA NOTA");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("3-MODIFICAR NOTAS");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("4-ELIMINAR UNA NOTA");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("5-LISTAR NOTAS");
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("6-MOSTRAR PROMEDIO");
            Console.SetCursorPosition(20, 18);
            Console.WriteLine("7-Volver al menú de Ramos");
            Console.SetCursorPosition(35, 20);
            Console.Write("Elija Una opción: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        private static void agregarNotasALosRamos() {
            int indexRamo = 0;
            ListarRamos();
            Console.WriteLine("A QUE RAMO LE QUIERE AGREGAR NOTAS: ");
            indexRamo = int.Parse(Console.ReadLine());
            Console.Clear();
            int op = 0;
            string can = "";
            do
            {
                Console.Clear();
                can = "";
                // Columna Izquierda.
                crearMarcoDeAsteriscosVertical(1, 23, 15);
                // Columna Derecha.
                crearMarcoDeAsteriscosVertical(1, 23, 60);
                // Fila Superior
                crearMarcoDeAsteriscosHorizontal(16, 60, 1);
                // Fila Inferior
                crearMarcoDeAsteriscosHorizontal(16, 60, 22);
                op = menuParaNotas();
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 1: AGREGAR VARIAS NOTAS");
                        agregarNotas(indexRamo);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 2: AGREGAR UN RAMO");
                        agregarNotas(indexRamo, 1);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 3: MODIFICAR UN RAMO");
                        modificarNota(indexRamo);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 4: ELIMINAR UN RAMO");
                        eliminarNota(indexRamo);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 5: LISTAR RAMOS");
                        listarNotas(indexRamo);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(" OPCIÓN 6: MOSTRAR PROMEDIO");
                        //ListarNotas(indexRamo);
                        mostrarPromedio(indexRamo);
                        break;
                    case 7:
                        Console.Clear();
                        return;
                        break;
                    default:
                        Console.Write(" solo se admiten numeros del 1 al 7, ingrese opcion correcta");
                        break;
                }
                if (op <= 6)
                {
                    Console.WriteLine("¿volver a los ramos? si/no: ");
                    can = Console.ReadLine();
                    if ("si" == can || "SI" == can || "s" == can || "S" == can)
                    {
                        Console.Clear();
                    }
                    else if ("no" == can || "NO" == can || "n" == can || "N" == can)
                    {
                        return;
                    }
                    else {
                        return;
                    }
                }
            } while (!("no" == can || "NO" == can || "n" == can || "N" == can));
        }

        private static void agregarNotas(int indexNotas)
        {
            Console.WriteLine(" 1.- Cuants Notas Decea Ingresar  : ");
            int cantidadNotas = int.Parse(Console.ReadLine());
            // Cargar los namos que se solicitaron.
            for (int i = 0; i < cantidadNotas; i++)
            {
                Console.WriteLine("Agregue nota [" + (i + 1) + " de " + cantidadNotas + "]:");
                Double inputNota = Double.Parse(Console.ReadLine());
                listRamos[indexNotas - 1].agregarNota(inputNota);
            }
        }

        private static void agregarNotas(int indexNotas, int cantidadNotas)
        {
            // Cargar los namos que se solicitaron.
            for (int i = 0; i < cantidadNotas; i++)
            {
                Console.WriteLine("Agregue nota [" + ( i + 1 ) + " de " + cantidadNotas + "]:");
                Double inputNota = Double.Parse(Console.ReadLine());
                listRamos[indexNotas - 1].agregarNota(inputNota);
            }
        }

        private static void listarNotas(int indexNotas)
        {
            Console.WriteLine("");
            if (listRamos[indexNotas - 1].Notas.Count > 0)
            {
                Console.WriteLine("Notas:");
                for (int i = 0; i < listRamos[indexNotas - 1].Notas.Count; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] -> " + listRamos[indexNotas - 1].Notas[i]);
                }
            }
            else
            {
                Console.WriteLine("No presena Notas");
            }
        }

        private static void eliminarNota(int indexNotas)
        {
            listarNotas(indexNotas);
            int indexNota = 0;
            Console.WriteLine("Que nota quiere eliminar: ");
            indexNota = int.Parse(Console.ReadLine());
            listRamos[indexNotas - 1].Notas.RemoveAt(indexNota - 1);
        }

        private static void modificarNota(int indexNotas)
        {
            listarNotas(indexNotas);
            int indexNota = 0;
            Console.WriteLine("Que nota quiere modificar: ");
            indexNota = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es la nota a modificar: ");
            Double nuevaNota = Double.Parse(Console.ReadLine());

            listRamos[indexNotas - 1].Notas[indexNota - 1] = nuevaNota;
        }

        private static void mostrarPromedio(int indexNotas) {
            Console.WriteLine("El promedio de " + listRamos[indexNotas - 1].NombreDeRamo + " es: ");
            Console.WriteLine("  -----> " + listRamos[indexNotas - 1].Promedio);
        }

        // Fin Metodos para la carga de notas
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