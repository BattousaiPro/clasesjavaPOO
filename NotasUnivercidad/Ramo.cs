using System;
using System.Collections.Generic;
using System.IO;

namespace NotasUnivercidad
{

    internal class Ramo
    {
        private String nombreDeRamo;
        private List<Double> notas;
        private Double promedio;
        public Ramo()
        {
            this.Notas = new List<Double>();
        }

        public string NombreDeRamo   // property
        {
            get { return nombreDeRamo; }   // get method
            set { nombreDeRamo = value; }  // set method
        }

        public List<Double> Notas   // property
        {
            get { return notas; }   // get method
            set { notas = value; }  // set method
        }

        public Double Promedio   // property
        {
            get { return promedio; }   // get method
            set { promedio = value; }  // set method
        }

        public void agregarNota(Double nota)
        {
            this.Notas.Add(nota);
            calcularPromedio();
        }

        public void actualizarNota(int index, Double nota)
        {
            this.Notas[index] = nota;
            calcularPromedio();
        }

        public void eliminarNota(int index)
        {
            this.Notas.RemoveAt(index);
            calcularPromedio();
        }

        public void calcularPromedio()
        {
            Double prom = 0.0;
            if (notas.Count > 0)
            {
                for (int i = 0; i < this.Notas.Count; i++)
                {
                    prom = prom + notas[i];
                }
                this.Promedio = prom / notas.Count;
            }
        }

        public string[] arreglo()
        {
            string[] arregloRamo = new string[100];
            try
            {
                StreamReader Lectura;  // Se declara la variable lectura de Tipo Lector de archivos
                string cadena; // se declara la variable cadena que contendra los elementos del archivo
                int contador = 1;  // contador de los elementos de la lista
                Lectura = File.OpenText("Ramo.txt");  // lectura del archivo ramos.txt
                cadena = Lectura.ReadLine();  // se lee la primera linea del archivo y se alamacena en la variable cadena
                while (cadena != null)  //  ciclo repetitivo que recorre el archvo mientras su valor sea diferente a nulo
                {
                    Console.WriteLine(cadena + "----- " + (contador));  // se imprime en pantalla cada elemento del archivo
                    arregloRamo[contador] = cadena;
                    cadena = Lectura.ReadLine(); // se lee la siguiente linea del archivo

                    contador++;  // se incrementa la posición de la lectura del archivo
                }
                Lectura.Close();  // se cierra el lector del archivo   
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return arregloRamo;
        }

        public void borrar(string ramo)
        {
            try
            {
                StreamReader Lectura;
                StreamWriter temporal;
                string cadena;
                bool encontrado = false;
                Lectura = File.OpenText("Ramo.txt");
                temporal = File.CreateText("temp.txt");
                cadena = Lectura.ReadLine();
                string respuesta = null;
                while (cadena != null)
                {
                    if (cadena.Equals(ramo))
                    {
                        encontrado = true;
                        Console.WriteLine("Ramo:" + cadena);
                        respuesta = Console.ReadLine().ToUpper();
                        if (!respuesta.Equals("SI"))
                            temporal.WriteLine(cadena);
                    }
                    else
                    {
                        temporal.WriteLine(cadena);
                    }
                    cadena = Lectura.ReadLine();
                }
                if (encontrado == false)
                    Lectura.Close();
                temporal.Close();
                File.Delete("Ramo.txt");
                File.Move("temp.txt", "Ramo.txt");
                Lectura.Close();
                temporal.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}