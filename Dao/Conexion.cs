using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace practica_crud.Dao
{
    class Conexion
    {
        public DataSet ejecutarprocedimiento(string nombre, params SqlParameter[] parametros)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            string mensaje;
            try
            {
                //Se crea la conexion
                using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString()))
                {
                    using (var comando = new SqlCommand(nombre, conexion))
                    {
                        using (var adapter = new SqlDataAdapter(comando))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            //si se tienen parametros se envian al procedimiento almacenado
                            if (parametros != null)
                                foreach (SqlParameter item in parametros)
                                    comando.Parameters.Add(dataset);
                            //SectionInformation abre la conexion
                            conexion.Open();                            
                            adapter.Fill(dataset);
                            comando.Parameters.Clear();
                            conexion.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //se devuelde un dataset con una tabla y el mensaje de error
                mensaje = e.Message;
                datatable.Columns.Add("error");
                datatable.Rows.Add(mensaje);
                dataset.Tables.Add(datatable);
            }
            //SectionInformation retorna el dataset
            return dataset;
        }


    }
}
