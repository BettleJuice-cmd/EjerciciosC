namespace BusquedaArreglo.Formularios
{
    partial class BusquedaTexto
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
            this.tbParrafo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblParrafo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbParrafo
            // 
            this.tbParrafo.Location = new System.Drawing.Point(162, 64);
            this.tbParrafo.Name = "tbParrafo";
            this.tbParrafo.Size = new System.Drawing.Size(100, 22);
            this.tbParrafo.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(347, 62);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 27);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblParrafo
            // 
            this.lblParrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblParrafo.Location = new System.Drawing.Point(30, 115);
            this.lblParrafo.Name = "lblParrafo";
            this.lblParrafo.Size = new System.Drawing.Size(426, 153);
            this.lblParrafo.TabIndex = 3;
            this.lblParrafo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el texto aquí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Palabra que desea buscar:";
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(203, 310);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(100, 22);
            this.tbPalabra.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(347, 305);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 27);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // BusquedaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParrafo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbParrafo);
            this.Name = "BusquedaTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaTexto";
            this.Load += new System.EventHandler(this.BusquedaTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbParrafo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblParrafo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.Button btnBuscar;
    }
}