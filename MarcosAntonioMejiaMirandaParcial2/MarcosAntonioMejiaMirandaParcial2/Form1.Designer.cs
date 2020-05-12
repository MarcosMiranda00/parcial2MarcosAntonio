namespace MarcosAntonioMejiaMirandaParcial2
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombreper = new System.Windows.Forms.Label();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(23, 24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(82, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulte su numero de DUI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblNombreper
            // 
            this.lblNombreper.AutoSize = true;
            this.lblNombreper.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreper.Location = new System.Drawing.Point(70, 228);
            this.lblNombreper.Name = "lblNombreper";
            this.lblNombreper.Size = new System.Drawing.Size(156, 15);
            this.lblNombreper.TabIndex = 3;
            this.lblNombreper.Text = "Nombre de la Persona";
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.AutoSize = true;
            this.lblBeneficiario.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiario.Location = new System.Drawing.Point(444, 228);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(283, 15);
            this.lblBeneficiario.TabIndex = 4;
            this.lblBeneficiario.Text = "Eres beneficiario de los $300.00 Dolares";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(295, 169);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 364);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblBeneficiario);
            this.Controls.Add(this.lblNombreper);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreper;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Button btnConsultar;
    }
}

