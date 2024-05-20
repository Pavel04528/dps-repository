using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QRCoder;

namespace MyQRcode
{
    public partial class Generate_QR : Form
    {
        public Generate_QR()
        {
            InitializeComponent();
        }

        private void Generate_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f_main = Application.OpenForms[0];

            f_main.StartPosition = FormStartPosition.Manual;

            f_main.Left = this.Left;
            f_main.Top = this.Top;

            f_main.Show();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            var qr_data = qr.CreateQrCode(text_QR.Text, QRCodeGenerator.ECCLevel.L);
            var data = new QRCode(qr_data);
            gen_pic.Image = data.GetGraphic(5);           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gen_pic.Image.Save(save.FileName);
            }
        }
    }
}
