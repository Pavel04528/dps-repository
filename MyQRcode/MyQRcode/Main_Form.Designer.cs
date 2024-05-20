namespace MyQRcode
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.genQR = new System.Windows.Forms.Button();
            this.scanQR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genQR
            // 
            this.genQR.Location = new System.Drawing.Point(141, 57);
            this.genQR.Name = "genQR";
            this.genQR.Size = new System.Drawing.Size(121, 23);
            this.genQR.TabIndex = 0;
            this.genQR.Text = "Сгенерировать QR";
            this.genQR.UseVisualStyleBackColor = true;
            this.genQR.Click += new System.EventHandler(this.genQR_Click);
            // 
            // scanQR
            // 
            this.scanQR.Location = new System.Drawing.Point(142, 129);
            this.scanQR.Name = "scanQR";
            this.scanQR.Size = new System.Drawing.Size(120, 23);
            this.scanQR.TabIndex = 1;
            this.scanQR.Text = "Отсканировать QR";
            this.scanQR.UseVisualStyleBackColor = true;
            this.scanQR.Click += new System.EventHandler(this.scanQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 275);
            this.Controls.Add(this.scanQR);
            this.Controls.Add(this.genQR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button genQR;
        private Button scanQR;
    }
}