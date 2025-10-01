using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria que me permite usar comando para trabajar con Bases de Datos
using System.Data.SqlClient;

namespace miPrimerProyectoCsharp
{
    internal class enlace
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD.
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en memoria.

        public enlace()
        { //Constructor. inicializador de los atributos
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM Docente";
            objAdaptador.Fill(objDs, "Docente");//Tomando los datos de la BD y llenando el DataSet


            objComando.CommandText = "SELECT * FROM Materia";
            objAdaptador.Fill(objDs, "Materia");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
        public string administrarDatosDocente(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Docente(codigo,nombre,direccion,telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Docente SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idDocente=@idDocente";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM Docente WHERE idDocente=@idDocente";
            }
            return ejecutarSQL(sql, datos);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Materia(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Materia SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM Materia WHERE idMateria='" + datos[0] + "'";
            }
            return ejecutarSQL(sql, datos);
        }

        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
