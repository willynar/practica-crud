using Newtonsoft.Json;
using practica_crud.Dao;
using practica_crud.models.request;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace practica_crud
{
    public partial class Form1 : Form
    {
        api programa = new api();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string result = await programa.GetHttp();
            DataSet data = new DataSet();
            data.Tables.Add(JsonConvert.DeserializeObject<DataTable>(result));
            dataGridView1.DataSource = data.Tables[0];
        }



        private void Button2_Click(object sender, EventArgs e)
        {

            personaRequest objpersona = new personaRequest();
            objpersona.nombre = textBox1.Text;
            objpersona.apellido = textBox2.Text;
            objpersona.correo = textBox3.Text;
            objpersona.contrasena = textBox4.Text;


            string Resultado = programa.Send<personaRequest>("https://apisena.000webhostapp.com/insertar.php", objpersona, "POST");
            //string Resultado = programa.postMetodo("https://apisena.000webhostapp.com/insertar.php", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, "POST");
            //programa.POSTreq("https://apisena.000webhostapp.com/insertar.php", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            //string Resultado = programa.potCon<personaRequest>("https://apisena.000webhostapp.com/insertar.php",objpersona);
            //string Resultado = programa.Main<personaRequest>("https://apisena.000webhostapp.com/insertar.php",objpersona);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string correo = textBox3.Text;
            string contrasena = textBox4.Text;

            //sender invoca la clase data acces objet
            Conexion conex = new Conexion();
            //sender crea un array sqlparametros y se llena con los datos a enviar al procedimiento almacenado
            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre",nombre),
                new SqlParameter("@apellido",apellido),
                new SqlParameter("@correo",correo),
                new SqlParameter("@contrasena",contrasena)
            };
            //se envian los parametros y el nombre de el procedimeinto almacenado al dao
            DataSet result = conex.ejecutarprocedimiento("nombreprocedimiento", parametros);
        }
    }
}
