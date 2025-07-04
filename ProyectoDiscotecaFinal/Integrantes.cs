﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscotecaFinal
{
    public partial class Integrantes : Form
    {
        public Integrantes(int cantidadIntegrantes)
        {
            InitializeComponent();
            CrearTextBoxes(cantidadIntegrantes);
        }
        private void CrearTextBoxes(int cantidad)
        {
            int espacioY = 20;

            Label lblTitulo = new Label();
            lblTitulo.Text = "Ingresar Nombre Completo de Integrantes";
            lblTitulo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, espacioY);
            lblTitulo.ForeColor = Color.White; // Si tu fondo es oscuro
            this.Controls.Add(lblTitulo);

            espacioY += 40; // Espacio después del título


            for (int i = 1; i <= cantidad; i++)
            {
                // Etiqueta izquierda fija: "Integrante N"
                Label lblNumero = new Label();
                lblNumero.Text = $"Integrante {i}";
                lblNumero.AutoSize = true;
                lblNumero.Location = new Point(30, espacioY);
                lblNumero.ForeColor = Color.White;
                this.Controls.Add(lblNumero);

                // TextBox donde se escribirá el nombre
                TextBox txt = new TextBox();
                txt.Name = "txtIntegrante" + i;
                txt.Width = 200;
                txt.Location = new Point(150, espacioY - 3);
                this.Controls.Add(txt);

                espacioY += 35;
            }

            this.Height = espacioY + 60;
        }
        private void Integrantes_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío si ya estás creando los TextBox en el constructor
        }

    }
}
