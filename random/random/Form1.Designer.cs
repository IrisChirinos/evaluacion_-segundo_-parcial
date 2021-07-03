
namespace random
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.filas = new System.Windows.Forms.TextBox();
            this.aleatorio = new System.Windows.Forms.ListBox();
            this.ejecutar = new System.Windows.Forms.Button();
            this.columnas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de filas";
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(194, 44);
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(100, 20);
            this.filas.TabIndex = 1;
            // 
            // aleatorio
            // 
            this.aleatorio.FormattingEnabled = true;
            this.aleatorio.Location = new System.Drawing.Point(119, 108);
            this.aleatorio.Name = "aleatorio";
            this.aleatorio.Size = new System.Drawing.Size(120, 95);
            this.aleatorio.TabIndex = 2;
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(145, 209);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(75, 23);
            this.ejecutar.TabIndex = 3;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            this.ejecutar.Click += new System.EventHandler(this.ejecutar_Click);
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(194, 71);
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(100, 20);
            this.columnas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese la cantidad de columnas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 263);
            this.Controls.Add(this.columnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ejecutar);
            this.Controls.Add(this.aleatorio);
            this.Controls.Add(this.filas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "numeros aleatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filas;
        private System.Windows.Forms.ListBox aleatorio;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.TextBox columnas;
        private System.Windows.Forms.Label label2;
    }
}

