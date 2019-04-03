using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Actividades_1_4.Modelo.Campeonato;

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
            Program.formaPrincipal.Show();
            Hide();
        }

        private void buttonJornadas_Click(object sender, EventArgs e)
        {
            Program.formaJornada.Show();
            Hide();
        }
        private void LoadGrid()
        {
            //metodo que inicializa datos de dataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows.Clear();// Si hay datos los elimina
            dataGridView1.AllowUserToAddRows = false; //permite agregar registros

            if (File.Exists(path))
            {
                //Abre el flujo del archivo para leer datos
                StreamReader stream = new StreamReader(path, Encoding.Default);
                string text;
                text = stream.ReadLine();
                while ((text = stream.ReadLine()) != null)
                {
                    //Lee cada linea a partiendola a traves del caracter
                    string[] array = text.Split('|');
                    dataGridView1.Rows.Add(array); // Agrega un renglon
                }
            }
        }

        private void Campeonato_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pictureAdd_Click(object sender, EventArgs e)
        {
            string msg = "";// mensaje vacío

            //se valida el contenido de carateres entre 3 y 50
            if (textBoxNombre.Text.Length < 3 || textBoxNombre.Text.Length > 50)
            {
                msg += "El mensaje debe estar comprendido entre 3 y 50 caracteres";
            }

            //Se crearan nuevas fechas eliminando horas, minutos y segundos
            DateTime fechaInicio = new DateTime(dateInicio.Value.Year, dateInicio.Value.Month, dateInicio.Value.Day,0,0,0);
            DateTime fechaFin = new DateTime(dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day,0,0,0);
            if(DateTime.Compare(fechaInicio, fechaFin) <= 0)
            {
                //se validan fechas
                msg = "\nLa fecha Inicio debe ser menor a la fecha final";
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //En caso de que se cumplan las validaciones
            }

            //crea un objeto de tipo campeonato
            claseCampeonato campeonato = new claseCampeonato();
            campeonato.Id = new Random().Next(1,1000);
        }
    }
}
