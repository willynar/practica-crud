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
            //sender invoca la clase data acces objet
            Conexion conex = new Conexion();
            //sender crea un array sqlparametros y se llena con los datos a enviar al procedimiento almacenado
            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre",variable)
            };
            //se envian los parametros y el nombre de el procedimeinto almacenado al dao
            DataSet result = conex.ejecutarprocedimiento("procedimiento", parametros);
        }
    }
}
