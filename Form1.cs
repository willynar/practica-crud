using practica_crud.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace practica_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string variable = "hola";
            Conexion conex = new Conexion();
            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre",variable)
            };
            DataSet result = conex.ejecutarprocedimiento("procedimiento", parametros);
        }
    }
}
