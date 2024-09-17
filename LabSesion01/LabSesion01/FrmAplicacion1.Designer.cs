
namespace LabSesion01
{
    partial class FrmAplicacion1
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldoBasico = new System.Windows.Forms.TextBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.txtNuevoSueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar.ForeColor = System.Drawing.Color.Crimson;
            this.btnRetornar.Location = new System.Drawing.Point(610, 12);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(222, 38);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar Menu";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pago del Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Trabajador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sueldo Basico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aumento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nuevo Sueldo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(222, 226);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(117, 32);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(373, 226);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 32);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(292, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtSueldoBasico
            // 
            this.txtSueldoBasico.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBasico.Location = new System.Drawing.Point(292, 156);
            this.txtSueldoBasico.Name = "txtSueldoBasico";
            this.txtSueldoBasico.Size = new System.Drawing.Size(197, 27);
            this.txtSueldoBasico.TabIndex = 6;
            // 
            // txtAumento
            // 
            this.txtAumento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento.Location = new System.Drawing.Point(292, 276);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(197, 27);
            this.txtAumento.TabIndex = 6;
            // 
            // txtNuevoSueldo
            // 
            this.txtNuevoSueldo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoSueldo.Location = new System.Drawing.Point(292, 327);
            this.txtNuevoSueldo.Name = "txtNuevoSueldo";
            this.txtNuevoSueldo.Size = new System.Drawing.Size(197, 27);
            this.txtNuevoSueldo.TabIndex = 6;
            // 
            // FrmAplicacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 460);
            this.Controls.Add(this.txtNuevoSueldo);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.txtSueldoBasico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetornar);
            this.Name = "FrmAplicacion1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldoBasico;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.TextBox txtNuevoSueldo;
    }
}

