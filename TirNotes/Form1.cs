﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TirNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpen = new OpenFileDialog();
            StreamReader myReading = null;

            myOpen.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            myOpen.Title = "Abrir archivo";
            myOpen.ShowDialog();
            myOpen.OpenFile();
            string ruteFile = myOpen.FileName;

            myReading = File.OpenText(ruteFile);
            contenidoTextBox.Text = myReading.ReadToEnd();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog mySave = new SaveFileDialog();
            StreamWriter myWriter = null;
            
            mySave.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            mySave.Title = "Guardar como...";
            mySave.ShowDialog();
            string rute = mySave.FileName;
            myWriter = File.AppendText(rute);
            myWriter.Write(contenidoTextBox.Text);
            myWriter.Flush();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Redo();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Undo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Cut();
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoTextBox.Clear();
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime actualDate = DateTime.Now;
            contenidoTextBox.Text = contenidoTextBox.Text + actualDate.ToString();
        }

        private void estiloDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();
            myFont.Font = contenidoTextBox.SelectionFont ?? contenidoTextBox.Font;
            if (myFont.ShowDialog() == DialogResult.OK)
            {
                contenidoTextBox.SelectionFont = myFont.Font;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog myColorDialog = new ColorDialog();
            if(myColorDialog.ShowDialog() == DialogResult.OK)
            {
                contenidoTextBox.SelectionColor = myColorDialog.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog myColorBackground = new ColorDialog();
            if (myColorBackground.ShowDialog() == DialogResult.OK)
            {
                contenidoTextBox.BackColor = myColorBackground.Color;
            }
        }
    }
}