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
        }

        private void formElemanIndexTemizle()
        {
            throw new NotImplementedException();
        }

        private void formTemizle()
        {
            throw new NotImplementedException();
        }
    }
}
