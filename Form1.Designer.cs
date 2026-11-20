namespace ProyectoFianl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.optEgresoF = new System.Windows.Forms.RadioButton();
            this.optIngresoF = new System.Windows.Forms.RadioButton();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMontos = new System.Windows.Forms.TextBox();
            this.optEgreso = new System.Windows.Forms.RadioButton();
            this.optIngreso = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnVerTodo);
            this.groupBox2.Controls.Add(this.optEgresoF);
            this.groupBox2.Controls.Add(this.optIngresoF);
            this.groupBox2.Controls.Add(this.btnBuscarTipo);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 132);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(11, 84);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(171, 36);
            this.btnVerTodo.TabIndex = 10;
            this.btnVerTodo.Text = "Ver todos";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // optEgresoF
            // 
            this.optEgresoF.AutoSize = true;
            this.optEgresoF.Location = new System.Drawing.Point(78, 19);
            this.optEgresoF.Name = "optEgresoF";
            this.optEgresoF.Size = new System.Drawing.Size(58, 17);
            this.optEgresoF.TabIndex = 4;
            this.optEgresoF.TabStop = true;
            this.optEgresoF.Text = "Egreso";
            this.optEgresoF.UseVisualStyleBackColor = true;
            // 
            // optIngresoF
            // 
            this.optIngresoF.AutoSize = true;
            this.optIngresoF.Location = new System.Drawing.Point(12, 19);
            this.optIngresoF.Name = "optIngresoF";
            this.optIngresoF.Size = new System.Drawing.Size(60, 17);
            this.optIngresoF.TabIndex = 3;
            this.optIngresoF.TabStop = true;
            this.optIngresoF.Text = "Ingreso";
            this.optIngresoF.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Location = new System.Drawing.Point(11, 42);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(171, 36);
            this.btnBuscarTipo.TabIndex = 0;
            this.btnBuscarTipo.Text = "Buscar por tipo";
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtMontos);
            this.groupBox1.Controls.Add(this.optEgreso);
            this.groupBox1.Controls.Add(this.optIngreso);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 217);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar movimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtMontos
            // 
            this.txtMontos.Location = new System.Drawing.Point(13, 24);
            this.txtMontos.Name = "txtMontos";
            this.txtMontos.Size = new System.Drawing.Size(86, 20);
            this.txtMontos.TabIndex = 5;
            this.txtMontos.TextChanged += new System.EventHandler(this.txtMontos_TextChanged);
            // 
            // optEgreso
            // 
            this.optEgreso.AutoSize = true;
            this.optEgreso.Location = new System.Drawing.Point(13, 122);
            this.optEgreso.Name = "optEgreso";
            this.optEgreso.Size = new System.Drawing.Size(58, 17);
            this.optEgreso.TabIndex = 4;
            this.optEgreso.TabStop = true;
            this.optEgreso.Text = "Egreso";
            this.optEgreso.UseVisualStyleBackColor = true;
            // 
            // optIngreso
            // 
            this.optIngreso.AutoSize = true;
            this.optIngreso.Location = new System.Drawing.Point(13, 99);
            this.optIngreso.Name = "optIngreso";
            this.optIngreso.Size = new System.Drawing.Size(60, 17);
            this.optIngreso.TabIndex = 3;
            this.optIngreso.TabStop = true;
            this.optIngreso.Text = "Ingreso";
            this.optIngreso.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 45);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar movimiento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(211, 12);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(498, 374);
            this.dgvTabla.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTabla);
            this.Name = "Form1";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.RadioButton optEgresoF;
        private System.Windows.Forms.RadioButton optIngresoF;
        private System.Windows.Forms.Button btnBuscarTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optEgreso;
        private System.Windows.Forms.RadioButton optIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMontos;
    }
}

