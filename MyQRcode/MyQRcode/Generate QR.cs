using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /*
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(text_QR.Text);
            */
            Zen.Barcode.CodeQrBarcodeDraw dr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            gen_pic.Image = dr.Draw(text_QR.Text, 500);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dig = new SaveFileDialog();
            dig.ShowDialog();
            gen_pic.Image.Save(dig.FileName+".jpeg");
        }
    }
}
