using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masaustu_duvar_kagidi_degistirme
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        public Form1()
        {
            InitializeComponent();
        }

        public void DuvarKagidiAyarla(String yol)
        {
            SystemParametersInfo(0x14, 0, yol, 0x01 | 0x02);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "bağlantı";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            DuvarKagidiAyarla(DosyaYolu);
        }
    }
}
