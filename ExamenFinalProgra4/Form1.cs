using Modelos.TelefonoModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalProgra4
{
    public partial class Form1 : Form
    {


        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=IpearTelefonosDB;Integrated Security=True");
        DataSet ds;

        public void actualizar()
        {
            Conexion.Open();
            SqlCommand mostrar = new SqlCommand("SELECT * FROM TelefonoTBL", Conexion);
            SqlDataAdapter m_datos = new SqlDataAdapter(mostrar);


            ds = new DataSet();


            m_datos.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];


            Conexion.Close();
        }

        public double precio_telefono = 0;
        public double porcentaje_ensamblaje = 0;
        public double sub_total = 0;
        public double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void combensam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            { 
                MessageBox.Show("Debe ingresar el precio del telefono");
            }
            else
            {
                if (combensam.SelectedItem.Equals  ("Guatemala"))
                {
                    porcentaje_ensamblaje = 0.03;
                    sub_total = (precio_telefono * porcentaje_ensamblaje);

                }
                if (combensam.SelectedItem.Equals("Brujas"))
                {
                    porcentaje_ensamblaje = 0.06;
                    sub_total = (precio_telefono * porcentaje_ensamblaje);

                }
                if (combensam.SelectedItem.Equals("Amsterdam"))
                {
                    porcentaje_ensamblaje = 0.09;
                    sub_total = (precio_telefono * porcentaje_ensamblaje);

                }
                if (combensam.SelectedItem.Equals("Londres"))
                {
                    porcentaje_ensamblaje = 0.12;
                    sub_total = (precio_telefono * porcentaje_ensamblaje);

                }

                total = precio_telefono + sub_total;
                label10.Text = "Q. " + total;
                label10.Visible = true;

            }

            TelefonoModel t1 = new TelefonoModel();

            t1.Gama_Telefono = combgama.Text;
            t1.Color_Telefono = combColor.Text;
            t1.Lugar_Ensamblaje = combensam.Text;
            t1.Precio_Telefono = txtPrecio.Text;

            Form1 his = new Form1();
            his.Show();

            this.actualizar();


           
            
        }

        
    }
}
