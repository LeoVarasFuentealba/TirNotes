using System;
using System.Drawing;
using System.Windows.Forms;

namespace TirNotes
{
    public partial class FloatingForm : Form
    {
        public delegate void TextChangedHandler(string newText);
        public event TextChangedHandler TextChanged;

        public FloatingForm()
        {
            InitializeComponent();
            this.TopMost = true;
            FloatingTextBox.TextChanged += FloatingTextBox_TextChanged;
        }

        private void FloatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FloatingTextBox.IsDisposed)
                return;

            TextChanged?.Invoke(FloatingTextBox.Rtf);
        }

        public void SetFloatingText(string text)
        {
            if (FloatingTextBox.IsDisposed)
                return;

            FloatingTextBox.Rtf = text;
        }

        public void UpdateTextColor(Color color)
        {
            if (FloatingTextBox.IsDisposed)
                return;

            FloatingTextBox.ForeColor = color;
        }

        internal void UpdateSelectionFont(Font font)
        {
            if (FloatingTextBox.IsDisposed)
                return;

            FloatingTextBox.Font = font;
        }

        public void UpdateOpacity(string opacidadStr)
        {
            string opacidadValue = opacidadStr.TrimEnd('%');
            if (int.TryParse(opacidadValue, out int opacidad))
            {
                Opacity = Math.Max(0.0, Math.Min(1.0, opacidad / 100.0));
            }
            else
            {
                MessageBox.Show("El valor de opacidad no es válido.");
            }
        }

        private void FloatingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FloatingTextBox.TextChanged -= FloatingTextBox_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcionesPip opcionesPip = new OpcionesPip();
            opcionesPip.ShowDialog();

            UpdateOpacity(opcionesPip.Opacidad);
        }
    }
}
