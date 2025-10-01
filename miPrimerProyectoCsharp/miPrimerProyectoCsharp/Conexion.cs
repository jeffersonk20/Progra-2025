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
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();//Abrir la cadena de conexion

        }
        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el dataset
            objComando.Connection = objConexion;//Establecer la conexion para ejecutar los comandos

            objAdaptador.SelectCommand = objComando;//Establecer el comando de seleccion
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//tomando  los datos de la tabla alumnos y llenando el dataset



            objComando.CommandText = "SELECT * FROM Materia";
            objAdaptador.Fill(objDs, "Materia");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
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

