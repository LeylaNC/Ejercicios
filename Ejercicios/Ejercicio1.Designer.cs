namespace Ejercicios
{
    partial class Ejercicio1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewListaPersonajes = new System.Windows.Forms.DataGridView();
            this.btnIngresarPersonajes = new System.Windows.Forms.Button();
            this.btnListarPersonajes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNovela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxUniverso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPersonajes = new System.Windows.Forms.Button();
            this.btnEliminarPersonajes = new System.Windows.Forms.Button();
            this.btnModificarPersonajes = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiarPagina = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaPersonajes
            // 
            this.dataGridViewListaPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPersonajes.Location = new System.Drawing.Point(30, 35);
            this.dataGridViewListaPersonajes.Name = "dataGridViewListaPersonajes";
            this.dataGridViewListaPersonajes.ReadOnly = true;
            this.dataGridViewListaPersonajes.Size = new System.Drawing.Size(498, 277);
            this.dataGridViewListaPersonajes.TabIndex = 0;
            // 
            // btnIngresarPersonajes
            // 
            this.btnIngresarPersonajes.Location = new System.Drawing.Point(537, 278);
            this.btnIngresarPersonajes.Name = "btnIngresarPersonajes";
            this.btnIngresarPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnIngresarPersonajes.TabIndex = 1;
            this.btnIngresarPersonajes.Text = "Ingresar Personaje";
            this.btnIngresarPersonajes.UseVisualStyleBackColor = true;
            this.btnIngresarPersonajes.Click += new System.EventHandler(this.btnIngresarPersonajes_Click);
            // 
            // btnListarPersonajes
            // 
            this.btnListarPersonajes.Location = new System.Drawing.Point(677, 219);
            this.btnListarPersonajes.Name = "btnListarPersonajes";
            this.btnListarPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnListarPersonajes.TabIndex = 2;
            this.btnListarPersonajes.Text = "Listar Personajes";
            this.btnListarPersonajes.UseVisualStyleBackColor = true;
            this.btnListarPersonajes.Click += new System.EventHandler(this.btnListarPersonajes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(602, 51);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(186, 20);
            this.txtBoxNombre.TabIndex = 4;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(602, 86);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(186, 20);
            this.txtBoxApellido.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // txtBoxNovela
            // 
            this.txtBoxNovela.Location = new System.Drawing.Point(602, 123);
            this.txtBoxNovela.Name = "txtBoxNovela";
            this.txtBoxNovela.Size = new System.Drawing.Size(186, 20);
            this.txtBoxNovela.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Novela";
            // 
            // txtBoxUniverso
            // 
            this.txtBoxUniverso.Location = new System.Drawing.Point(602, 174);
            this.txtBoxUniverso.Name = "txtBoxUniverso";
            this.txtBoxUniverso.Size = new System.Drawing.Size(186, 20);
            this.txtBoxUniverso.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Universo";
            // 
            // btnBuscarPersonajes
            // 
            this.btnBuscarPersonajes.Location = new System.Drawing.Point(537, 337);
            this.btnBuscarPersonajes.Name = "btnBuscarPersonajes";
            this.btnBuscarPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnBuscarPersonajes.TabIndex = 12;
            this.btnBuscarPersonajes.Text = "Buscar Personajes";
            this.btnBuscarPersonajes.UseVisualStyleBackColor = true;
            this.btnBuscarPersonajes.Click += new System.EventHandler(this.btnBuscarPersonajes_Click);
            // 
            // btnEliminarPersonajes
            // 
            this.btnEliminarPersonajes.Location = new System.Drawing.Point(677, 337);
            this.btnEliminarPersonajes.Name = "btnEliminarPersonajes";
            this.btnEliminarPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnEliminarPersonajes.TabIndex = 11;
            this.btnEliminarPersonajes.Text = "Eliminar Personaje";
            this.btnEliminarPersonajes.UseVisualStyleBackColor = true;
            this.btnEliminarPersonajes.Click += new System.EventHandler(this.btnEliminarPersonajes_Click);
            // 
            // btnModificarPersonajes
            // 
            this.btnModificarPersonajes.Enabled = false;
            this.btnModificarPersonajes.Location = new System.Drawing.Point(677, 278);
            this.btnModificarPersonajes.Name = "btnModificarPersonajes";
            this.btnModificarPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnModificarPersonajes.TabIndex = 14;
            this.btnModificarPersonajes.Text = "Modificar Personaje";
            this.btnModificarPersonajes.UseVisualStyleBackColor = true;
            this.btnModificarPersonajes.Click += new System.EventHandler(this.btnModificarPersonajes_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(559, 223);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(45, 20);
            this.txtBoxId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Id";
            // 
            // btnLimpiarPagina
            // 
            this.btnLimpiarPagina.Location = new System.Drawing.Point(30, 318);
            this.btnLimpiarPagina.Name = "btnLimpiarPagina";
            this.btnLimpiarPagina.Size = new System.Drawing.Size(92, 24);
            this.btnLimpiarPagina.TabIndex = 17;
            this.btnLimpiarPagina.Text = "Limpiar Página";
            this.btnLimpiarPagina.UseVisualStyleBackColor = true;
            this.btnLimpiarPagina.Click += new System.EventHandler(this.btnLimpiarPagina_Click);
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.Enabled = false;
            this.btnConfirmarCambios.Location = new System.Drawing.Point(677, 278);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(111, 34);
            this.btnConfirmarCambios.TabIndex = 18;
            this.btnConfirmarCambios.Text = " Confirmar Cambios";
            this.btnConfirmarCambios.UseVisualStyleBackColor = true;
            this.btnConfirmarCambios.Visible = false;
            this.btnConfirmarCambios.Click += new System.EventHandler(this.btnConfirmarCambios_Click_1);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmarCambios);
            this.Controls.Add(this.btnLimpiarPagina);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModificarPersonajes);
            this.Controls.Add(this.btnBuscarPersonajes);
            this.Controls.Add(this.btnEliminarPersonajes);
            this.Controls.Add(this.txtBoxUniverso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNovela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarPersonajes);
            this.Controls.Add(this.btnIngresarPersonajes);
            this.Controls.Add(this.dataGridViewListaPersonajes);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio1_FormClosing);
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaPersonajes;
        private System.Windows.Forms.Button btnIngresarPersonajes;
        private System.Windows.Forms.Button btnListarPersonajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNovela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxUniverso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPersonajes;
        private System.Windows.Forms.Button btnEliminarPersonajes;
        private System.Windows.Forms.Button btnModificarPersonajes;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiarPagina;
        private System.Windows.Forms.Button btnConfirmarCambios;
    }
}

