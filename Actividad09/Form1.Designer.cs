namespace Actividad09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Definición de los controles
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTemperaturaC;
        private System.Windows.Forms.TextBox txtTemperaturaF;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTemperaturaC;
        private System.Windows.Forms.Label lblTemperaturaF;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;

        // Función de disposición de los componentes
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método de inicialización del formulario y los controles
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTemperaturaC = new System.Windows.Forms.TextBox();
            this.txtTemperaturaF = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTemperaturaC = new System.Windows.Forms.Label();
            this.lblTemperaturaF = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(350, 98);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtTemperaturaC
            // 
            this.txtTemperaturaC.Location = new System.Drawing.Point(410, 148);
            this.txtTemperaturaC.Name = "txtTemperaturaC";
            this.txtTemperaturaC.Size = new System.Drawing.Size(100, 31);
            this.txtTemperaturaC.TabIndex = 1;
            // 
            // txtTemperaturaF
            // 
            this.txtTemperaturaF.Location = new System.Drawing.Point(410, 188);
            this.txtTemperaturaF.Name = "txtTemperaturaF";
            this.txtTemperaturaF.Size = new System.Drawing.Size(100, 31);
            this.txtTemperaturaF.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(350, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTemperaturaC
            // 
            this.lblTemperaturaC.AutoSize = true;
            this.lblTemperaturaC.Location = new System.Drawing.Point(250, 148);
            this.lblTemperaturaC.Name = "lblTemperaturaC";
            this.lblTemperaturaC.Size = new System.Drawing.Size(169, 25);
            this.lblTemperaturaC.TabIndex = 4;
            this.lblTemperaturaC.Text = "Temperatura °C:";
            // 
            // lblTemperaturaF
            // 
            this.lblTemperaturaF.AutoSize = true;
            this.lblTemperaturaF.Location = new System.Drawing.Point(250, 188);
            this.lblTemperaturaF.Name = "lblTemperaturaF";
            this.lblTemperaturaF.Size = new System.Drawing.Size(167, 25);
            this.lblTemperaturaF.TabIndex = 5;
            this.lblTemperaturaF.Text = "Temperatura °F:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(250, 98);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 25);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(350, 228);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(160, 31);
            this.txtFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(250, 228);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 25);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(876, 543);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTemperaturaF);
            this.Controls.Add(this.lblTemperaturaC);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTemperaturaF);
            this.Controls.Add(this.txtTemperaturaC);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Text = "Registro de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
