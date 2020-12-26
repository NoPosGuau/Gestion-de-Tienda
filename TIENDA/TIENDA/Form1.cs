using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIENDA
{ 
    public partial class Form1 : Form
    {
        SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-2QS4911; DATABASE=login; integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void preciotex_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM TIENDA WHERE ARTICULO=@articulo", Conexion);
            comando.Parameters.AddWithValue("@articulo", articulotex.Text);
            Conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                articulotex.Text = registro["ARTICULO"].ToString();
                condiciontex.Text = registro["CONDICION"].ToString();
                preciotex.Text = registro["PRECIO"].ToString();
                
            }
            Conexion.Close();
        }

        private void condiciontex_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarbox_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from TIENDA", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gv.DataSource = tabla;

            string querry = "INSERT INTO TIENDA (ARTICULO,CONDICION,PRECIO) VALUES (@articulo,@condicion,@precio)";
            Conexion.Open();
            SqlCommand coman = new SqlCommand(querry, Conexion);
            coman.Parameters.AddWithValue("@articulo", articulotex.Text);
            coman.Parameters.AddWithValue("@condicion", condiciontex.Text);
            coman.Parameters.AddWithValue("@precio", preciotex.Text);
            coman.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("INSERTADOS");

            SqlCommand comand = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptad = new SqlDataAdapter();
            adaptad.SelectCommand = comand;
            DataTable tab = new DataTable();
            adaptad.Fill(tab);
            gv.DataSource = tab;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editarbox_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE TIENDA SET ARTICULO=@articulo, CONDICION=@condicion, PRECIO=@precio WHERE ARTICULO=@articulo";
            Conexion.Open();
            SqlCommand coman = new SqlCommand(querry, Conexion);
            coman.Parameters.AddWithValue("@articulo", articulotex.Text);
            coman.Parameters.AddWithValue("@condicion", condiciontex.Text);
            coman.Parameters.AddWithValue("@precio", preciotex.Text);
            coman.ExecuteNonQuery();
            SqlCommand comand = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptad = new SqlDataAdapter();
            adaptad.SelectCommand = comand;
            DataTable tab = new DataTable();
            adaptad.Fill(tab);
            gv.DataSource = tab;
            Conexion.Close();
            MessageBox.Show("ACTUALIZADO");

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void articulotex_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void eliminarbox_Click(object sender, EventArgs e)
        {
            string querry = "DELETE TIENDA WHERE ARTICULO=@articulo";
            Conexion.Open();
            SqlCommand coman = new SqlCommand(querry, Conexion);
            coman.Parameters.AddWithValue("@articulo", articulotex.Text);
            coman.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("ELIMINADO");

            SqlCommand comand = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptad = new SqlDataAdapter();
            adaptad.SelectCommand = comand;
            DataTable tab = new DataTable();
            adaptad.Fill(tab);
            gv.DataSource = tab;
        }

        private void mostrabox_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gv.DataSource = tabla;
        }

        private void deudoresbox_Click(object sender, EventArgs e)
        {
            deudores d = new deudores();
            d.Show();
            this.Hide();
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
