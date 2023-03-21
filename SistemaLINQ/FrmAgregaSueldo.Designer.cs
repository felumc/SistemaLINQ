namespace SistemaLINQ
{
    partial class FrmAgregaSueldo
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
            this.cmbIdPuesto = new System.Windows.Forms.ComboBox();
            this.cmbIdTrabajador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbIdPuesto
            // 
            this.cmbIdPuesto.FormattingEnabled = true;
            this.cmbIdPuesto.Location = new System.Drawing.Point(234, 103);
            this.cmbIdPuesto.Name = "cmbIdPuesto";
            this.cmbIdPuesto.Size = new System.Drawing.Size(323, 24);
            this.cmbIdPuesto.TabIndex = 38;
            // 
            // cmbIdTrabajador
            // 
            this.cmbIdTrabajador.FormattingEnabled = true;
            this.cmbIdTrabajador.Location = new System.Drawing.Point(234, 45);
            this.cmbIdTrabajador.Name = "cmbIdTrabajador";
            this.cmbIdTrabajador.Size = new System.Drawing.Size(323, 24);
            this.cmbIdTrabajador.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID Trabajador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "ID Puesto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(442, 225);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(251, 225);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 44);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 44);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(234, 164);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(323, 22);
            this.txtSueldo.TabIndex = 40;
            // 
            // FrmAgregaSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 311);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdPuesto);
            this.Controls.Add(this.cmbIdTrabajador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmAgregaSueldo";
            this.Text = "FrmAgregaSueldo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAgregaSueldo_FormClosed);
            this.Load += new System.EventHandler(this.FrmAgregaSueldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdPuesto;
        private System.Windows.Forms.ComboBox cmbIdTrabajador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldo;
    }
}