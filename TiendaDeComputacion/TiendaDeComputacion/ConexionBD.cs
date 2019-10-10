using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TiendaDeComputacion
{
    class ConexionBD
    {
        string cadena = "Data Source=JIME-PC;Initial Catalog=TiendaDeComputacion; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion correcta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD "+ ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close(); 
        }

    }
}
