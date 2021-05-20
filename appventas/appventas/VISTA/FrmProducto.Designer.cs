
namespace appventas.VISTA
{
    partial class FrmProducto
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEstadoP = new System.Windows.Forms.Label();
            this.lblPrecioP = new System.Windows.Forms.Label();
            this.lblNombrePro = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(626, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 44);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(457, 446);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 44);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(271, 446);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 44);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualzar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(75, 446);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 44);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgProducto
            // 
            this.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgProducto.Location = new System.Drawing.Point(62, 230);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.Size = new System.Drawing.Size(669, 179);
            this.dtgProducto.TabIndex = 21;
            this.dtgProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducto_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(221, 158);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(219, 20);
            this.txtEstado.TabIndex = 20;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(221, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(219, 20);
            this.txtPrecio.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(221, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 20);
            this.txtID.TabIndex = 17;
            // 
            // lblEstadoP
            // 
            this.lblEstadoP.AutoSize = true;
            this.lblEstadoP.Location = new System.Drawing.Point(59, 165);
            this.lblEstadoP.Name = "lblEstadoP";
            this.lblEstadoP.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoP.TabIndex = 16;
            this.lblEstadoP.Text = "Estado";
            // 
            // lblPrecioP
            // 
            this.lblPrecioP.AutoSize = true;
            this.lblPrecioP.Location = new System.Drawing.Point(59, 114);
            this.lblPrecioP.Name = "lblPrecioP";
            this.lblPrecioP.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioP.TabIndex = 15;
            this.lblPrecioP.Text = "Precio";
            // 
            // lblNombrePro
            // 
            this.lblNombrePro.AutoSize = true;
            this.lblNombrePro.Location = new System.Drawing.Point(59, 66);
            this.lblNombrePro.Name = "lblNombrePro";
            this.lblNombrePro.Size = new System.Drawing.Size(50, 13);
            this.lblNombrePro.TabIndex = 14;
            this.lblNombrePro.Text = "Producto";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(59, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(221, 66);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(219, 20);
            this.txtNombreP.TabIndex = 26;
            this.txtNombreP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(537, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(219, 20);
            this.txtFiltro.TabIndex = 27;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 507);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEstadoP);
            this.Controls.Add(this.lblPrecioP);
            this.Controls.Add(this.lblNombrePro);
            this.Controls.Add(this.lblID);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEstadoP;
        private System.Windows.Forms.Label lblPrecioP;
        private System.Windows.Forms.Label lblNombrePro;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}