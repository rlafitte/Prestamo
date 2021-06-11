
namespace Prestamo.GUI
{
    partial class Form1
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
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.tbTNA = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbPlazo = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.tbCuotaCap = new System.Windows.Forms.TextBox();
            this.tbCuotaInt = new System.Windows.Forms.TextBox();
            this.tbCuotaTotal = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstTipoPrestamo = new System.Windows.Forms.ListBox();
            this.tbComisionTotal = new System.Windows.Forms.TextBox();
            this.lbContadorPrestamos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(452, 58);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(318, 277);
            this.lstPrestamos.TabIndex = 0;
            // 
            // tbLinea
            // 
            this.tbLinea.Enabled = false;
            this.tbLinea.Location = new System.Drawing.Point(284, 74);
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.Size = new System.Drawing.Size(100, 20);
            this.tbLinea.TabIndex = 1;
            // 
            // tbTNA
            // 
            this.tbTNA.Enabled = false;
            this.tbTNA.Location = new System.Drawing.Point(284, 113);
            this.tbTNA.Name = "tbTNA";
            this.tbTNA.Size = new System.Drawing.Size(100, 20);
            this.tbTNA.TabIndex = 2;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(284, 151);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 3;
            // 
            // tbPlazo
            // 
            this.tbPlazo.Location = new System.Drawing.Point(284, 192);
            this.tbPlazo.Name = "tbPlazo";
            this.tbPlazo.Size = new System.Drawing.Size(100, 20);
            this.tbPlazo.TabIndex = 4;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(284, 235);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 5;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // tbCuotaCap
            // 
            this.tbCuotaCap.Enabled = false;
            this.tbCuotaCap.Location = new System.Drawing.Point(284, 278);
            this.tbCuotaCap.Name = "tbCuotaCap";
            this.tbCuotaCap.Size = new System.Drawing.Size(100, 20);
            this.tbCuotaCap.TabIndex = 6;
            // 
            // tbCuotaInt
            // 
            this.tbCuotaInt.Enabled = false;
            this.tbCuotaInt.Location = new System.Drawing.Point(284, 315);
            this.tbCuotaInt.Name = "tbCuotaInt";
            this.tbCuotaInt.Size = new System.Drawing.Size(100, 20);
            this.tbCuotaInt.TabIndex = 7;
            // 
            // tbCuotaTotal
            // 
            this.tbCuotaTotal.Enabled = false;
            this.tbCuotaTotal.Location = new System.Drawing.Point(284, 353);
            this.tbCuotaTotal.Name = "tbCuotaTotal";
            this.tbCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.tbCuotaTotal.TabIndex = 8;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(284, 394);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lstTipoPrestamo
            // 
            this.lstTipoPrestamo.FormattingEnabled = true;
            this.lstTipoPrestamo.Location = new System.Drawing.Point(23, 74);
            this.lstTipoPrestamo.Name = "lstTipoPrestamo";
            this.lstTipoPrestamo.Size = new System.Drawing.Size(225, 108);
            this.lstTipoPrestamo.TabIndex = 10;
            this.lstTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrestamo_SelectedIndexChanged);
            // 
            // tbComisionTotal
            // 
            this.tbComisionTotal.Enabled = false;
            this.tbComisionTotal.Location = new System.Drawing.Point(590, 353);
            this.tbComisionTotal.Name = "tbComisionTotal";
            this.tbComisionTotal.Size = new System.Drawing.Size(100, 20);
            this.tbComisionTotal.TabIndex = 11;
            // 
            // lbContadorPrestamos
            // 
            this.lbContadorPrestamos.AutoSize = true;
            this.lbContadorPrestamos.Location = new System.Drawing.Point(590, 394);
            this.lbContadorPrestamos.Name = "lbContadorPrestamos";
            this.lbContadorPrestamos.Size = new System.Drawing.Size(35, 13);
            this.lbContadorPrestamos.TabIndex = 12;
            this.lbContadorPrestamos.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Préstamos: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Actualizar lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbContadorPrestamos);
            this.Controls.Add(this.tbComisionTotal);
            this.Controls.Add(this.lstTipoPrestamo);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.tbCuotaTotal);
            this.Controls.Add(this.tbCuotaInt);
            this.Controls.Add(this.tbCuotaCap);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.tbPlazo);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.tbTNA);
            this.Controls.Add(this.tbLinea);
            this.Controls.Add(this.lstPrestamos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.TextBox tbTNA;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbPlazo;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox tbCuotaCap;
        private System.Windows.Forms.TextBox tbCuotaInt;
        private System.Windows.Forms.TextBox tbCuotaTotal;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListBox lstTipoPrestamo;
        private System.Windows.Forms.TextBox tbComisionTotal;
        private System.Windows.Forms.Label lbContadorPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

