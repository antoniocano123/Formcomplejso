namespace Formcomplejso
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
            this.txtbcomplejo1 = new System.Windows.Forms.TextBox();
            this.txtbcomplejo2 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lboperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultComplejo = new System.Windows.Forms.Label();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbcomplejo1
            // 
            this.txtbcomplejo1.Location = new System.Drawing.Point(90, 98);
            this.txtbcomplejo1.Name = "txtbcomplejo1";
            this.txtbcomplejo1.Size = new System.Drawing.Size(114, 20);
            this.txtbcomplejo1.TabIndex = 0;
            // 
            // txtbcomplejo2
            // 
            this.txtbcomplejo2.Location = new System.Drawing.Point(260, 98);
            this.txtbcomplejo2.Name = "txtbcomplejo2";
            this.txtbcomplejo2.Size = new System.Drawing.Size(116, 20);
            this.txtbcomplejo2.TabIndex = 1;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(28, 155);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(155, 64);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Suma";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            this.btnSumar.MouseHover += new System.EventHandler(this.btnSuma_MouseHover);
            // 
            // lboperador
            // 
            this.lboperador.AutoSize = true;
            this.lboperador.Location = new System.Drawing.Point(222, 101);
            this.lboperador.Name = "lboperador";
            this.lboperador.Size = new System.Drawing.Size(13, 13);
            this.lboperador.TabIndex = 3;
            this.lboperador.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // lbResultComplejo
            // 
            this.lbResultComplejo.AutoSize = true;
            this.lbResultComplejo.Location = new System.Drawing.Point(463, 100);
            this.lbResultComplejo.Name = "lbResultComplejo";
            this.lbResultComplejo.Size = new System.Drawing.Size(27, 13);
            this.lbResultComplejo.TabIndex = 5;
            this.lbResultComplejo.Text = "0+0i";
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(225, 152);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(155, 67);
            this.btnRestar.TabIndex = 6;
            this.btnRestar.Text = "Resta";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            this.btnRestar.MouseHover += new System.EventHandler(this.btnRestar_MouseHover);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(401, 159);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(155, 60);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "Multiplicacion";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            this.btnMultiplicar.MouseHover += new System.EventHandler(this.btnMultiplicar_MouseHover);
            // 
            // btnConjugar
            // 
            this.btnConjugar.Location = new System.Drawing.Point(583, 156);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(155, 63);
            this.btnConjugar.TabIndex = 8;
            this.btnConjugar.Text = "Conjugar";
            this.btnConjugar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.lbResultComplejo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboperador);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtbcomplejo2);
            this.Controls.Add(this.txtbcomplejo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbcomplejo1;
        private System.Windows.Forms.TextBox txtbcomplejo2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lboperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultComplejo;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnConjugar;
    }
}

