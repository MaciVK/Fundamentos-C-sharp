
namespace Fundamentos
{
    partial class Form30SerializarColeccion
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblProducto.Location = new System.Drawing.Point(23, 210);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(127, 20);
            this.lblProducto.TabIndex = 23;
            this.lblProducto.Text = "Producto 0 de 0";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 20;
            this.lstProductos.Location = new System.Drawing.Point(391, 48);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(4);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(254, 184);
            this.lstProductos.TabIndex = 22;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Productos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(203, 191);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 64);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar Productos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(203, 120);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(136, 64);
            this.btnLeer.TabIndex = 19;
            this.btnLeer.Text = "Leer Productos";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(203, 48);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(136, 64);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "Insertar Producto";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(27, 152);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 27);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 27);
            this.txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // Form30SerializarColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 307);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form30SerializarColeccion";
            this.Text = "Form30SerializarColeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}