namespace DataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripAcciones = new System.Windows.Forms.MenuStrip();
            this.accionsMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saberMásMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.TLSAcciones = new System.Windows.Forms.ToolStrip();
            this.TLSagregar = new System.Windows.Forms.ToolStripButton();
            this.TLSeditar = new System.Windows.Forms.ToolStripButton();
            this.TLSeliminar = new System.Windows.Forms.ToolStripButton();
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.botonIngresos = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.tituloForm1Exterior = new System.Windows.Forms.Label();
            this.dataGridViewForm1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStripAcciones.SuspendLayout();
            this.TLSAcciones.SuspendLayout();
            this.panelForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.menuStripAcciones.Size = new System.Drawing.Size(904, 28);
            this.menuStripAcciones.TabIndex = 0;
            this.menuStripAcciones.Text = "menuStrip1";
            // 
            // accionsMNU
            // 
            this.accionsMNU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.accionsMNU.Name = "accionsMNU";
            this.accionsMNU.Size = new System.Drawing.Size(82, 24);
            this.accionsMNU.Text = "Acciones";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // saberMásMNU
            // 
            this.saberMásMNU.Name = "saberMásMNU";
            this.saberMásMNU.Size = new System.Drawing.Size(92, 24);
            this.saberMásMNU.Text = "Saber más";
            this.saberMásMNU.Click += new System.EventHandler(this.saberMásMNU_Click);
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
            this.TLSAcciones.Size = new System.Drawing.Size(904, 27);
            this.TLSAcciones.TabIndex = 1;
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
            this.TLSagregar.Click += new System.EventHandler(this.TLSagregar_Click);
            // 
            // TLSeditar
            // 
            this.TLSeditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TLSeditar.Image = ((System.Drawing.Image)(resources.GetObject("TLSeditar.Image")));
            this.TLSeditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TLSeditar.Name = "TLSeditar";
            this.TLSeditar.Size = new System.Drawing.Size(29, 24);
            this.TLSeditar.Text = "toolStripButtonEditar";
            this.TLSeditar.Click += new System.EventHandler(this.TLSeditar_Click);
            // 
            // TLSeliminar
            // 
            this.TLSeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TLSeliminar.Image = ((System.Drawing.Image)(resources.GetObject("TLSeliminar.Image")));
            this.TLSeliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TLSeliminar.Name = "TLSeliminar";
            this.TLSeliminar.Size = new System.Drawing.Size(29, 24);
            this.TLSeliminar.Text = "toolStripButtonEliminar";
            this.TLSeliminar.Click += new System.EventHandler(this.TLSeliminar_Click);
            // 
            // panelForm1
            // 
            this.panelForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelForm1.Controls.Add(this.botonIngresos);
            this.panelForm1.Controls.Add(this.botonEliminar);
            this.panelForm1.Controls.Add(this.botonEditar);
            this.panelForm1.Controls.Add(this.botonAgregar);
            this.panelForm1.Location = new System.Drawing.Point(51, 130);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(803, 92);
            this.panelForm1.TabIndex = 2;
            // 
            // botonIngresos
            // 
            this.botonIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.botonIngresos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonIngresos.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresos.Location = new System.Drawing.Point(637, 17);
            this.botonIngresos.Name = "botonIngresos";
            this.botonIngresos.Size = new System.Drawing.Size(150, 58);
            this.botonIngresos.TabIndex = 8;
            this.botonIngresos.Text = "Ver Ingresos";
            this.botonIngresos.UseVisualStyleBackColor = false;
            this.botonIngresos.Click += new System.EventHandler(this.botonListar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.botonEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonEliminar.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(230, 17);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(150, 58);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar Paciente";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.botonEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonEditar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEditar.Location = new System.Drawing.Point(436, 17);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(150, 58);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Text = "Editar Paciente";
            this.botonEditar.UseVisualStyleBackColor = false;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.botonAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botonAgregar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonAgregar.Location = new System.Drawing.Point(16, 17);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(150, 58);
            this.botonAgregar.TabIndex = 4;
            this.botonAgregar.Text = "Registrar Paciente";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // tituloForm1Exterior
            // 
            this.tituloForm1Exterior.AutoSize = true;
            this.tituloForm1Exterior.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloForm1Exterior.Location = new System.Drawing.Point(61, 84);
            this.tituloForm1Exterior.Name = "tituloForm1Exterior";
            this.tituloForm1Exterior.Size = new System.Drawing.Size(717, 33);
            this.tituloForm1Exterior.TabIndex = 3;
            this.tituloForm1Exterior.Text = "¡Bienvenido al formulario del Hospital!";
            // 
            // dataGridViewForm1
            // 
            this.dataGridViewForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewForm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm1.GridColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewForm1.Location = new System.Drawing.Point(16, 12);
            this.dataGridViewForm1.Name = "dataGridViewForm1";
            this.dataGridViewForm1.RowHeadersWidth = 51;
            this.dataGridViewForm1.RowTemplate.Height = 24;
            this.dataGridViewForm1.Size = new System.Drawing.Size(771, 372);
            this.dataGridViewForm1.TabIndex = 7;
            this.dataGridViewForm1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForm1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.dataGridViewForm1);
            this.panel1.Location = new System.Drawing.Point(51, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 401);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(904, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloForm1Exterior);
            this.Controls.Add(this.panelForm1);
            this.Controls.Add(this.TLSAcciones);
            this.Controls.Add(this.menuStripAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripAcciones;
            this.Name = "Form1";
            this.Text = "Formulario Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripAcciones.ResumeLayout(false);
            this.menuStripAcciones.PerformLayout();
            this.TLSAcciones.ResumeLayout(false);
            this.TLSAcciones.PerformLayout();
            this.panelForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAcciones;
        private System.Windows.Forms.ToolStripMenuItem accionsMNU;
        private System.Windows.Forms.ToolStrip TLSAcciones;
        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label tituloForm1Exterior;
        private System.Windows.Forms.ToolStripButton TLSagregar;
        private System.Windows.Forms.DataGridView dataGridViewForm1;
        private System.Windows.Forms.ToolStripButton TLSeditar;
        private System.Windows.Forms.ToolStripButton TLSeliminar;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonIngresos;
        private System.Windows.Forms.ToolStripMenuItem saberMásMNU;
    }
}

