namespace CasoPractico.Tests
{
    public class Tests
    {
        [Test]
        public void US1UAT1()
        {
            var jugador = new Jugador("Christian");
            Assert.AreEqual(1, jugador.Posicion);
        }

        [Test]
        public void US1UAT2()
        {
            var jugador = new Jugador("Christian");
            jugador.mover(3);
            Assert.AreEqual(4, jugador.Posicion);
        }

        [Test]
        public void US1UAT3()
        {
            var jugador = new Jugador("Christian");
            jugador.mover(3);
            jugador.mover(4);
            Assert.AreEqual(8, jugador.Posicion);
        }

        [Test]
        public void US2UAT1()
        {
            var jugador = new Jugador("Christian", 97);
            var juego = new Juego(jugador, new Dado());
            jugador.mover(3);
            Assert.AreEqual(100, jugador.Posicion);
            Assert.AreEqual(true, juego.existeGanador());
        }

        [Test]
        public void US2UAT2()
        {
            var jugador = new Jugador("Christian", 97);
            var juego = new Juego(jugador, new Dado());
            jugador.mover(4);
            Assert.AreEqual(97, jugador.Posicion);
            Assert.AreEqual(false, juego.existeGanador());
        }

        [Test]
        public void US3UAT1()
        {
            var dado = new Dado();
            CollectionAssert.Contains(new[] {1,2,3,4,5,6},dado.lanzar());
        }

        [Test]
        public void US3UAT2()
        {
            var juego = new Juego(new Jugador(), new Dado());
            CollectionAssert.Contains(new[] { 1, 2, 3, 4, 5, 6 }, juego.hacerMovimiento());
        }


    }
}