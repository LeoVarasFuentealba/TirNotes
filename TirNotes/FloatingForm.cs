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
            TextChanged?.Invoke(FloatingTextBox.Rtf);
        }

        public void SetFloatingText(string text)
        {
            FloatingTextBox.Rtf = text;
        }

        public void UpdateTextColor(Color color)
        {
            FloatingTextBox.ForeColor = color;
        }

        internal void UpdateSelectionFont(Font font)
        {
            FloatingTextBox.Font = font;
        }

        private void FloatingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
        }
    }
}
