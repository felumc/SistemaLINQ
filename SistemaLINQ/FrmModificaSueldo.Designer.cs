namespace SistemaLINQ
{
    partial class FrmModificaSueldo
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
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdPuesto = new System.Windows.Forms.ComboBox();
            this.cmbIdTrabajador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSueldos = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(231, 281);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(323, 22);
            this.txtSueldo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sueldo";
            // 
            // cmbIdPuesto
            // 
            this.cmbIdPuesto.FormattingEnabled = true;
            this.cmbIdPuesto.Location = new System.Drawing.Point(231, 220);
            this.cmbIdPuesto.Name = "cmbIdPuesto";
            this.cmbIdPuesto.Size = new System.Drawing.Size(323, 24);
            this.cmbIdPuesto.TabIndex = 47;
            // 
            // cmbIdTrabajador
            // 
            this.cmbIdTrabajador.FormattingEnabled = true;
            this.cmbIdTrabajador.Location = new System.Drawing.Point(231, 162);
            this.cmbIdTrabajador.Name = "cmbIdTrabajador";
            this.cmbIdTrabajador.Size = new System.Drawing.Size(323, 24);
            this.cmbIdTrabajador.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "ID Trabajador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "ID Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Sueldos:";
            // 
            // cmbSueldos
            // 
            this.cmbSueldos.FormattingEnabled = true;
            this.cmbSueldos.Location = new System.Drawing.Point(231, 48);
            this.cmbSueldos.Name = "cmbSueldos";
            this.cmbSueldos.Size = new System.Drawing.Size(323, 24);
            this.cmbSueldos.TabIndex = 50;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(592, 115);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 45);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(592, 261);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 56;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(592, 184);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 44);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(592, 48);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(115, 45);
            this.btnVer.TabIndex = 54;
            this.btnVer.Text = "Ver Datos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // FrmModificaSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 351);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSueldos);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdPuesto);
            this.Controls.Add(this.cmbIdTrabajador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "FrmModificaSueldo";
            this.Text = "FrmModificaSueldo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModificaSueldo_FormClosed);
            this.Load += new System.EventHandler(this.FrmModificaSueldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdPuesto;
        private System.Windows.Forms.ComboBox cmbIdTrabajador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSueldos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVer;
    }
}