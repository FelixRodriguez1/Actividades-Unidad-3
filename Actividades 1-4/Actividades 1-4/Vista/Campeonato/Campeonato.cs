﻿using System;
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
    }
}
