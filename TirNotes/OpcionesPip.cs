using System;
using System.Windows.Forms;

namespace TirNotes
{
    public partial class OpcionesPip : Form
    {
        public string Opacidad { get; private set; } = "100%";

        public OpcionesPip()
        {
            InitializeComponent();
        }

        private void Opacidadcnf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Opacidad = Opacidadcnf.Text;
        }
    }
}
