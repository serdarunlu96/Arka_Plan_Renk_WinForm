using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arka_Plan_Renk_WinForm
{
    public partial class Form2 : Form
    {
        public Color SecilenRenk { get; set; }
        public Form2()
        {
            InitializeComponent();
            cmbRenkler.Items.Add(Color.AliceBlue);
            cmbRenkler.Items.Add(Color.Red);
            cmbRenkler.Items.Add(Color.Green);
            cmbRenkler.Items.Add(Color.Blue);
            cmbRenkler.SelectedIndex = 0;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            SecilenRenk = (Color)cmbRenkler.SelectedItem;
            DialogResult=DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
