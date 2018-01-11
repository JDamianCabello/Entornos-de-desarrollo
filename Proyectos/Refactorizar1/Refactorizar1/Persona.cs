using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refactorizar1
{
    public class Persona
    {
        private int _id;
        private string _nombre;

        public Boolean Participante(Proyecto p)
        {
            for(int i = 0; i < p.Participantes.Count; i++)
            {
                if(p.Participantes[i]._id == this._id)
                    return true; 
            }
            return false;
        }
    }
}
