
namespace appventas.VISTA
{
    partial class FrmVentas
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
            this.lblNombreDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBuscarPro = new System.Windows.Forms.Label();
            this.txtBuscarPro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoProd = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreDoc
            // 
            this.lblNombreDoc.AutoSize = true;
            this.lblNombreDoc.Location = new System.Drawing.Point(12, 20);
            this.lblNombreDoc.Name = "lblNombreDoc";
            this.lblNombreDoc.Size = new System.Drawing.Size(115, 13);
            this.lblNombreDoc.TabIndex = 0;
            this.lblNombreDoc.Text = "Nombre de documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(12, 70);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(99, 13);
            this.lblTipoDoc.TabIndex = 1;
            this.lblTipoDoc.Text = "Tipo de documento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 114);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.Location = new System.Drawing.Point(174, 20);
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(176, 20);
            this.txtNombreDoc.TabIndex = 3;
            this.txtNombreDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 207);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblBuscarPro
            // 
            this.lblBuscarPro.AutoSize = true;
            this.lblBuscarPro.Location = new System.Drawing.Point(12, 211);
            this.lblBuscarPro.Name = "lblBuscarPro";
            this.lblBuscarPro.Size = new System.Drawing.Size(86, 13);
            this.lblBuscarPro.TabIndex = 7;
            this.lblBuscarPro.Text = "Buscar Producto";
            // 
            // txtBuscarPro
            // 
            this.txtBuscarPro.Location = new System.Drawing.Point(174, 208);
            this.txtBuscarPro.Name = "txtBuscarPro";
            this.txtBuscarPro.Size = new System.Drawing.Size(176, 20);
            this.txtBuscarPro.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(456, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoProd
            // 
            this.lblCodigoProd.AutoSize = true;
            this.lblCodigoProd.Location = new System.Drawing.Point(16, 287);
            this.lblCodigoProd.Name = "lblCodigoProd";
            this.lblCodigoProd.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoProd.TabIndex = 14;
            this.lblCodigoProd.Text = "Codigo Producto";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(223, 287);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProd.TabIndex = 15;
            this.lblNombreProd.Text = "Nombre Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(433, 287);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(639, 287);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(642, 313);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(176, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(436, 313);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(226, 313);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(176, 20);
            this.txtNombreProd.TabIndex = 11;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(15, 313);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(176, 20);
            this.txtCodigoProd.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 578);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.lblCodigoProd);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarPro);
            this.Controls.Add(this.lblBuscarPro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreDoc);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNombreDoc);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBuscarPro;
        private System.Windows.Forms.TextBox txtBuscarPro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigoProd;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}