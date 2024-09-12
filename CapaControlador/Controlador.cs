using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
//using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Consultas sn = new Consultas();
        // LLenar una tabla CAPA CONTROLADOR
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        ///Controlador///

        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmb(tabla, campo1, campo2);

            return Items;


        }

        ///Controlador 2///

        public DataTable enviar(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtener(tabla, campo1, campo2);

            return dt1;
        }

        public bool EliminarRegistro(int id)
        {
            //OdbcConnection conn = Conexion.conexion(); // Abrir conexión
            bool resultado = false;

            try
            {
                string query = "UPDATE tu_tabla SET estado = 'inactivo' WHERE id = ?";
                //using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    //command.Parameters.AddWithValue("@id", id);
                    //int rowsAffected = command.ExecuteNonQuery();

                    //if (rowsAffected > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                //Conexion.desconexion(conn); // Cerrar conexión
            }

            return resultado; // Retorna true si se actualizó correctamente, false si hubo algún error
        }
        public DataTable CargarDatos()
        {
            //OdbcConnection conn = Conexion.conexion(); // Abrir conexión
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT * FROM tu_tabla WHERE estado = 'activo'";
                //OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, conn);
                //dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                //Conexion.desconexion(conn); // Cerrar conexión
            }

            return dataTable; // Retorna los datos activos
        }



        public bool BuscarRegistro(int id)
        {
            //OdbcConnection conn = Conexion.conexion(); // Abrir conexión
            bool resultado = false;

            try
            {
                string query = "UPDATE tu_tabla SET estado = 'inactivo' WHERE id = ?";
                //using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    //command.Parameters.AddWithValue("@id", id);
                    //int rowsAffected = command.ExecuteNonQuery();

                    //if (rowsAffected > 0)
                    {
                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                //Conexion.desconexion(conn); // Cerrar conexión
            }

            return resultado; // Retorna true si se actualizó correctamente, false si hubo algún error
        }







    }



}
