using System;
using System.Collections.Generic;

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
    }
}