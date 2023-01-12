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
            this.btnCrearPersonajes = new System.Windows.Forms.Button();
            this.btnListarPersonajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaPersonajes
            // 
            this.dataGridViewListaPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPersonajes.Location = new System.Drawing.Point(30, 35);
            this.dataGridViewListaPersonajes.Name = "dataGridViewListaPersonajes";
            this.dataGridViewListaPersonajes.Size = new System.Drawing.Size(465, 277);
            this.dataGridViewListaPersonajes.TabIndex = 0;
            // 
            // btnCrearPersonajes
            // 
            this.btnCrearPersonajes.Location = new System.Drawing.Point(578, 71);
            this.btnCrearPersonajes.Name = "btnCrearPersonajes";
            this.btnCrearPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnCrearPersonajes.TabIndex = 1;
            this.btnCrearPersonajes.Text = "Crear Personajes";
            this.btnCrearPersonajes.UseVisualStyleBackColor = true;
            this.btnCrearPersonajes.Click += new System.EventHandler(this.btnCrearPersonajes_Click);
            // 
            // btnListarPersonajes
            // 
            this.btnListarPersonajes.Location = new System.Drawing.Point(578, 121);
            this.btnListarPersonajes.Name = "btnListarPersonajes";
            this.btnListarPersonajes.Size = new System.Drawing.Size(111, 34);
            this.btnListarPersonajes.TabIndex = 2;
            this.btnListarPersonajes.Text = "Listar Personajes";
            this.btnListarPersonajes.UseVisualStyleBackColor = true;
            this.btnListarPersonajes.Click += new System.EventHandler(this.btnListarPersonajes_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarPersonajes);
            this.Controls.Add(this.btnCrearPersonajes);
            this.Controls.Add(this.dataGridViewListaPersonajes);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaPersonajes;
        private System.Windows.Forms.Button btnCrearPersonajes;
        private System.Windows.Forms.Button btnListarPersonajes;
    }
}

