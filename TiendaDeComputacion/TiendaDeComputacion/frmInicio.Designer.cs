namespace TiendaDeComputacion
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeImpresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTintasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTintasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPresupuestoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoPresupuestoToolStripMenuItem
            // 
            this.nuevoPresupuestoToolStripMenuItem.Name = "nuevoPresupuestoToolStripMenuItem";
            this.nuevoPresupuestoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.nuevoPresupuestoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.nuevoPresupuestoToolStripMenuItem.Text = "Nuevo Presupuesto";
            this.nuevoPresupuestoToolStripMenuItem.Click += new System.EventHandler(this.NuevoPresupuestoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impresorasToolStripMenuItem,
            this.notebooksToolStripMenuItem,
            this.tintaToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaImpresoraToolStripMenuItem,
            this.listaDeImpresorasToolStripMenuItem});
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            this.impresorasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.impresorasToolStripMenuItem.Text = "Impresoras";
            // 
            // nuevaImpresoraToolStripMenuItem
            // 
            this.nuevaImpresoraToolStripMenuItem.Name = "nuevaImpresoraToolStripMenuItem";
            this.nuevaImpresoraToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.nuevaImpresoraToolStripMenuItem.Text = "Nueva Impresora";
            this.nuevaImpresoraToolStripMenuItem.Click += new System.EventHandler(this.NuevaImpresoraToolStripMenuItem_Click);
            // 
            // listaDeImpresorasToolStripMenuItem
            // 
            this.listaDeImpresorasToolStripMenuItem.Name = "listaDeImpresorasToolStripMenuItem";
            this.listaDeImpresorasToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.listaDeImpresorasToolStripMenuItem.Text = "Lista de Impresoras";
            this.listaDeImpresorasToolStripMenuItem.Click += new System.EventHandler(this.ListaDeImpresorasToolStripMenuItem_Click);
            // 
            // notebooksToolStripMenuItem
            // 
            this.notebooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaNotebookToolStripMenuItem,
            this.listaDeNotebookToolStripMenuItem});
            this.notebooksToolStripMenuItem.Name = "notebooksToolStripMenuItem";
            this.notebooksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notebooksToolStripMenuItem.Text = "Notebooks";
            // 
            // nuevaNotebookToolStripMenuItem
            // 
            this.nuevaNotebookToolStripMenuItem.Name = "nuevaNotebookToolStripMenuItem";
            this.nuevaNotebookToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.nuevaNotebookToolStripMenuItem.Text = "Nueva Notebook";
            this.nuevaNotebookToolStripMenuItem.Click += new System.EventHandler(this.NuevaNotebookToolStripMenuItem_Click);
            // 
            // listaDeNotebookToolStripMenuItem
            // 
            this.listaDeNotebookToolStripMenuItem.Name = "listaDeNotebookToolStripMenuItem";
            this.listaDeNotebookToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.listaDeNotebookToolStripMenuItem.Text = "Lista de Notebook";
            // 
            // tintaToolStripMenuItem
            // 
            this.tintaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeTintasToolStripMenuItem,
            this.listaDeTintasToolStripMenuItem1});
            this.tintaToolStripMenuItem.Name = "tintaToolStripMenuItem";
            this.tintaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tintaToolStripMenuItem.Text = "Tinta";
            // 
            // listaDeTintasToolStripMenuItem
            // 
            this.listaDeTintasToolStripMenuItem.Name = "listaDeTintasToolStripMenuItem";
            this.listaDeTintasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeTintasToolStripMenuItem.Text = "Nueva Tinta";
            this.listaDeTintasToolStripMenuItem.Click += new System.EventHandler(this.ListaDeTintasToolStripMenuItem_Click);
            // 
            // listaDeTintasToolStripMenuItem1
            // 
            this.listaDeTintasToolStripMenuItem1.Name = "listaDeTintasToolStripMenuItem1";
            this.listaDeTintasToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.listaDeTintasToolStripMenuItem1.Text = "Lista de Tintas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesToolStripMenuItem,
            this.cargarNuevoClienteToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // cargarNuevoClienteToolStripMenuItem
            // 
            this.cargarNuevoClienteToolStripMenuItem.Name = "cargarNuevoClienteToolStripMenuItem";
            this.cargarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.cargarNuevoClienteToolStripMenuItem.Text = "Cargar Nuevo Cliente";
            this.cargarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.CargarNuevoClienteToolStripMenuItem_Click);
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenido.Location = new System.Drawing.Point(78, 104);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(241, 47);
            this.lbl_Bienvenido.TabIndex = 1;
            this.lbl_Bienvenido.Text = "Bienvenido";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(436, 217);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de Computacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaImpresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeImpresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notebooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTintasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTintasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Bienvenido;
    }
}

