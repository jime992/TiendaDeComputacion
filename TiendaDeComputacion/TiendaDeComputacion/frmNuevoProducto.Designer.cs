namespace TiendaDeComputacion
{
    partial class frmNuevoProducto
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
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Vaciar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcaImp = new System.Windows.Forms.TextBox();
            this.txtColorImp = new System.Windows.Forms.TextBox();
            this.txtPrecioImp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cargar.Location = new System.Drawing.Point(39, 314);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(103, 46);
            this.btn_Cargar.TabIndex = 0;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = false;
            // 
            // btn_Vaciar
            // 
            this.btn_Vaciar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Vaciar.Location = new System.Drawing.Point(162, 314);
            this.btn_Vaciar.Name = "btn_Vaciar";
            this.btn_Vaciar.Size = new System.Drawing.Size(103, 46);
            this.btn_Vaciar.TabIndex = 1;
            this.btn_Vaciar.Text = "Vaciar";
            this.btn_Vaciar.UseVisualStyleBackColor = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Volver.Location = new System.Drawing.Point(289, 314);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(103, 46);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // lblNuevo
            // 
            this.lblNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuevo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.Location = new System.Drawing.Point(52, 39);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(340, 43);
            this.lblNuevo.TabIndex = 3;
            this.lblNuevo.Text = "Nueva Impresora";
            this.lblNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio";
            // 
            // txtMarcaImp
            // 
            this.txtMarcaImp.Location = new System.Drawing.Point(162, 114);
            this.txtMarcaImp.Name = "txtMarcaImp";
            this.txtMarcaImp.Size = new System.Drawing.Size(207, 32);
            this.txtMarcaImp.TabIndex = 7;
            // 
            // txtColorImp
            // 
            this.txtColorImp.Location = new System.Drawing.Point(162, 164);
            this.txtColorImp.Name = "txtColorImp";
            this.txtColorImp.Size = new System.Drawing.Size(207, 32);
            this.txtColorImp.TabIndex = 8;
            // 
            // txtPrecioImp
            // 
            this.txtPrecioImp.Location = new System.Drawing.Point(257, 218);
            this.txtPrecioImp.Name = "txtPrecioImp";
            this.txtPrecioImp.Size = new System.Drawing.Size(112, 32);
            this.txtPrecioImp.TabIndex = 9;
            this.txtPrecioImp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioImp_KeyPress);
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(430, 395);
            this.Controls.Add(this.txtPrecioImp);
            this.Controls.Add(this.txtColorImp);
            this.Controls.Add(this.txtMarcaImp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Vaciar);
            this.Controls.Add(this.btn_Cargar);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNuevoProducto_FormClosing);
            this.Load += new System.EventHandler(this.FrmNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Vaciar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarcaImp;
        private System.Windows.Forms.TextBox txtColorImp;
        private System.Windows.Forms.TextBox txtPrecioImp;
    }
}