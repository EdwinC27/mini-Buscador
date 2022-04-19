
namespace WindowsFormsApp14
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
            this.atrasar = new System.Windows.Forms.Button();
            this.adelantar = new System.Windows.Forms.Button();
            this.recargar = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.paginaPrincipal = new System.Windows.Forms.Button();
            this.ir = new System.Windows.Forms.Button();
            this.parar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // atrasar
            // 
            this.atrasar.Location = new System.Drawing.Point(12, 12);
            this.atrasar.Name = "atrasar";
            this.atrasar.Size = new System.Drawing.Size(28, 23);
            this.atrasar.TabIndex = 0;
            this.atrasar.Text = "<--";
            this.atrasar.UseVisualStyleBackColor = true;
            this.atrasar.Click += new System.EventHandler(this.atrasar_Click);
            // 
            // adelantar
            // 
            this.adelantar.Location = new System.Drawing.Point(46, 12);
            this.adelantar.Name = "adelantar";
            this.adelantar.Size = new System.Drawing.Size(29, 23);
            this.adelantar.TabIndex = 1;
            this.adelantar.Text = "-->";
            this.adelantar.UseVisualStyleBackColor = true;
            this.adelantar.Click += new System.EventHandler(this.adelantar_Click);
            // 
            // recargar
            // 
            this.recargar.Location = new System.Drawing.Point(81, 12);
            this.recargar.Name = "recargar";
            this.recargar.Size = new System.Drawing.Size(61, 23);
            this.recargar.TabIndex = 2;
            this.recargar.Text = "Regargar";
            this.recargar.UseVisualStyleBackColor = true;
            this.recargar.Click += new System.EventHandler(this.recargar_Click);
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(319, 13);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(626, 20);
            this.textURL.TabIndex = 3;
            // 
            // paginaPrincipal
            // 
            this.paginaPrincipal.Location = new System.Drawing.Point(208, 11);
            this.paginaPrincipal.Name = "paginaPrincipal";
            this.paginaPrincipal.Size = new System.Drawing.Size(93, 23);
            this.paginaPrincipal.TabIndex = 4;
            this.paginaPrincipal.Text = "Pagina principal";
            this.paginaPrincipal.UseVisualStyleBackColor = true;
            this.paginaPrincipal.Click += new System.EventHandler(this.paginaPrincipal_Click);
            // 
            // ir
            // 
            this.ir.Location = new System.Drawing.Point(962, 12);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(28, 21);
            this.ir.TabIndex = 5;
            this.ir.Text = "Ir";
            this.ir.UseVisualStyleBackColor = true;
            this.ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // parar
            // 
            this.parar.Location = new System.Drawing.Point(159, 11);
            this.parar.Name = "parar";
            this.parar.Size = new System.Drawing.Size(43, 24);
            this.parar.TabIndex = 6;
            this.parar.Text = "Parar";
            this.parar.UseVisualStyleBackColor = true;
            this.parar.Click += new System.EventHandler(this.parar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(978, 464);
            this.webBrowser1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 528);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.parar);
            this.Controls.Add(this.ir);
            this.Controls.Add(this.paginaPrincipal);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.recargar);
            this.Controls.Add(this.adelantar);
            this.Controls.Add(this.atrasar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atrasar;
        private System.Windows.Forms.Button adelantar;
        private System.Windows.Forms.Button recargar;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button paginaPrincipal;
        private System.Windows.Forms.Button ir;
        private System.Windows.Forms.Button parar;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

