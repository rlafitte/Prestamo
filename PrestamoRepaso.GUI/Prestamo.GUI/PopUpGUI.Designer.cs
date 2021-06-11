
namespace Prestamo.GUI
{
    partial class PopUpGUI
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(47, 41);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(84, 38);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(151, 41);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 38);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // PopUpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 125);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Name = "PopUpGUI";
            this.Text = "PopUpGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
    }
}