using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arayüz2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'denemeDataSet.kullanıcı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcıTableAdapter.Fill(this.denemeDataSet.kullanıcı);
            // TODO: Bu kod satırı 'denemeDataSet.sempozyum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sempozyumTableAdapter.Fill(this.denemeDataSet.sempozyum);

        }

       
    }
}
