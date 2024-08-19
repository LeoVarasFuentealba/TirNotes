
namespace TirNotes
{
    partial class OpcionesPip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesPip));
            this.Opacidadcnf = new System.Windows.Forms.ComboBox();
            this.Opacidadtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Opacidadcnf
            // 
            this.Opacidadcnf.FormattingEnabled = true;
            this.Opacidadcnf.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.Opacidadcnf.Location = new System.Drawing.Point(28, 41);
            this.Opacidadcnf.Name = "Opacidadcnf";
            this.Opacidadcnf.Size = new System.Drawing.Size(121, 24);
            this.Opacidadcnf.TabIndex = 0;
            this.Opacidadcnf.SelectedIndexChanged += new System.EventHandler(this.Opacidadcnf_SelectedIndexChanged);
            // 
            // Opacidadtxt
            // 
            this.Opacidadtxt.Location = new System.Drawing.Point(28, 13);
            this.Opacidadtxt.Name = "Opacidadtxt";
            this.Opacidadtxt.Size = new System.Drawing.Size(100, 22);
            this.Opacidadtxt.TabIndex = 1;
            this.Opacidadtxt.Text = "Opacity:";
            // 
            // OpcionesPip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 183);
            this.Controls.Add(this.Opacidadtxt);
            this.Controls.Add(this.Opacidadcnf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpcionesPip";
            this.Text = "OpcionesPip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Opacidadcnf;
        private System.Windows.Forms.TextBox Opacidadtxt;
    }
}