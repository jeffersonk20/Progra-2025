using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Libreria que me permite trabajar con bases de datos
using System.Data.SqlClient;//Libreria que me permite usar comandos para trabajar con SQL Server

namespace miPrimerProyectoCsharp
{
    internal class Conexion
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection();//Me permite establecer la conexion con la base de datos
        SqlCommand objComando = new SqlCommand();//Me permite ejecutar comandos SQL en la bd lectura, escritura, actualizacion, eliminacion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter();//Un puente entra la BD Y la aplicacion.
        DataSet objDs = new DataSet();//Reprecentacion de la arquitectura de la BD en memoria.

        public Conexion()//Constructor inicializador de los atributos
        {
            string cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();//Abrir la cadena de conexion

        }
        public DataSet obtenerDatos() { 
            objDs.Clear();//Limpiar el dataset
            objComando.Connection = objConexion;//Establecer la conexion para ejecutar los comandos

            objAdaptador.SelectCommand = objComando;//Establecer el comando de seleccion
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//tomando  los datos de la tabla alumnos y llenando el dataset

            return objDs;
        }
    }
}
