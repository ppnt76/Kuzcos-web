namespace WindowsFormsApp1
{
    partial class FormDetalle
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
            this.dGVDetalle = new System.Windows.Forms.DataGridView();
            this.bDetalle = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.pBArticulo = new System.Windows.Forms.PictureBox();
            this.lDesc = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.tBMarca = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDetalle
            // 
            this.dGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDetalle.Location = new System.Drawing.Point(33, 23);
            this.dGVDetalle.Name = "dGVDetalle";
            this.dGVDetalle.Size = new System.Drawing.Size(755, 150);
            this.dGVDetalle.TabIndex = 0;
            this.dGVDetalle.SelectionChanged += new System.EventHandler(this.dGVDetalle_SelectionChanged);
            // 
            // bDetalle
            // 
            this.bDetalle.Location = new System.Drawing.Point(9, 23);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.Size = new System.Drawing.Size(18, 150);
            this.bDetalle.TabIndex = 1;
            this.bDetalle.Text = "Detall e";
            this.bDetalle.UseVisualStyleBackColor = true;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.Transparent;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(12, 196);
            this.lNombre.MaximumSize = new System.Drawing.Size(130, 24);
            this.lNombre.MinimumSize = new System.Drawing.Size(130, 24);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(130, 24);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre";
            // 
            // pBArticulo
            // 
            this.pBArticulo.BackColor = System.Drawing.Color.Transparent;
            this.pBArticulo.Location = new System.Drawing.Point(419, 179);
            this.pBArticulo.Name = "pBArticulo";
            this.pBArticulo.Size = new System.Drawing.Size(369, 246);
            this.pBArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBArticulo.TabIndex = 3;
            this.pBArticulo.TabStop = false;
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.BackColor = System.Drawing.Color.Transparent;
            this.lDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.ForeColor = System.Drawing.Color.White;
            this.lDesc.Location = new System.Drawing.Point(12, 241);
            this.lDesc.MaximumSize = new System.Drawing.Size(130, 24);
            this.lDesc.MinimumSize = new System.Drawing.Size(130, 24);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(130, 24);
            this.lDesc.TabIndex = 4;
            this.lDesc.Text = "Descripcion";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.BackColor = System.Drawing.Color.Transparent;
            this.lMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMarca.ForeColor = System.Drawing.Color.Transparent;
            this.lMarca.Location = new System.Drawing.Point(12, 282);
            this.lMarca.MaximumSize = new System.Drawing.Size(130, 24);
            this.lMarca.MinimumSize = new System.Drawing.Size(130, 24);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(130, 24);
            this.lMarca.TabIndex = 5;
            this.lMarca.Text = "Marca";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.White;
            this.lPrecio.Location = new System.Drawing.Point(13, 323);
            this.lPrecio.MaximumSize = new System.Drawing.Size(130, 24);
            this.lPrecio.MinimumSize = new System.Drawing.Size(130, 24);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(130, 24);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio";
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(141, 200);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(250, 20);
            this.tBNombre.TabIndex = 7;
            // 
            // tBDesc
            // 
            this.tBDesc.Location = new System.Drawing.Point(141, 241);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(250, 20);
            this.tBDesc.TabIndex = 8;
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(141, 323);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(250, 20);
            this.tBPrecio.TabIndex = 9;
            // 
            // tBMarca
            // 
            this.tBMarca.Location = new System.Drawing.Point(141, 282);
            this.tBMarca.Name = "tBMarca";
            this.tBMarca.Size = new System.Drawing.Size(250, 20);
            this.tBMarca.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(177, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tBMarca);
            this.Controls.Add(this.tBPrecio);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.pBArticulo);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.dGVDetalle);
            this.Name = "FormDetalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDetalle;
        private System.Windows.Forms.Button bDetalle;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.PictureBox pBArticulo;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.TextBox tBMarca;
        private System.Windows.Forms.Button btnSalir;
    }
}