namespace Repaso
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnDelegado = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnBorrarDelegado = new System.Windows.Forms.Button();
            this.btnMostrarMensaje = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(89, 116);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(190, 57);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnDelegado
            // 
            this.btnDelegado.Location = new System.Drawing.Point(89, 216);
            this.btnDelegado.Name = "btnDelegado";
            this.btnDelegado.Size = new System.Drawing.Size(176, 69);
            this.btnDelegado.TabIndex = 1;
            this.btnDelegado.Text = "Delegado";
            this.btnDelegado.UseVisualStyleBackColor = true;
            this.btnDelegado.Click += new System.EventHandler(this.btnDelegado_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(385, 29);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(176, 69);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar Delegado";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnBorrarDelegado
            // 
            this.btnBorrarDelegado.Location = new System.Drawing.Point(385, 104);
            this.btnBorrarDelegado.Name = "btnBorrarDelegado";
            this.btnBorrarDelegado.Size = new System.Drawing.Size(176, 69);
            this.btnBorrarDelegado.TabIndex = 3;
            this.btnBorrarDelegado.Text = "Borrar Delegado";
            this.btnBorrarDelegado.UseVisualStyleBackColor = true;
            this.btnBorrarDelegado.Click += new System.EventHandler(this.btnBorrarDelegado_Click);
            // 
            // btnMostrarMensaje
            // 
            this.btnMostrarMensaje.Location = new System.Drawing.Point(491, 314);
            this.btnMostrarMensaje.Name = "btnMostrarMensaje";
            this.btnMostrarMensaje.Size = new System.Drawing.Size(176, 69);
            this.btnMostrarMensaje.TabIndex = 4;
            this.btnMostrarMensaje.Text = "Mostrar Mensaje Delegado";
            this.btnMostrarMensaje.UseVisualStyleBackColor = true;
            this.btnMostrarMensaje.Click += new System.EventHandler(this.btnMostrarMensaje_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Borrar Delegado Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "Asignar Delegado Label";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 69);
            this.button3.TabIndex = 8;
            this.button3.Text = "Asignar Func Anonima";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMostrarMensaje);
            this.Controls.Add(this.btnBorrarDelegado);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnDelegado);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnDelegado;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnBorrarDelegado;
        private System.Windows.Forms.Button btnMostrarMensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

