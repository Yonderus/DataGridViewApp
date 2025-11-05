namespace DataGridView
{
    partial class FormularioIngersos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioIngersos));
            this.menuStripAcciones = new System.Windows.Forms.MenuStrip();
            this.accionsMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saberMásMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSAcciones = new System.Windows.Forms.ToolStrip();
            this.TLSagregar = new System.Windows.Forms.ToolStripButton();
            this.TLSeditar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbEditarIngresoFI = new System.Windows.Forms.Button();
            this.btEliminarIngreso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtAlta = new System.Windows.Forms.DateTimePicker();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.btbAgregarIngreso = new System.Windows.Forms.Button();
            this.tbHabitacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.lblIngresosTitulo = new System.Windows.Forms.Label();
            this.TLSeliminar = new System.Windows.Forms.ToolStripButton();
            this.menuStripAcciones.SuspendLayout();
            this.TLSAcciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripAcciones
            // 
            this.menuStripAcciones.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStripAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionsMNU,
            this.saberMásMNU});
            this.menuStripAcciones.Location = new System.Drawing.Point(0, 0);
            this.menuStripAcciones.Name = "menuStripAcciones";
            this.menuStripAcciones.Size = new System.Drawing.Size(1015, 28);
            this.menuStripAcciones.TabIndex = 1;
            this.menuStripAcciones.Text = "menuStrip1";
            // 
            // accionsMNU
            // 
            this.accionsMNU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.accionsMNU.Name = "accionsMNU";
            this.accionsMNU.Size = new System.Drawing.Size(82, 24);
            this.accionsMNU.Text = "Acciones";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // saberMásMNU
            // 
            this.saberMásMNU.Name = "saberMásMNU";
            this.saberMásMNU.Size = new System.Drawing.Size(92, 24);
            this.saberMásMNU.Text = "Saber más";
            // 
            // TLSAcciones
            // 
            this.TLSAcciones.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TLSAcciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TLSAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLSagregar,
            this.TLSeditar,
            this.TLSeliminar});
            this.TLSAcciones.Location = new System.Drawing.Point(0, 28);
            this.TLSAcciones.Name = "TLSAcciones";
            this.TLSAcciones.Size = new System.Drawing.Size(1015, 27);
            this.TLSAcciones.TabIndex = 2;
            this.TLSAcciones.Text = "toolStrip1";
            // 
            // TLSagregar
            // 
            this.TLSagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TLSagregar.Image = ((System.Drawing.Image)(resources.GetObject("TLSagregar.Image")));
            this.TLSagregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TLSagregar.Name = "TLSagregar";
            this.TLSagregar.Size = new System.Drawing.Size(29, 24);
            this.TLSagregar.Text = "toolStripButtonAgregar";
            // 
            // TLSeditar
            // 
            this.TLSeditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TLSeditar.Image = ((System.Drawing.Image)(resources.GetObject("TLSeditar.Image")));
            this.TLSeditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TLSeditar.Name = "TLSeditar";
            this.TLSeditar.Size = new System.Drawing.Size(29, 24);
            this.TLSeditar.Text = "toolStripButtonEditar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btbEditarIngresoFI);
            this.panel1.Controls.Add(this.btEliminarIngreso);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvIngresos);
            this.panel1.Location = new System.Drawing.Point(33, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 705);
            this.panel1.TabIndex = 3;
            // 
            // btbEditarIngresoFI
            // 
            this.btbEditarIngresoFI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btbEditarIngresoFI.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbEditarIngresoFI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btbEditarIngresoFI.Location = new System.Drawing.Point(81, 372);
            this.btbEditarIngresoFI.Name = "btbEditarIngresoFI";
            this.btbEditarIngresoFI.Size = new System.Drawing.Size(331, 41);
            this.btbEditarIngresoFI.TabIndex = 8;
            this.btbEditarIngresoFI.Text = "Editar Ingreso";
            this.btbEditarIngresoFI.UseVisualStyleBackColor = false;
            this.btbEditarIngresoFI.Click += new System.EventHandler(this.btbEditarIngresoFI_Click);
            // 
            // btEliminarIngreso
            // 
            this.btEliminarIngreso.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btEliminarIngreso.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarIngreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btEliminarIngreso.Location = new System.Drawing.Point(523, 372);
            this.btEliminarIngreso.Name = "btEliminarIngreso";
            this.btEliminarIngreso.Size = new System.Drawing.Size(331, 41);
            this.btEliminarIngreso.TabIndex = 7;
            this.btEliminarIngreso.Text = "Eliminar Ingreso";
            this.btEliminarIngreso.UseVisualStyleBackColor = false;
            this.btEliminarIngreso.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtAlta);
            this.groupBox1.Controls.Add(this.dtIngreso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbEspecialidad);
            this.groupBox1.Controls.Add(this.btbAgregarIngreso);
            this.groupBox1.Controls.Add(this.tbHabitacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMotivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 221);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Ingreso";
            // 
            // dtAlta
            // 
            this.dtAlta.Location = new System.Drawing.Point(322, 72);
            this.dtAlta.Name = "dtAlta";
            this.dtAlta.Size = new System.Drawing.Size(245, 27);
            this.dtAlta.TabIndex = 12;
            this.dtAlta.ValueChanged += new System.EventHandler(this.dtAlta_ValueChanged);
            // 
            // dtIngreso
            // 
            this.dtIngreso.Location = new System.Drawing.Point(19, 72);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(232, 27);
            this.dtIngreso.TabIndex = 11;
            this.dtIngreso.ValueChanged += new System.EventHandler(this.dtIngreso_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Especialidad:";
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Location = new System.Drawing.Point(637, 72);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(245, 27);
            this.tbEspecialidad.TabIndex = 9;
            this.tbEspecialidad.TextChanged += new System.EventHandler(this.tbEspecialidad_TextChanged);
            // 
            // btbAgregarIngreso
            // 
            this.btbAgregarIngreso.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btbAgregarIngreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btbAgregarIngreso.Location = new System.Drawing.Point(675, 130);
            this.btbAgregarIngreso.Name = "btbAgregarIngreso";
            this.btbAgregarIngreso.Size = new System.Drawing.Size(175, 66);
            this.btbAgregarIngreso.TabIndex = 8;
            this.btbAgregarIngreso.Text = "Agregar Ingreso";
            this.btbAgregarIngreso.UseVisualStyleBackColor = false;
            this.btbAgregarIngreso.Click += new System.EventHandler(this.btbAgregarIngreso_Click);
            // 
            // tbHabitacion
            // 
            this.tbHabitacion.Location = new System.Drawing.Point(322, 169);
            this.tbHabitacion.Name = "tbHabitacion";
            this.tbHabitacion.Size = new System.Drawing.Size(245, 27);
            this.tbHabitacion.TabIndex = 7;
            this.tbHabitacion.TextChanged += new System.EventHandler(this.tbHabitacion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº Habitación:";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(19, 168);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(232, 27);
            this.tbMotivo.TabIndex = 5;
            this.tbMotivo.TextChanged += new System.EventHandler(this.tbMotivo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Alta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Ingreso:";
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Location = new System.Drawing.Point(19, 18);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.RowHeadersWidth = 51;
            this.dgvIngresos.RowTemplate.Height = 24;
            this.dgvIngresos.Size = new System.Drawing.Size(907, 323);
            this.dgvIngresos.TabIndex = 5;
            this.dgvIngresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresos_CellContentClick);
            // 
            // lblIngresosTitulo
            // 
            this.lblIngresosTitulo.AutoSize = true;
            this.lblIngresosTitulo.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosTitulo.Location = new System.Drawing.Point(27, 87);
            this.lblIngresosTitulo.Name = "lblIngresosTitulo";
            this.lblIngresosTitulo.Size = new System.Drawing.Size(663, 33);
            this.lblIngresosTitulo.TabIndex = 4;
            this.lblIngresosTitulo.Text = "Bienvenido al formulario de Ingresos";
            // 
            // TLSeliminar
            // 
            this.TLSeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TLSeliminar.Image = ((System.Drawing.Image)(resources.GetObject("TLSeliminar.Image")));
            this.TLSeliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TLSeliminar.Name = "TLSeliminar";
            this.TLSeliminar.Size = new System.Drawing.Size(29, 24);
            this.TLSeliminar.Text = "toolStripButtonEliminar";
            // 
            // FormularioIngersos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 863);
            this.Controls.Add(this.lblIngresosTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TLSAcciones);
            this.Controls.Add(this.menuStripAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormularioIngersos";
            this.Text = "FormularioIngersos";
            this.menuStripAcciones.ResumeLayout(false);
            this.menuStripAcciones.PerformLayout();
            this.TLSAcciones.ResumeLayout(false);
            this.TLSAcciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAcciones;
        private System.Windows.Forms.ToolStripMenuItem accionsMNU;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saberMásMNU;
        private System.Windows.Forms.ToolStrip TLSAcciones;
        private System.Windows.Forms.ToolStripButton TLSagregar;
        private System.Windows.Forms.ToolStripButton TLSeditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresosTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.TextBox tbHabitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbAgregarIngreso;
        private System.Windows.Forms.Button btEliminarIngreso;
        private System.Windows.Forms.Button btbEditarIngresoFI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.DateTimePicker dtAlta;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.ToolStripButton TLSeliminar;
    }
}