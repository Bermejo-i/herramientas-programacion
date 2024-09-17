
namespace LabSesion01
{
    partial class FrmPrincipal
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
            this.btnApp01 = new System.Windows.Forms.Button();
            this.btnApp03 = new System.Windows.Forms.Button();
            this.btnApp02 = new System.Windows.Forms.Button();
            this.btnApp04 = new System.Windows.Forms.Button();
            this.bntFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnApp01
            // 
            this.btnApp01.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp01.ForeColor = System.Drawing.Color.Crimson;
            this.btnApp01.Location = new System.Drawing.Point(62, 90);
            this.btnApp01.Name = "btnApp01";
            this.btnApp01.Size = new System.Drawing.Size(222, 38);
            this.btnApp01.TabIndex = 1;
            this.btnApp01.Text = "Aplicacion01";
            this.btnApp01.UseVisualStyleBackColor = true;
            this.btnApp01.Click += new System.EventHandler(this.btnApp01_Click);
            // 
            // btnApp03
            // 
            this.btnApp03.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp03.ForeColor = System.Drawing.Color.Crimson;
            this.btnApp03.Location = new System.Drawing.Point(62, 178);
            this.btnApp03.Name = "btnApp03";
            this.btnApp03.Size = new System.Drawing.Size(222, 38);
            this.btnApp03.TabIndex = 2;
            this.btnApp03.Text = "Aplicacion03";
            this.btnApp03.UseVisualStyleBackColor = true;
            this.btnApp03.Click += new System.EventHandler(this.btnApp03_Click);
            // 
            // btnApp02
            // 
            this.btnApp02.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp02.ForeColor = System.Drawing.Color.Crimson;
            this.btnApp02.Location = new System.Drawing.Point(62, 134);
            this.btnApp02.Name = "btnApp02";
            this.btnApp02.Size = new System.Drawing.Size(222, 38);
            this.btnApp02.TabIndex = 3;
            this.btnApp02.Text = "Aplicacion02";
            this.btnApp02.UseVisualStyleBackColor = true;
            this.btnApp02.Click += new System.EventHandler(this.btnApp02_Click);
            // 
            // btnApp04
            // 
            this.btnApp04.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp04.ForeColor = System.Drawing.Color.Crimson;
            this.btnApp04.Location = new System.Drawing.Point(62, 222);
            this.btnApp04.Name = "btnApp04";
            this.btnApp04.Size = new System.Drawing.Size(222, 38);
            this.btnApp04.TabIndex = 4;
            this.btnApp04.Text = "Aplicacion04";
            this.btnApp04.UseVisualStyleBackColor = true;
            this.btnApp04.Click += new System.EventHandler(this.btnApp04_Click);
            // 
            // bntFin
            // 
            this.bntFin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFin.ForeColor = System.Drawing.Color.Crimson;
            this.bntFin.Location = new System.Drawing.Point(62, 266);
            this.bntFin.Name = "bntFin";
            this.bntFin.Size = new System.Drawing.Size(222, 38);
            this.bntFin.TabIndex = 4;
            this.bntFin.Text = "Finalizar";
            this.bntFin.UseVisualStyleBackColor = true;
            this.bntFin.Click += new System.EventHandler(this.bntFin_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 364);
            this.Controls.Add(this.bntFin);
            this.Controls.Add(this.btnApp04);
            this.Controls.Add(this.btnApp02);
            this.Controls.Add(this.btnApp03);
            this.Controls.Add(this.btnApp01);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApp01;
        private System.Windows.Forms.Button btnApp03;
        private System.Windows.Forms.Button btnApp02;
        private System.Windows.Forms.Button btnApp04;
        private System.Windows.Forms.Button bntFin;
    }
}