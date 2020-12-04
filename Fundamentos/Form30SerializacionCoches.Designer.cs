
namespace Fundamentos
{
    partial class Form30SerializacionCoches
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCoches = new System.Windows.Forms.ListBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargarCoches = new System.Windows.Forms.Button();
            this.btnCargarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARCA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "MODELO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coches";
            // 
            // lstCoches
            // 
            this.lstCoches.FormattingEnabled = true;
            this.lstCoches.ItemHeight = 25;
            this.lstCoches.Location = new System.Drawing.Point(568, 78);
            this.lstCoches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCoches.Name = "lstCoches";
            this.lstCoches.Size = new System.Drawing.Size(394, 554);
            this.lstCoches.TabIndex = 4;
            this.lstCoches.SelectedIndexChanged += new System.EventHandler(this.lstCoches_SelectedIndexChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(20, 84);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(268, 30);
            this.txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(20, 184);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(268, 30);
            this.txtModelo.TabIndex = 6;
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(18, 284);
            this.ptbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(400, 283);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 7;
            this.ptbImagen.TabStop = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(315, 56);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(202, 59);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar Coche";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(315, 128);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 59);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar Coches";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargarCoches
            // 
            this.btnCargarCoches.Location = new System.Drawing.Point(315, 205);
            this.btnCargarCoches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarCoches.Name = "btnCargarCoches";
            this.btnCargarCoches.Size = new System.Drawing.Size(202, 59);
            this.btnCargarCoches.TabIndex = 11;
            this.btnCargarCoches.Text = "Cargar Coches";
            this.btnCargarCoches.UseVisualStyleBackColor = true;
            this.btnCargarCoches.Click += new System.EventHandler(this.btnCargarCoches_Click);
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.Location = new System.Drawing.Point(18, 578);
            this.btnCargarImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(400, 56);
            this.btnCargarImg.TabIndex = 12;
            this.btnCargarImg.Text = "Cargar Imagen";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // Form30SerializacionCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 678);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.btnCargarCoches);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lstCoches);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form30SerializacionCoches";
            this.Text = "Form30SerializacionCoches";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCoches;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargarCoches;
        private System.Windows.Forms.Button btnCargarImg;
    }
}