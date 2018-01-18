using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refactorizar1
{
    public class Proyecto
    {
        #region Campos

        private string _nombre;
        private long _coste = 0;
        private List<Persona> _participantes = new List<Persona>();

        #endregion

        #region Propiedades

        public List<Persona> Participantes
        {
            get { return _participantes; }
            set { _participantes = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public long Coste
        {
            get { return _coste; }
            set
            {
                if(_coste != value)
                    _coste = value;
            }
        }

        #endregion

        #region Constructores

        public Proyecto(string elNombre, long elCoste)
        {
            this.Nombre = elNombre;
            this.Coste = elCoste;
        }

        #endregion

        #region Métodos

        public bool AgregarParticipante(Persona elFulano)
        {
            if(Participantes.Contains(elFulano))
                return false;
            else
            {
                Participantes.Add(elFulano);
                return true;
            }
        }

        public override string ToString()
        {
            string resultado = "Proyecto: " + Nombre + "Coste: " + Coste + "Participantes: ";

            for(int i = 0; i < Participantes.Count; i++)
            {
                resultado += "\n";
                resultado += Participantes[i].Id;
                resultado += Participantes[i].Nombre;
            }

            return resultado;
        }

        #endregion
    }
}
