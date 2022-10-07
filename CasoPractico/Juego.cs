using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico
{
    public class Juego
    {
        private Jugador jugador;
        private Dado dado;
        public Juego()
        {
        }
        public Juego(Jugador jugador, Dado dado)
        {
            this.jugador = jugador;
            this.dado = dado;
        }
        public Dado Dado
        {
            get { return dado; }
            set { dado = value; }
        }
        public Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }
        public bool existeGanador()
        {
            return jugador.termino() == true;
        }
        public int hacerMovimiento()
        {
            int movimiento = dado.lanzar();
            jugador.mover(movimiento);
            return movimiento;
        }
    }
}
