namespace BusquedaArreglo.Formularios
{
    partial class BusquedaEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbEstudiantes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBuscarId = new System.Windows.Forms.TextBox();
            this.btnId = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del estudiante:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(178, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(221, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(468, 55);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(142, 22);
            this.tbId.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(631, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbEstudiantes
            // 
            this.lbEstudiantes.FormattingEnabled = true;
            this.lbEstudiantes.ItemHeight = 16;
            this.lbEstudiantes.Location = new System.Drawing.Point(29, 126);
            this.lbEstudiantes.Name = "lbEstudiantes";
            this.lbEstudiantes.Size = new System.Drawing.Size(714, 180);
            this.lbEstudiantes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encontrar Estudiante por nombre:";
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(237, 317);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(274, 22);
            this.tbBuscarNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id: 000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Encontrar Estudiante por ID:";
            // 
            // tbBuscarId
            // 
            this.tbBuscarId.Location = new System.Drawing.Point(237, 355);
            this.tbBuscarId.Name = "tbBuscarId";
            this.tbBuscarId.Size = new System.Drawing.Size(100, 22);
            this.tbBuscarId.TabIndex = 10;
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(648, 351);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(95, 23);
            this.btnId.TabIndex = 11;
            this.btnId.Text = "BUSCAR";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(648, 313);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(95, 23);
            this.btnNombre.TabIndex = 12;
            this.btnNombre.Text = "BUSCAR";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // BusquedaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.tbBuscarId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBuscarNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEstudiantes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBuscarId;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Button btnNombre;
    }
}