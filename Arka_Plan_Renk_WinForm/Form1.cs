namespace Arka_Plan_Renk_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            Form2 renkFormu = new Form2();

            if (renkFormu.ShowDialog() == DialogResult.OK)
                BackColor = renkFormu.SecilenRenk;
        }
    }
}