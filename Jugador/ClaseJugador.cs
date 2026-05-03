using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoNS
{
    public class ClaseJugador
    {
        
        private string _nombre;
        private int _vida;
        private double _oro;
        private bool _npc;
        private int _resistencia;

       
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Vida
        {
            get { return _vida; }
            set { _vida = value; }
        }

        public double Oro
        {
            get { return _oro; }
            set { _oro = value; }
        }

        public bool Npc
        {
            get { return _npc; }
            set { _npc = value; }
        }

        public int Resistencia
        {
            get { return _resistencia; }
            set { _resistencia = value; }
        }

        
        public ClaseJugador()
        {
            _nombre = null;
            _vida = 100;
            _oro = 0;
            _npc = false;
            _resistencia = 50;
        }

        
        public ClaseJugador(string nombre)
        {
            if (nombre == null)
            {
                throw new NullReferenceException("El nombre no puede ser null");
            }
            _nombre = nombre;
            _vida = 100;
            _oro = 0;
            _npc = false;
            _resistencia = 50;
        }

       

        public void CambiarNombre(string nuevoNombre)
        {
            if (nuevoNombre == null)
            {
                throw new NullReferenceException("El nombre no puede ser null");
            }
            _nombre = nuevoNombre;
        }

        public void AnyadirOro(int cantidad)
        {
            if (cantidad > 0)
            {
                _oro += cantidad;
            }
        }

        public void QuitarOro(int cantidad)
        {
            if (cantidad > _oro)
            {
                throw new ArgumentOutOfRangeException("cantidad", "No hay suficiente oro disponible");
            }
            _oro -= cantidad;
        }

        public void AsignarNPC()
        {
            _npc = true;
        }

        public void DesasignarNPC()
        {
            _npc = false;
        }

        public void AnyadirResistencia()
        {
            if (_npc)
            {
                throw new Exception("Error de resistencia, este personaje es un npc");
            }
            _resistencia += 10;
        }

        public void QuitarResistencia()
        {
            if (_resistencia <= 0)
            {
                throw new ArgumentOutOfRangeException("resistencia", "La resistencia no puede ser 0 o menor");
            }
            _resistencia -= 10;
        }

        public void QuitarVida(int cantidad)
        {
            if (cantidad > 0)
            {
                _vida -= cantidad;
                if (_vida < 0) _vida = 0;
            }
        }
    }
}
