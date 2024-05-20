namespace MyQRcode
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void genQR_Click(object sender, EventArgs e)
        {
            Form gen = new Generate_QR();
            gen.Left = this.Left;
            gen.Top = this.Top;

            gen.Show();
            this.Hide();
        }

        private void scanQR_Click(object sender, EventArgs e)
        {
            Form scan = new Scan_QR();
            scan.Left = this.Left;
            scan.Top = this.Top;

            scan.Show();
            this.Hide();
        }
    }
}