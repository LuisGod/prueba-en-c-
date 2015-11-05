using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace PadreDeFamilia
{
    public class PadreFamiliaController
    {
        public List<PadreFamiliaBE> PersonajesPorApellido(string apellido) {

            PadreFamiliaBE personajeBE;
            List<PadreFamiliaBE> listaResult = new List<PadreFamiliaBE>();

            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader personajes;

             comando.CommandText = "PersonajesPorApellido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pApellido", apellido);

            conexion.Open();

            personajes = comando.ExecuteReader();
            while (personajes.Read())
            {
                personajeBE = new PadreFamiliaBE();
                
                personajeBE.PersonajeID = int.Parse(personajes["PersonajeID"].ToString());
                personajeBE.Nombre = personajes["Nombre"].ToString();
                personajeBE.Apellido = personajes["Apellido"].ToString();
                personajeBE.Descripcion = personajes["Descripcion"].ToString();

                listaResult.Add(personajeBE);

            }

            conexion.Close();

            return listaResult;

        }


    }
}
