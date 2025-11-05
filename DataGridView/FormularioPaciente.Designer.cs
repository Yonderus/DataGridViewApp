namespace DataGridView
{
    partial class FormularioPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPaciente));
            this.menuStripAcciones = new System.Windows.Forms.MenuStrip();
            this.accionsMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saberMásMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSAcciones = new System.Windows.Forms.ToolStrip();
            this.TLSagregar = new System.Windows.Forms.ToolStripButton();
            this.TLSeditar = new System.Windows.Forms.ToolStripButton();
            this.lblPacienteTitulo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRegistrarPaciente = new System.Windows.Forms.Button();
            this.tbEdadPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApellidoPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombrePaciente = new System.Windows.Forms.TextBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditarPaciente = new System.Windows.Forms.Button();
            this.menuStripAcciones.SuspendLayout();
            this.TLSAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
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
            this.menuStripAcciones.Size = new System.Drawing.Size(1052, 28);
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
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
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
            this.TLSeditar});
            this.TLSAcciones.Location = new System.Drawing.Point(0, 28);
            this.TLSAcciones.Name = "TLSAcciones";
            this.TLSAcciones.Size = new System.Drawing.Size(1052, 27);
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
            // lblPacienteTitulo
            // 
            this.lblPacienteTitulo.AutoSize = true;
            this.lblPacienteTitulo.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteTitulo.Location = new System.Drawing.Point(38, 76);
            this.lblPacienteTitulo.Name = "lblPacienteTitulo";
            this.lblPacienteTitulo.Size = new System.Drawing.Size(645, 33);
            this.lblPacienteTitulo.TabIndex = 0;
            this.lblPacienteTitulo.Text = "Bienvenido al registro de pacientes";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(33, 113);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRegistro);
            this.splitContainer1.Size = new System.Drawing.Size(996, 378);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btEditarPaciente);
            this.panel2.Controls.Add(this.btRegistrarPaciente);
            this.panel2.Controls.Add(this.tbEdadPaciente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbApellidoPaciente);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbNombrePaciente);
            this.panel2.Location = new System.Drawing.Point(-1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 372);
            this.panel2.TabIndex = 5;
            // 
            // btRegistrarPaciente
            // 
            this.btRegistrarPaciente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btRegistrarPaciente.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarPaciente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRegistrarPaciente.Location = new System.Drawing.Point(114, 307);
            this.btRegistrarPaciente.Name = "btRegistrarPaciente";
            this.btRegistrarPaciente.Size = new System.Drawing.Size(209, 50);
            this.btRegistrarPaciente.TabIndex = 6;
            this.btRegistrarPaciente.Text = "Registrar Paciente";
            this.btRegistrarPaciente.UseVisualStyleBackColor = false;
            this.btRegistrarPaciente.Click += new System.EventHandler(this.btRegistrarPaciente_Click);
            // 
            // tbEdadPaciente
            // 
            this.tbEdadPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdadPaciente.Location = new System.Drawing.Point(54, 249);
            this.tbEdadPaciente.Name = "tbEdadPaciente";
            this.tbEdadPaciente.Size = new System.Drawing.Size(335, 30);
            this.tbEdadPaciente.TabIndex = 5;
            this.tbEdadPaciente.TextChanged += new System.EventHandler(this.tbEdadPaciente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Introduce la edad del paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Introduce el apellido del paciente:";
            // 
            // tbApellidoPaciente
            // 
            this.tbApellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoPaciente.Location = new System.Drawing.Point(54, 153);
            this.tbApellidoPaciente.Name = "tbApellidoPaciente";
            this.tbApellidoPaciente.Size = new System.Drawing.Size(335, 30);
            this.tbApellidoPaciente.TabIndex = 2;
            this.tbApellidoPaciente.TextChanged += new System.EventHandler(this.tbApellidoPaciente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Introduce el nombre del paciente:";
            // 
            // tbNombrePaciente
            // 
            this.tbNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombrePaciente.Location = new System.Drawing.Point(54, 60);
            this.tbNombrePaciente.Name = "tbNombrePaciente";
            this.tbNombrePaciente.Size = new System.Drawing.Size(335, 30);
            this.tbNombrePaciente.TabIndex = 0;
            this.tbNombrePaciente.TextChanged += new System.EventHandler(this.tbNombrePaciente_TextChanged);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(3, 4);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersWidth = 51;
            this.dgvRegistro.RowTemplate.Height = 24;
            this.dgvRegistro.Size = new System.Drawing.Size(533, 371);
            this.dgvRegistro.TabIndex = 6;
            this.dgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenido a la edición de pacientes";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btEditarPaciente
            // 
            this.btEditarPaciente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btEditarPaciente.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarPaciente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btEditarPaciente.Location = new System.Drawing.Point(114, 307);
            this.btEditarPaciente.Name = "btEditarPaciente";
            this.btEditarPaciente.Size = new System.Drawing.Size(209, 50);
            this.btEditarPaciente.TabIndex = 7;
            this.btEditarPaciente.Text = "Editar Paciente";
            this.btEditarPaciente.UseVisualStyleBackColor = false;
            this.btEditarPaciente.Visible = false;
            this.btEditarPaciente.Click += new System.EventHandler(this.btEditarPaciente_Click);
            // 
            // FormularioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblPacienteTitulo);
            this.Controls.Add(this.TLSAcciones);
            this.Controls.Add(this.menuStripAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormularioPaciente";
            this.Text = "FormularioPaciente";
            this.menuStripAcciones.ResumeLayout(false);
            this.menuStripAcciones.PerformLayout();
            this.TLSAcciones.ResumeLayout(false);
            this.TLSAcciones.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
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
        private System.Windows.Forms.Label lblPacienteTitulo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRegistrarPaciente;
        private System.Windows.Forms.TextBox tbEdadPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApellidoPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombrePaciente;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditarPaciente;
    }
}