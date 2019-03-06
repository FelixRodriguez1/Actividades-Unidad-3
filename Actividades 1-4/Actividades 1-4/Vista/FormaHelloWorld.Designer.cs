namespace Actividades_1_4
{
    partial class FormaHelloWorld
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaHelloWorld));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEstudiantes = new System.Windows.Forms.Button();
            this.buttonCarrera = new System.Windows.Forms.Button();
            this.buttonFacilitador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonEstudiantes
            // 
            this.buttonEstudiantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEstudiantes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEstudiantes.Location = new System.Drawing.Point(103, 95);
            this.buttonEstudiantes.Name = "buttonEstudiantes";
            this.buttonEstudiantes.Size = new System.Drawing.Size(114, 23);
            this.buttonEstudiantes.TabIndex = 1;
            this.buttonEstudiantes.Text = "Mostrar estudiante";
            this.buttonEstudiantes.UseVisualStyleBackColor = false;
            this.buttonEstudiantes.Click += new System.EventHandler(this.buttonEstudiantes_Click);
            // 
            // buttonCarrera
            // 
            this.buttonCarrera.Location = new System.Drawing.Point(103, 144);
            this.buttonCarrera.Name = "buttonCarrera";
            this.buttonCarrera.Size = new System.Drawing.Size(114, 23);
            this.buttonCarrera.TabIndex = 2;
            this.buttonCarrera.Text = "Mostrar carrera";
            this.buttonCarrera.UseVisualStyleBackColor = true;
            this.buttonCarrera.Click += new System.EventHandler(this.buttonCarrera_Click);
            // 
            // buttonFacilitador
            // 
            this.buttonFacilitador.Location = new System.Drawing.Point(103, 196);
            this.buttonFacilitador.Name = "buttonFacilitador";
            this.buttonFacilitador.Size = new System.Drawing.Size(114, 23);
            this.buttonFacilitador.TabIndex = 3;
            this.buttonFacilitador.Text = "Mostrar facilitador";
            this.buttonFacilitador.UseVisualStyleBackColor = true;
            this.buttonFacilitador.Click += new System.EventHandler(this.buttonFacilitador_Click);
            // 
            // FormaHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(689, 486);
            this.Controls.Add(this.buttonFacilitador);
            this.Controls.Add(this.buttonCarrera);
            this.Controls.Add(this.buttonEstudiantes);
            this.Controls.Add(this.label1);
            this.Name = "FormaHelloWorld";
            this.Text = "Formulario de inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEstudiantes;
        private System.Windows.Forms.Button buttonCarrera;
        private System.Windows.Forms.Button buttonFacilitador;
    }
}

