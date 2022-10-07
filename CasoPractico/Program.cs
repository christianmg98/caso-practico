using CasoPractico;

class Program
{

    static void Main(string[] args)
    {
        bool fin = false;
        do
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\t\t\tSerpientes y Escaleras\nMenú\n1. Comenzar juego.\n2. Correr pruebas.\n\nIngrese su opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Juego juego = new Juego(new Jugador("Christian"), new Dado());
                        Console.WriteLine("\nInicio del juego\n");
                        Console.WriteLine("Jugador: {0}\tPosición: {1}", juego.Jugador.Nombre, juego.Jugador.Posicion);
                        do
                        {
                            int movimiento = juego.hacerMovimiento();
                            Console.WriteLine("Jugador: {0}\tMovimiento: {1}\tPosición: {2}", juego.Jugador.Nombre, movimiento, juego.Jugador.Posicion);
                        } while(!(juego.existeGanador()));
                        Console.WriteLine("\nFin del juego\n");
                        break;
                    case 2:
                        Dado dado = new Dado();
                        // US 1
                        // UAT1
                        Jugador jugador = new Jugador("Christian");
                        Console.WriteLine("US1\nUAT1\n\nJugador: {0}\tPosición: {1}", jugador.Nombre, jugador.Posicion);
                        // UAT2
                        Jugador jugador1 = new Jugador("Alejandro");
                        Console.WriteLine("\n\nUAT2\n\nJugador: {0}\tPosición: {1}", jugador1.Nombre, jugador1.Posicion);
                        jugador1.mover(3);
                        Console.WriteLine("Jugador: {0}\tPosición: {1}", jugador1.Nombre, jugador1.Posicion);
                        // UAT3
                        Jugador jugador2 = new Jugador("Alexander");
                        Console.WriteLine("\n\nUAT3\n\nJugador: {0}\tPosición: {1}", jugador2.Nombre, jugador2.Posicion);
                        jugador2.mover(3);
                        Console.WriteLine("Jugador: {0}\tPosición: {1}", jugador2.Nombre, jugador2.Posicion);
                        jugador2.mover(4);
                        Console.WriteLine("Jugador: {0}\tPosición: {1}", jugador2.Nombre, jugador2.Posicion);
                        // US 2
                        // UAT1
                        Jugador jugador3 = new Jugador("Christian", 97);
                        Juego juego1 = new Juego(jugador3, dado);
                        Console.WriteLine("\n\nUS2\nUAT1\n\nJugador: {0}\tPosición: {1}", jugador3.Nombre, jugador3.Posicion);
                        jugador3.mover(3);
                        Console.WriteLine("Jugador: {0}\tPosición: {1}", jugador3.Nombre, jugador3.Posicion);
                        Console.WriteLine(juego1.existeGanador() ? jugador3.Nombre + " ganó" : jugador3.Nombre + " no ganó");
                        // UAT2
                        Jugador jugador4 = new Jugador("Alejandro", 97);
                        Juego juego2 = new Juego(jugador4, dado);
                        Console.WriteLine("\n\nUAT2\n\nJugador: {0}\tPosición: {1}", jugador4.Nombre, jugador4.Posicion);
                        jugador3.mover(4);
                        Console.WriteLine("Jugador: {0}\tPosición: {1}", jugador4.Nombre, jugador4.Posicion);
                        Console.WriteLine(juego2.existeGanador() ? jugador4.Nombre + " ganó" : jugador4.Nombre + " no ganó");
                        // US 3
                        // UAT1
                        Console.WriteLine("\n\nUS3\nUAT1\n\nNúmero resultante después de tirar el dado: {0}", dado.lanzar());
                        // UAT2
                        Jugador jugador5 = new Jugador("Christian");
                        Juego juego3 = new Juego(jugador5,dado);
                        Console.WriteLine("\n\nUAT2\n\nJugador: {0}\tPosición: {1}", jugador5.Nombre, jugador5.Posicion);
                        Console.WriteLine("Número resultante después de tirar el dado: {0}", juego3.hacerMovimiento());
                        Console.WriteLine("Jugador: {0}\tPosición: {1}\n\n", jugador5.Nombre, jugador5.Posicion);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            } while (!(opcion == 1 || opcion == 2));
            String opcion1 = "";
            do {
                Console.WriteLine("¿Desea terminar el juego Si = S / No = N?");
                opcion1 = Console.ReadLine();
                if (opcion1.Equals("S") | opcion1.Equals("s"))
                {
                    fin = true;
                }
            } while (!(opcion1.Equals("S") || opcion1.Equals("N") || opcion1.Equals("s") || opcion1.Equals("n")));
        } while (!fin);
        //Console.ReadLine();
    }
}

