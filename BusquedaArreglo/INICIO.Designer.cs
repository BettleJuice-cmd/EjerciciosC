namespace BusquedaArreglo
{
    partial class INICIO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeTextoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem,
            this.busquedaListaToolStripMenuItem,
            this.busquedaDeTextoiToolStripMenuItem,
            this.busquedaEstudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.aleatorioToolStripMenuItem.Text = "Busqueda Arreglo";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // busquedaListaToolStripMenuItem
            // 
            this.busquedaListaToolStripMenuItem.Name = "busquedaListaToolStripMenuItem";
            this.busquedaListaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.busquedaListaToolStripMenuItem.Text = "Busqueda Lista";
            this.busquedaListaToolStripMenuItem.Click += new System.EventHandler(this.busquedaListaToolStripMenuItem_Click);
            // 
            // busquedaDeTextoiToolStripMenuItem
            // 
            this.busquedaDeTextoiToolStripMenuItem.Name = "busquedaDeTextoiToolStripMenuItem";
            this.busquedaDeTextoiToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.busquedaDeTextoiToolStripMenuItem.Text = "Busqueda de Texto";
            this.busquedaDeTextoiToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeTextoiToolStripMenuItem_Click);
            // 
            // busquedaEstudianteToolStripMenuItem
            // 
            this.busquedaEstudianteToolStripMenuItem.Name = "busquedaEstudianteToolStripMenuItem";
            this.busquedaEstudianteToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.busquedaEstudianteToolStripMenuItem.Text = "Busqueda Estudiante";
            this.busquedaEstudianteToolStripMenuItem.Click += new System.EventHandler(this.busquedaEstudianteToolStripMenuItem_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeTextoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaEstudianteToolStripMenuItem;
    }
}