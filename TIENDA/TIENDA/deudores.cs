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
    public partial class deudores : Form
    {
        SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-2QS4911; DATABASE=login; integrated security=true");
        public deudores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM DEBEN", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gv2.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE DEBEN SET NOMBRE=@nombre, DEBE=@debe, ARTICULO=@articulo, NOTAS=@notas WHERE NOMBRE=@nombre";
            Conexion.Open();
            SqlCommand coman = new SqlCommand(querry, Conexion);
            coman.Parameters.AddWithValue("@nombre", nombretex.Text);
            coman.Parameters.AddWithValue("@debe", debetext.Text);
            coman.Parameters.AddWithValue("@articulo", articulo2text.Text);
            coman.Parameters.AddWithValue("@notas", notatex.Text);
            coman.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("ACTUALIZADO");
            SqlCommand comand = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptad = new SqlDataAdapter();
            adaptad.SelectCommand = comand;
            DataTable tab = new DataTable();
            adaptad.Fill(tab);
            gv2.DataSource = tab;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM DEBEN WHERE NOMBRE=@nombre", Conexion);
            comando.Parameters.AddWithValue("@articulo", nombretex.Text);
            Conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                nombretex.Text = registro["NOMBRE"].ToString();
                debetext.Text = registro["DEBE"].ToString();
                articulo2text.Text = registro["ARTICULO"].ToString();
                notatex.Text = registro["NOTAS"].ToString();

            }
            Conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from DEBEN", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gv2.DataSource = tabla;
            string querry = "INSERT INTO DEBEN (NOMBRE,DEBE,ARTICULO,NOTAS) VALUES (@nombre,@debe,@articulo,@notas)";
            Conexion.Open();
            SqlCommand coman = new SqlCommand(querry, Conexion);
            coman.Parameters.AddWithValue("@nombre", nombretex.Text);
            coman.Parameters.AddWithValue("@debe", debetext.Text);
            coman.Parameters.AddWithValue("@articulo", articulo2text.Text);
            coman.Parameters.AddWithValue("@notas", notatex.Text);
            coman.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("INSERTADOS");
            SqlCommand comand = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptad = new SqlDataAdapter();
            adaptad.SelectCommand = comand;
            DataTable tab = new DataTable();
            adaptad.Fill(tab);
            gv2.DataSource = tab;

        }

        private void dv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string querry = "DELETE DEBEN WHERE NOMBRE=@nombre";
            Conexion.Open();
            SqlCommand coman = new SqlCommand(querry, Conexion);
            coman.Parameters.AddWithValue("@nombre", nombretex.Text);
            coman.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("ELIMINADO");
            SqlCommand comand = new SqlCommand("SELECT * FROM TIENDA", Conexion);
            SqlDataAdapter adaptad = new SqlDataAdapter();
            adaptad.SelectCommand = comand;
            DataTable tab = new DataTable();
            adaptad.Fill(tab);
            gv2.DataSource = tab;
        }
    }
}
