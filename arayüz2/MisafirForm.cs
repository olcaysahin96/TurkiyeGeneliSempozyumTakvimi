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
    public partial class MisafirForm : Form
    {
        public MisafirForm()
        {
            InitializeComponent();
        }

        private void MisafirForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'denemeDataSet.görüs' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.görüsTableAdapter.Fill(this.denemeDataSet.görüs);
            // TODO: Bu kod satırı 'denemeDataSet.sempozyum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sempozyumTableAdapter.Fill(this.denemeDataSet.sempozyum);

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
