using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades_1_4.Vista.Campeonato
{
    public partial class Campeonato : Form
    {
        private string path = "C:\\Users\\locog\\Source\\Repos\\Actividades-Unidad-3\\campeonato.txt";
        public Campeonato()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main c = new Main();
            c.Show();
            this.Hide();
        }

        private void buttonJornadas_Click(object sender, EventArgs e)
        {
            Jornada c = new Jornada();
            c.Show();
            this.Hide();
        }
        private void LoadGrid()
        {
            //metodo que inicializa datos de dataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows.Clear();// Si hay datos los elimina
            dataGridView1.AllowUserToAddRows = false; //permite agregar registros
        }
    }
}
