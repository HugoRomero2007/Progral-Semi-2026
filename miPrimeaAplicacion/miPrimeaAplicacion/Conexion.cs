using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace miPrimeaAplicacion
{
    public class Conexion
    {
        // Definir miembros, atributos y objetos de ADO.NET
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        // Constructor e inicializador de los miembros de la clase
        public Conexion()
        {
            // Apunta al archivo .mdf configurado
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";

            objConexion.ConnectionString = cadenaConexion;

            // Verificamos que la conexión esté abierta
            if (objConexion.State == ConnectionState.Closed)
            {
                objConexion.Open();
            }
        }

        // Método agregado para que funcione objConexion.crearDs(consulta) en el Login
        public DataSet crearDs(string consulta)
        {
            DataSet dsTemporal = new DataSet();
            try
            {
                SqlCommand comando = new SqlCommand(consulta, objConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsTemporal);
            }
            catch (Exception)
            {
                // Control de excepciones
            }
            return dsTemporal;
        }

        // Método corregido para el mantenimiento de usuarios
        public string mantenimiento_usuarios_usss126226(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                // Orden: usuario [0], clave [1], nombre [2], direccion [3], telefono [4]
                sql = "INSERT INTO usuarios_usss126226 (usuario, clave, nombre, dirección, teléfono) VALUES ('" + datos[0] + "', '" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                // Orden: usuario [0], clave [1], nombre [2], direccion [3], telefono [4], y el ID en [5]
                sql = "UPDATE usuarios_usss126226 SET usuario='" + datos[0] + "', clave='" + datos[1] + "', nombre='" + datos[2] + "', dirección='" + datos[3] + "', teléfono='" + datos[4] + "' WHERE idUsuario=" + datos[5];
            }
            else if (accion == "eliminar")
            {
                // El ID viaja en la posición [5]
                sql = "DELETE FROM usuarios_usss126226 WHERE idUsuario=" + datos[5];
            }
            return ejecutarSQL(sql);
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); // Limpiar el dataset

            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            // 1. Cargar Alumnos
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos");

            // 2. Cargar Materias
            objComando.CommandText = "SELECT * FROM materias";
            objDataAdapter.Fill(objDs, "materias");

            // 3. Cargar Periodos
            objComando.CommandText = "SELECT * FROM periodos";
            objDataAdapter.Fill(objDs, "periodos");

            // 4. Cargar Notas
            objComando.CommandText = "SELECT n.idNota, a.nombre AS Alumno, p.periodo AS Periodo, n.fecha FROM notas n INNER JOIN alumnos a ON n.idAlumno = a.idAlumno INNER JOIN periodos p ON n.idPeriodo = p.idPeriodo";
            objDataAdapter.Fill(objDs, "notas");

            return objDs;
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono, email) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosPeriodos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO periodos(periodo) VALUES ('" + datos[1] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE periodos SET periodo='" + datos[1] + "' WHERE idPeriodo=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM periodos WHERE idPeriodo=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosNotas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO notas(idAlumno, idPeriodo, fecha) VALUES (" + datos[0] + ", " + datos[1] + ", GETDATE())";
            }
            return ejecutarSQL(sql);
        }

        public String ejecutarSQL(String sql)
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