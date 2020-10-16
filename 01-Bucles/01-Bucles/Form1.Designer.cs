namespace _01_Bucles
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
            this.labelr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnumero1 = new System.Windows.Forms.TextBox();
            this.textBoxnumero2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonResto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.Location = new System.Drawing.Point(16, 132);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(77, 13);
            this.labelr.TabIndex = 1;
            this.labelr.Text = "labelResultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "numero1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "numero2";
            // 
            // textBoxnumero1
            // 
            this.textBoxnumero1.Location = new System.Drawing.Point(79, 26);
            this.textBoxnumero1.Name = "textBoxnumero1";
            this.textBoxnumero1.Size = new System.Drawing.Size(110, 20);
            this.textBoxnumero1.TabIndex = 4;
            // 
            // textBoxnumero2
            // 
            this.textBoxnumero2.Location = new System.Drawing.Point(79, 62);
            this.textBoxnumero2.Name = "textBoxnumero2";
            this.textBoxnumero2.Size = new System.Drawing.Size(110, 20);
            this.textBoxnumero2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(429, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 20);
            this.button5.TabIndex = 0;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.Location = new System.Drawing.Point(211, 25);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(102, 20);
            this.buttonSuma.TabIndex = 5;
            this.buttonSuma.Text = "Suma";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Location = new System.Drawing.Point(213, 62);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(99, 19);
            this.buttonResta.TabIndex = 6;
            this.buttonResta.Text = "Resta";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(320, 25);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(102, 21);
            this.buttonMult.TabIndex = 7;
            this.buttonMult.Text = "Multiplicación";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(324, 63);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(97, 19);
            this.buttonDiv.TabIndex = 8;
            this.buttonDiv.Text = "Division";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonResto
            // 
            this.buttonResto.Location = new System.Drawing.Point(429, 25);
            this.buttonResto.Name = "buttonResto";
            this.buttonResto.Size = new System.Drawing.Size(102, 20);
            this.buttonResto.TabIndex = 9;
            this.buttonResto.Text = "Resto";
            this.buttonResto.UseVisualStyleBackColor = true;
            this.buttonResto.Click += new System.EventHandler(this.buttonResto_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 368);
            this.Controls.Add(this.buttonResto);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.textBoxnumero2);
            this.Controls.Add(this.textBoxnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelr);
            this.Controls.Add(this.button5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnumero1;
        private System.Windows.Forms.TextBox textBoxnumero2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonResto;
    }
}

