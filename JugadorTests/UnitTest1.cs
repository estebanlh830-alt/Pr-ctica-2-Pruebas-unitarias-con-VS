using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JuegoNS;

namespace JugadorTests
{
    [TestClass]
    public class UnitTest1
    {
        // Test 1: Verificar que al crear un jugador con nombre "Ash", el nombre se asigna correctamente
        [TestMethod]
        public void CrearClaseJugador_ConNombreAsh_AsignaNombreCorrectamente()
        {
            
            string nombreEsperado = "Ash";

            
            ClaseJugador jugador = new ClaseJugador("Ash");

            
            Assert.AreEqual(nombreEsperado, jugador.Nombre, "El nombre no se asignó correctamente");
        }

        // Test 2: Comprobar que al añadir oro, la cantidad se incrementa correctamente
        [TestMethod]
        public void AnyadirOro_IncrementaCantidadCorrectamente()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");
            double oroInicial = jugador.Oro;
            int cantidadAnyadir = 50;
            double oroEsperado = oroInicial + cantidadAnyadir;

            
            jugador.AnyadirOro(cantidadAnyadir);

            
            Assert.AreEqual(oroEsperado, jugador.Oro, 0.001, "El oro no se incrementó correctamente");
        }

        // Test 3: Comprobar que al quitar vida, la cantidad se reduce correctamente
        [TestMethod]
        public void QuitarVida_ReduceCantidadCorrectamente()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");
            int vidaInicial = jugador.Vida;
            int cantidadQuitar = 30;
            int vidaEsperada = vidaInicial - cantidadQuitar;

            
            jugador.QuitarVida(cantidadQuitar);

            
            Assert.AreEqual(vidaEsperada, jugador.Vida, "La vida no se redujo correctamente");
        }

        // Test 4: Verificar que inicialmente el atributo npc es false
        [TestMethod]
        public void NuevoClaseJugador_AtributoNPC_EsFalse()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");

            
            Assert.IsFalse(jugador.Npc, "Inicialmente npc debería ser false");
        }

        // Test 5: Comprobar que al llamar a asignarNPC(), el atributo npc pasa a ser true
        [TestMethod]
        public void AsignarNPC_CambiaNPC_ATrue()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");

            
            jugador.AsignarNPC();

            
            Assert.IsTrue(jugador.Npc, "Al asignar NPC, debería ser true");
        }

        // Test 6: Comprobar que al asignar y luego desasignar NPC, el atributo npc vuelve a ser false
        [TestMethod]
        public void DesasignarNPC_DespuesDeAsignar_VuelveAFalse()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");

            
            jugador.AsignarNPC();
            jugador.DesasignarNPC();

            
            Assert.IsFalse(jugador.Npc, "Después de desasignar NPC, debería ser false");
        }

        // Test 7: Verificar que al intentar quitar más oro del disponible, se lanza una excepción
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuitarOro_CantidadMayorQueDisponible_LanzaExcepcion()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");
            jugador.AnyadirOro(50);
            int cantidadQuitar = 100;

            
            jugador.QuitarOro(cantidadQuitar);
        }

        // Test 8: Verificar que al intentar quitar resistencia cuando no es posible, se lanza una excepción
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuitarResistencia_CuandoResistenciaEsCero_LanzaExcepcion()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");
            
            jugador.QuitarResistencia(); 
            jugador.QuitarResistencia(); 
            jugador.QuitarResistencia(); 
            jugador.QuitarResistencia(); 
            jugador.QuitarResistencia(); 

            
            jugador.QuitarResistencia();
        }

        // Test 9: Verificar que al intentar cambiar el nombre del jugador a null, se lanza una excepción
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CambiarNombre_ANull_LanzaExcepcion()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");

            
            jugador.CambiarNombre(null);
        }

        // Test 10: Verificar que al crear un jugador con nombre null, se lanza una excepción
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CrearClaseJugador_ConNombreNull_LanzaExcepcion()
        {
            
            ClaseJugador jugador = new ClaseJugador(null);
        }

        // Test 11: Verificar que si npc es true y se intenta añadir resistencia lanza una excepción
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AnyadirResistencia_CuandoNPCesTrue_LanzaExcepcion()
        {
            
            ClaseJugador jugador = new ClaseJugador("Ash");
            jugador.AsignarNPC();

            
            jugador.AnyadirResistencia();
        }
    }
}
