namespace Presentacion
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
            this.tbcPeliculas = new System.Windows.Forms.TabControl();
            this.tbcRegistrar = new System.Windows.Forms.TabPage();
            this.dtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnRegistrarF = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcListar = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.tbcVender = new System.Windows.Forms.TabPage();
            this.txtCodA = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkFuncion = new System.Windows.Forms.CheckBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.tbcPeliculas.SuspendLayout();
            this.tbcRegistrar.SuspendLayout();
            this.tbcListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.tbcVender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPeliculas
            // 
            this.tbcPeliculas.Controls.Add(this.tbcRegistrar);
            this.tbcPeliculas.Controls.Add(this.tbcListar);
            this.tbcPeliculas.Controls.Add(this.tbcVender);
            this.tbcPeliculas.Location = new System.Drawing.Point(12, 12);
            this.tbcPeliculas.Name = "tbcPeliculas";
            this.tbcPeliculas.SelectedIndex = 0;
            this.tbcPeliculas.Size = new System.Drawing.Size(756, 426);
            this.tbcPeliculas.TabIndex = 0;
            // 
            // tbcRegistrar
            // 
            this.tbcRegistrar.Controls.Add(this.btnBuscarP);
            this.tbcRegistrar.Controls.Add(this.chkFuncion);
            this.tbcRegistrar.Controls.Add(this.dtpFechaF);
            this.tbcRegistrar.Controls.Add(this.txtGenero);
            this.tbcRegistrar.Controls.Add(this.txtDuracion);
            this.tbcRegistrar.Controls.Add(this.txtNom);
            this.tbcRegistrar.Controls.Add(this.txtCod);
            this.tbcRegistrar.Controls.Add(this.btnRegistrarF);
            this.tbcRegistrar.Controls.Add(this.btnRegistar);
            this.tbcRegistrar.Controls.Add(this.label7);
            this.tbcRegistrar.Controls.Add(this.label6);
            this.tbcRegistrar.Controls.Add(this.label5);
            this.tbcRegistrar.Controls.Add(this.label4);
            this.tbcRegistrar.Controls.Add(this.label3);
            this.tbcRegistrar.Controls.Add(this.label2);
            this.tbcRegistrar.Controls.Add(this.label1);
            this.tbcRegistrar.Location = new System.Drawing.Point(4, 25);
            this.tbcRegistrar.Name = "tbcRegistrar";
            this.tbcRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbcRegistrar.Size = new System.Drawing.Size(748, 397);
            this.tbcRegistrar.TabIndex = 0;
            this.tbcRegistrar.Text = "Registrar";
            this.tbcRegistrar.UseVisualStyleBackColor = true;
            this.tbcRegistrar.Click += new System.EventHandler(this.tbcRegistrar_Click);
            // 
            // dtpFechaF
            // 
            this.dtpFechaF.Location = new System.Drawing.Point(534, 164);
            this.dtpFechaF.Name = "dtpFechaF";
            this.dtpFechaF.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaF.TabIndex = 19;
            this.dtpFechaF.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(119, 272);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(176, 22);
            this.txtGenero.TabIndex = 15;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(119, 221);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(176, 22);
            this.txtDuracion.TabIndex = 14;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(119, 159);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 22);
            this.txtNom.TabIndex = 13;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(119, 110);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(176, 22);
            this.txtCod.TabIndex = 12;
            // 
            // btnRegistrarF
            // 
            this.btnRegistrarF.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarF.Location = new System.Drawing.Point(435, 325);
            this.btnRegistrarF.Name = "btnRegistrarF";
            this.btnRegistrarF.Size = new System.Drawing.Size(147, 48);
            this.btnRegistrarF.TabIndex = 11;
            this.btnRegistrarF.Text = "Registrar Función";
            this.btnRegistrarF.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(21, 325);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(147, 48);
            this.btnRegistar.TabIndex = 10;
            this.btnRegistar.Text = "Registrar Pelicula";
            this.btnRegistar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha / Hora :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(376, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registrar Función";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registrar Pelicula ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duración :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Género :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código :";
            // 
            // tbcListar
            // 
            this.tbcListar.Controls.Add(this.btnListar);
            this.tbcListar.Controls.Add(this.dgvListar);
            this.tbcListar.Location = new System.Drawing.Point(4, 25);
            this.tbcListar.Name = "tbcListar";
            this.tbcListar.Padding = new System.Windows.Forms.Padding(3);
            this.tbcListar.Size = new System.Drawing.Size(748, 397);
            this.tbcListar.TabIndex = 1;
            this.tbcListar.Text = "Listar";
            this.tbcListar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(333, 349);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 42);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(21, 27);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.RowHeadersWidth = 51;
            this.dgvListar.RowTemplate.Height = 24;
            this.dgvListar.Size = new System.Drawing.Size(705, 304);
            this.dgvListar.TabIndex = 0;
            // 
            // tbcVender
            // 
            this.tbcVender.Controls.Add(this.txtCodA);
            this.tbcVender.Controls.Add(this.btnBuscar);
            this.tbcVender.Controls.Add(this.label12);
            this.tbcVender.Controls.Add(this.label16);
            this.tbcVender.Location = new System.Drawing.Point(4, 25);
            this.tbcVender.Name = "tbcVender";
            this.tbcVender.Size = new System.Drawing.Size(748, 397);
            this.tbcVender.TabIndex = 2;
            this.tbcVender.Text = "Vender";
            this.tbcVender.UseVisualStyleBackColor = true;
            // 
            // txtCodA
            // 
            this.txtCodA.Location = new System.Drawing.Point(126, 50);
            this.txtCodA.Name = "txtCodA";
            this.txtCodA.Size = new System.Drawing.Size(176, 22);
            this.txtCodA.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(79, 318);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 48);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar Pelicula";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(14, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 30);
            this.label12.TabIndex = 22;
            this.label12.Text = "Buscar Función";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Código :";
            // 
            // chkFuncion
            // 
            this.chkFuncion.AutoSize = true;
            this.chkFuncion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFuncion.Location = new System.Drawing.Point(380, 112);
            this.chkFuncion.Name = "chkFuncion";
            this.chkFuncion.Size = new System.Drawing.Size(219, 21);
            this.chkFuncion.TabIndex = 20;
            this.chkFuncion.Text = "Registrar una función";
            this.chkFuncion.UseVisualStyleBackColor = true;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarP.Location = new System.Drawing.Point(188, 325);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(147, 48);
            this.btnBuscarP.TabIndex = 21;
            this.btnBuscarP.Text = "Buscar Pelicula";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcPeliculas);
            this.Name = "Form1";
            this.Text = "Cine Don Chucho";
            this.tbcPeliculas.ResumeLayout(false);
            this.tbcRegistrar.ResumeLayout(false);
            this.tbcRegistrar.PerformLayout();
            this.tbcListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.tbcVender.ResumeLayout(false);
            this.tbcVender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPeliculas;
        private System.Windows.Forms.TabPage tbcRegistrar;
        private System.Windows.Forms.TabPage tbcListar;
        private System.Windows.Forms.TabPage tbcVender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarF;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtCodA;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFuncion;
        private System.Windows.Forms.Button btnBuscarP;
    }
}

