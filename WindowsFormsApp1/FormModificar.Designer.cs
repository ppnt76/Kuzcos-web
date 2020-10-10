namespace WindowsFormsApp1
{
    partial class FormModificar
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
            this.lCodigo = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.bEditar = new System.Windows.Forms.Button();
            this.dGVModificar = new System.Windows.Forms.DataGridView();
            this.cBMarca = new System.Windows.Forms.ComboBox();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.tBImagen = new System.Windows.Forms.TextBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lImagen = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(631, 300);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(150, 50);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(631, 374);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(150, 50);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.ForeColor = System.Drawing.Color.White;
            this.lCodigo.Location = new System.Drawing.Point(49, 31);
            this.lCodigo.MaximumSize = new System.Drawing.Size(200, 24);
            this.lCodigo.MinimumSize = new System.Drawing.Size(150, 24);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(176, 24);
            this.lCodigo.TabIndex = 2;
            this.lCodigo.Text = "Ingrese el Codigo";
            // 
            // tBuscar
            // 
            this.tBuscar.Location = new System.Drawing.Point(242, 35);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(300, 20);
            this.tBuscar.TabIndex = 3;
            this.tBuscar.TextChanged += new System.EventHandler(this.tBuscar_TextChanged);
            // 
            // bEditar
            // 
            this.bEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditar.Location = new System.Drawing.Point(579, 25);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(150, 30);
            this.bEditar.TabIndex = 4;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // dGVModificar
            // 
            this.dGVModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModificar.Location = new System.Drawing.Point(12, 67);
            this.dGVModificar.Name = "dGVModificar";
            this.dGVModificar.Size = new System.Drawing.Size(776, 109);
            this.dGVModificar.TabIndex = 5;
            // 
            // cBMarca
            // 
            this.cBMarca.FormattingEnabled = true;
            this.cBMarca.Location = new System.Drawing.Point(153, 279);
            this.cBMarca.Name = "cBMarca";
            this.cBMarca.Size = new System.Drawing.Size(300, 21);
            this.cBMarca.TabIndex = 6;
            // 
            // cBCategoria
            // 
            this.cBCategoria.FormattingEnabled = true;
            this.cBCategoria.Location = new System.Drawing.Point(153, 306);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(300, 21);
            this.cBCategoria.TabIndex = 7;
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(153, 189);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(300, 20);
            this.tCodigo.TabIndex = 8;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(153, 216);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(300, 20);
            this.tBNombre.TabIndex = 9;
            // 
            // tBDesc
            // 
            this.tBDesc.Location = new System.Drawing.Point(153, 250);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(300, 20);
            this.tBDesc.TabIndex = 10;
            // 
            // tBImagen
            // 
            this.tBImagen.Location = new System.Drawing.Point(153, 338);
            this.tBImagen.Name = "tBImagen";
            this.tBImagen.Size = new System.Drawing.Size(300, 20);
            this.tBImagen.TabIndex = 11;
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(153, 369);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(300, 20);
            this.tBPrecio.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 185);
            this.label1.MaximumSize = new System.Drawing.Size(130, 24);
            this.label1.MinimumSize = new System.Drawing.Size(130, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.Transparent;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(22, 212);
            this.lNombre.MaximumSize = new System.Drawing.Size(130, 24);
            this.lNombre.MinimumSize = new System.Drawing.Size(130, 24);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(130, 24);
            this.lNombre.TabIndex = 14;
            this.lNombre.Text = "Nombre";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.BackColor = System.Drawing.Color.Transparent;
            this.lDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.ForeColor = System.Drawing.Color.White;
            this.lDesc.Location = new System.Drawing.Point(22, 246);
            this.lDesc.MaximumSize = new System.Drawing.Size(130, 24);
            this.lDesc.MinimumSize = new System.Drawing.Size(130, 24);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(130, 24);
            this.lDesc.TabIndex = 15;
            this.lDesc.Text = "Descripcion";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.BackColor = System.Drawing.Color.Transparent;
            this.lMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarca.ForeColor = System.Drawing.Color.White;
            this.lMarca.Location = new System.Drawing.Point(22, 276);
            this.lMarca.MaximumSize = new System.Drawing.Size(130, 24);
            this.lMarca.MinimumSize = new System.Drawing.Size(130, 24);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(130, 24);
            this.lMarca.TabIndex = 16;
            this.lMarca.Text = "Marca";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategoria.ForeColor = System.Drawing.Color.White;
            this.lCategoria.Location = new System.Drawing.Point(22, 303);
            this.lCategoria.MaximumSize = new System.Drawing.Size(130, 24);
            this.lCategoria.MinimumSize = new System.Drawing.Size(130, 24);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(130, 24);
            this.lCategoria.TabIndex = 17;
            this.lCategoria.Text = "Categoria";
            // 
            // lImagen
            // 
            this.lImagen.AutoSize = true;
            this.lImagen.BackColor = System.Drawing.Color.Transparent;
            this.lImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lImagen.ForeColor = System.Drawing.Color.White;
            this.lImagen.Location = new System.Drawing.Point(22, 334);
            this.lImagen.MaximumSize = new System.Drawing.Size(130, 24);
            this.lImagen.MinimumSize = new System.Drawing.Size(130, 24);
            this.lImagen.Name = "lImagen";
            this.lImagen.Size = new System.Drawing.Size(130, 24);
            this.lImagen.TabIndex = 18;
            this.lImagen.Text = "Imagen";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.White;
            this.lPrecio.Location = new System.Drawing.Point(22, 365);
            this.lPrecio.MaximumSize = new System.Drawing.Size(130, 24);
            this.lPrecio.MinimumSize = new System.Drawing.Size(130, 24);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(130, 24);
            this.lPrecio.TabIndex = 19;
            this.lPrecio.Text = "Precio";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(155, 408);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(69, 20);
            this.tbxId.TabIndex = 20;
            this.tbxId.Visible = false;
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lImagen);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPrecio);
            this.Controls.Add(this.tBImagen);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.cBCategoria);
            this.Controls.Add(this.cBMarca);
            this.Controls.Add(this.dGVModificar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.lCodigo);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormModificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.DataGridView dGVModificar;
        private System.Windows.Forms.ComboBox cBMarca;
        private System.Windows.Forms.ComboBox cBCategoria;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.TextBox tBImagen;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lImagen;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tbxId;
    }
}