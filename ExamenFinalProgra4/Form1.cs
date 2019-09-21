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
        public double precio_telefono = 0;
        public double precio_ensamblaje = 0;
        public double porcentaje = 0;
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
                    precio_ensamblaje = 0.03;
                    total = (precio_telefono * precio_ensamblaje);

                }
                if (combensam.SelectedItem.Equals("Brujas"))
                {
                    precio_ensamblaje = 0.06;
                    total = (precio_telefono * precio_ensamblaje);

                }
                if (combensam.SelectedItem.Equals("Amsterdam"))
                {
                    precio_ensamblaje = 0.09;
                    total = (precio_telefono * precio_ensamblaje);

                }
                if (combensam.SelectedItem.Equals("Londres"))
                {
                    precio_ensamblaje = 0.12;
                    total = (precio_telefono * precio_ensamblaje);

                }

            }

        }
    }
}
