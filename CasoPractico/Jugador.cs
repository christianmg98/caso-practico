using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico
{
    public class Jugador
    {
        private string nombre;
        private int posicion;

        public Jugador()
        {
        }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.posicion = 1;
        }

        public Jugador(string nombre, int posicion)
        {
            this.nombre = nombre;
            this.posicion = posicion;
        }

        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value; }
        }

        public int Posicion { 
            get { return posicion; }
            set { posicion = value; }
        }       

        public void mover(int posiciones)
        {
            int aux = this.posicion + posiciones;
            if (aux <= 100)
            {
                this.posicion += posiciones;
            }
        }

        public bool termino()
        {
            return this.posicion == 100;
        }
    }
}
