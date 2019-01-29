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
            // TODO: Bu kod satırı 'sempozyumDatabase1.kullanıcı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcıTableAdapter1.Fill(this.sempozyumDatabase1.kullanıcı);
            // TODO: Bu kod satırı 'sempozyumDatabase1.sempozyum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sempozyumTableAdapter1.Fill(this.sempozyumDatabase1.sempozyum);
            

        }

       
    }
}
