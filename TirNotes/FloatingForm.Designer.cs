
namespace TirNotes
{
    partial class FloatingForm
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
            this.FloatingTextBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Opciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FloatingTextBox
            // 
            this.FloatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FloatingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FloatingTextBox.Location = new System.Drawing.Point(0, 0);
            this.FloatingTextBox.Name = "FloatingTextBox";
            this.FloatingTextBox.Size = new System.Drawing.Size(491, 284);
            this.FloatingTextBox.TabIndex = 0;
            this.FloatingTextBox.Text = "";
            // 
            // Opciones
            // 
            this.Opciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Opciones.Location = new System.Drawing.Point(434, 12);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(45, 23);
            this.Opciones.TabIndex = 1;
            this.Opciones.Text = "...";
            this.Opciones.UseVisualStyleBackColor = false;
            this.Opciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // FloatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 284);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.FloatingTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FloatingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FloatingForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FloatingTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Opciones;
    }
}