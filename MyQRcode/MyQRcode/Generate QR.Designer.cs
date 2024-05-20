namespace MyQRcode
{
    partial class Generate_QR
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
            this.gen_pic = new System.Windows.Forms.PictureBox();
            this.text_QR = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gen_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // gen_pic
            // 
            this.gen_pic.BackColor = System.Drawing.Color.White;
            this.gen_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gen_pic.Location = new System.Drawing.Point(22, 12);
            this.gen_pic.Name = "gen_pic";
            this.gen_pic.Size = new System.Drawing.Size(400, 400);
            this.gen_pic.TabIndex = 3;
            this.gen_pic.TabStop = false;
            // 
            // text_QR
            // 
            this.text_QR.Location = new System.Drawing.Point(477, 95);
            this.text_QR.Multiline = true;
            this.text_QR.Name = "text_QR";
            this.text_QR.Size = new System.Drawing.Size(350, 100);
            this.text_QR.TabIndex = 5;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(477, 66);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(752, 66);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Generate_QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 425);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.text_QR);
            this.Controls.Add(this.gen_pic);
            this.Name = "Generate_QR";
            this.Text = "Generate_QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generate_QR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gen_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox gen_pic;
        private TextBox text_QR;
        private Button btn_generate;
        private Button btn_save;
    }
}