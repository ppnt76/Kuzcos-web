namespace WindowsFormsApp1
{
    partial class FormAgregar
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.tBImagen = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.cBMarca = new System.Windows.Forms.ComboBox();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lImagenUrl = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lCodigo = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(26, 374);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(150, 50);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(631, 374);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(150, 50);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbxId);
            this.groupBox1.Controls.Add(this.tBPrecio);
            this.groupBox1.Controls.Add(this.tBImagen);
            this.groupBox1.Controls.Add(this.tBDesc);
            this.groupBox1.Controls.Add(this.tBNombre);
            this.groupBox1.Controls.Add(this.tCodigo);
            this.groupBox1.Controls.Add(this.cBMarca);
            this.groupBox1.Controls.Add(this.cBCategoria);
            this.groupBox1.Controls.Add(this.lPrecio);
            this.groupBox1.Controls.Add(this.lImagenUrl);
            this.groupBox1.Controls.Add(this.lMarca);
            this.groupBox1.Controls.Add(this.lCategoria);
            this.groupBox1.Controls.Add(this.lDescripcion);
            this.groupBox1.Controls.Add(this.lNombre);
            this.groupBox1.Controls.Add(this.lCodigo);
            this.groupBox1.Location = new System.Drawing.Point(126, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(158, 200);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(300, 20);
            this.tBPrecio.TabIndex = 13;
            this.tBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPrecio_KeyPress);
            // 
            // tBImagen
            // 
            this.tBImagen.Location = new System.Drawing.Point(158, 170);
            this.tBImagen.Name = "tBImagen";
            this.tBImagen.Size = new System.Drawing.Size(300, 20);
            this.tBImagen.TabIndex = 12;
            // 
            // tBDesc
            // 
            this.tBDesc.Location = new System.Drawing.Point(158, 80);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(300, 20);
            this.tBDesc.TabIndex = 11;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(158, 50);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(300, 20);
            this.tBNombre.TabIndex = 10;
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(158, 20);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(300, 20);
            this.tCodigo.TabIndex = 9;
            // 
            // cBMarca
            // 
            this.cBMarca.FormattingEnabled = true;
            this.cBMarca.Location = new System.Drawing.Point(158, 140);
            this.cBMarca.Name = "cBMarca";
            this.cBMarca.Size = new System.Drawing.Size(300, 21);
            this.cBMarca.TabIndex = 8;
            // 
            // cBCategoria
            // 
            this.cBCategoria.FormattingEnabled = true;
            this.cBCategoria.Location = new System.Drawing.Point(158, 110);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(300, 21);
            this.cBCategoria.TabIndex = 7;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.White;
            this.lPrecio.Location = new System.Drawing.Point(40, 200);
            this.lPrecio.MaximumSize = new System.Drawing.Size(130, 24);
            this.lPrecio.MinimumSize = new System.Drawing.Size(130, 24);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(130, 24);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio";
            // 
            // lImagenUrl
            // 
            this.lImagenUrl.AutoSize = true;
            this.lImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lImagenUrl.ForeColor = System.Drawing.Color.White;
            this.lImagenUrl.Location = new System.Drawing.Point(40, 170);
            this.lImagenUrl.MaximumSize = new System.Drawing.Size(130, 24);
            this.lImagenUrl.MinimumSize = new System.Drawing.Size(130, 24);
            this.lImagenUrl.Name = "lImagenUrl";
            this.lImagenUrl.Size = new System.Drawing.Size(130, 24);
            this.lImagenUrl.TabIndex = 5;
            this.lImagenUrl.Text = "ImagenURL";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarca.ForeColor = System.Drawing.Color.White;
            this.lMarca.Location = new System.Drawing.Point(40, 140);
            this.lMarca.MaximumSize = new System.Drawing.Size(130, 24);
            this.lMarca.MinimumSize = new System.Drawing.Size(130, 24);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(130, 24);
            this.lMarca.TabIndex = 4;
            this.lMarca.Text = "Marca";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategoria.ForeColor = System.Drawing.Color.White;
            this.lCategoria.Location = new System.Drawing.Point(40, 110);
            this.lCategoria.MaximumSize = new System.Drawing.Size(130, 24);
            this.lCategoria.MinimumSize = new System.Drawing.Size(130, 24);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(130, 24);
            this.lCategoria.TabIndex = 3;
            this.lCategoria.Text = "Categoria";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.ForeColor = System.Drawing.Color.White;
            this.lDescripcion.Location = new System.Drawing.Point(40, 80);
            this.lDescripcion.MaximumSize = new System.Drawing.Size(130, 24);
            this.lDescripcion.MinimumSize = new System.Drawing.Size(130, 24);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(130, 24);
            this.lDescripcion.TabIndex = 2;
            this.lDescripcion.Text = "Descripcion";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(40, 50);
            this.lNombre.MaximumSize = new System.Drawing.Size(120, 24);
            this.lNombre.MinimumSize = new System.Drawing.Size(120, 24);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(120, 24);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.ForeColor = System.Drawing.Color.White;
            this.lCodigo.Location = new System.Drawing.Point(40, 20);
            this.lCodigo.MaximumSize = new System.Drawing.Size(120, 24);
            this.lCodigo.MinimumSize = new System.Drawing.Size(120, 24);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(120, 24);
            this.lCodigo.TabIndex = 0;
            this.lCodigo.Text = "Codigo";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(159, 236);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(76, 20);
            this.tbxId.TabIndex = 14;
            this.tbxId.Visible = false;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "FormAgregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lImagenUrl;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.TextBox tBImagen;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.ComboBox cBMarca;
        private System.Windows.Forms.ComboBox cBCategoria;
        private System.Windows.Forms.TextBox tbxId;
    }
}