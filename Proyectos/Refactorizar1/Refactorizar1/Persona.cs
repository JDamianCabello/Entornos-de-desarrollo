using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refactorizar1
{
    public class Persona
    {
        #region Campos

        private int _id;
        private string _nombre;

        #endregion

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if(_nombre != value)
                    _nombre = value.ToUpper();
            }
        }

        #endregion

        #region Constructores

        public Persona(int elId, string elNombre)
        {
            this.Id = elId;
            this.Nombre = elNombre;
        }

        #endregion

        #region Métodos

        public bool Participante(Proyecto p)
        {
            for(int i = 0; i < p.Participantes.Count; i++)
            {
                if(p.Participantes[i].Id == this.Id)
                    return true;
            }
            return false;
        }

        #endregion
    }
}
