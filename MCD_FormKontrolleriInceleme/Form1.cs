using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form içerisinde bulunan değerleri silmek istediğinizden emin misiniz?", "Form temizleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultEnum==DialogResult.Yes)
            {
                formTemizle();
                formElemanIndexTemizle();
            }
            else
            {
                //işlem iptal edildi...
            }
        }

        private void formTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //item control == TextBox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void formElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtsoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtemailadres"]).Text = string.Empty;
            ((TextBox)this.Controls["txttelefonnumarasi"]).Text = string.Empty;
        }

        private void btnonizleme_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit onizlemeKayit = new frmOnizlemeKayit();
            ((TextBox)this.Controls["txtisim"]).Text = txtisim.Text;
            ((TextBox)this.Controls["txtsoyisim"]).Text = txtsoyisim.Text;
            ((TextBox)this.Controls["txtemailadres"]).Text = txtemailadres.Text;
            ((TextBox)this.Controls["txttelefonnumarasi"]).Text = txttelefonnumarasi.Text;
            onizlemeKayit.ShowDialog();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //sanaldatabase içerisine kayıt işlemi olacak...(ödev)
            //formTemizle();
        }
    }
}
