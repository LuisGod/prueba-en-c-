using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadreDeFamilia
{
    class Program
    {
        static void Main(string[] args)
        {
            PadreFamiliaController personajesControler = new PadreFamiliaController();
            List<PadreFamiliaBE> listaPersonajes = new List<PadreFamiliaBE>();

            Console.Write("Digite el apellido que desea buscar:  ");
            string apellido = Console.ReadLine();

            listaPersonajes = personajesControler.PersonajesPorApellido(apellido);

        }
    }
}
