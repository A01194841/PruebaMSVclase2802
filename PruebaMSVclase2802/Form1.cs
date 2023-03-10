using PruebaMSVclase2802.Algoritmo.Clase;
using PruebaMSVclase2802.Algoritmo.metodosalgoritmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMSVclase2802
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDatos = Int32.Parse(textBox1.Text);
            Metodoinicial algoritmo = new Metodoinicial();
            textBox2.Text = algoritmo.algoritmoMain().ToString();
            llenarGrid(numeroDatos, algoritmo.lista);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void llenarGrid(int numeroDatos,List<Demanda> listaInicial) 
        {
            string numeroColumn1 = "1";
            string numeroColumn2 = "2";
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumn1, "ID");
            dataGridView1.Columns.Add(numeroColumn2, "Algoritmo");
            for (int i = 0; i < numeroDatos; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumn1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumn2) - 1].Value = (listaInicial[i].Cantidad).ToString(); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel = (dataGridView1);
        }
    }

}
