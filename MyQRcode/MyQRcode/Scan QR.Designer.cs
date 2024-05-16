namespace MyQRcode
{
    partial class Scan_QR
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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box_cam = new System.Windows.Forms.ComboBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.text_QR = new System.Windows.Forms.TextBox();
            this.scan_pic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scan_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(475, 76);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // box_cam
            // 
            this.box_cam.FormattingEnabled = true;
            this.box_cam.Location = new System.Drawing.Point(144, 21);
            this.box_cam.Name = "box_cam";
            this.box_cam.Size = new System.Drawing.Size(121, 23);
            this.box_cam.TabIndex = 2;
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(648, 76);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 4;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // text_QR
            // 
            this.text_QR.Location = new System.Drawing.Point(462, 137);
            this.text_QR.Multiline = true;
            this.text_QR.Name = "text_QR";
            this.text_QR.Size = new System.Drawing.Size(300, 125);
            this.text_QR.TabIndex = 5;
            // 
            // scan_pic
            // 
            this.scan_pic.BackColor = System.Drawing.Color.White;
            this.scan_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scan_pic.Location = new System.Drawing.Point(24, 76);
            this.scan_pic.Name = "scan_pic";
            this.scan_pic.Size = new System.Drawing.Size(400, 400);
            this.scan_pic.TabIndex = 6;
            this.scan_pic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scan_QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.scan_pic);
            this.Controls.Add(this.text_QR);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.box_cam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Name = "Scan_QR";
            this.Text = "Scan_QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scan_QR_FormClosing);
            this.Load += new System.EventHandler(this.Scan_QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scan_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_start;
        private Label label1;
        private ComboBox box_cam;
        private Button btn_read;
        private TextBox text_QR;
        private PictureBox scan_pic;
        private System.Windows.Forms.Timer timer1;
    }
}