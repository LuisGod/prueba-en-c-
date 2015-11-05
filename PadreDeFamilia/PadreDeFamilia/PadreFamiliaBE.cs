using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadreDeFamilia
{
    public class PadreFamiliaBE
    {
        private int personajeID;
        private string nombre;
        private string apellido;
        private string descripcion;

        public int PersonajeID
        {
            get { return personajeID; }
            set { personajeID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
