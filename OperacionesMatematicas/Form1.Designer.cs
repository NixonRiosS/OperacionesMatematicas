namespace OperacionesMatematicas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Sencilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese otro numero:";
            // 
            // txt_numero1
            // 
            this.txt_numero1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero1.Location = new System.Drawing.Point(332, 137);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(168, 33);
            this.txt_numero1.TabIndex = 3;
            this.txt_numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_numero2
            // 
            this.txt_numero2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero2.Location = new System.Drawing.Point(332, 202);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(168, 33);
            this.txt_numero2.TabIndex = 4;
            this.txt_numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sumar
            // 
            this.btn_sumar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sumar.Location = new System.Drawing.Point(107, 273);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(92, 44);
            this.btn_sumar.TabIndex = 5;
            this.btn_sumar.Text = "Sumar";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // btn_restar
            // 
            this.btn_restar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restar.Location = new System.Drawing.Point(252, 273);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(92, 44);
            this.btn_restar.TabIndex = 6;
            this.btn_restar.Text = "Restar";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(376, 273);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(141, 44);
            this.btn_multiplicar.TabIndex = 7;
            this.btn_multiplicar.Text = "Multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(532, 273);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(141, 44);
            this.btn_dividir.TabIndex = 8;
            this.btn_dividir.Text = "Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(558, 130);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(149, 64);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar Cambios";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_resultado.Location = new System.Drawing.Point(122, 359);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(45, 50);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn_sumar);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

