
namespace appventas.VISTA
{
    partial class FrmPrincipal
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnProduc = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(115, 40);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(151, 56);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Tb Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(115, 134);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(151, 56);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Tb Documento";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(115, 239);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(151, 56);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Tb Usuario";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnProduc
            // 
            this.btnProduc.Location = new System.Drawing.Point(115, 343);
            this.btnProduc.Name = "btnProduc";
            this.btnProduc.Size = new System.Drawing.Size(151, 56);
            this.btnProduc.TabIndex = 3;
            this.btnProduc.Text = "Tb Producto";
            this.btnProduc.UseVisualStyleBackColor = true;
            this.btnProduc.Click += new System.EventHandler(this.btnProduc_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 509);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 38);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(385, 571);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProduc);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnCliente);
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnProduc;
        private System.Windows.Forms.Button btnSalir;
    }
}