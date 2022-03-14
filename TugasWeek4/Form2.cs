using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek4
{
    public partial class formTampilanData : Form
    {
        public string[,] dataArray { get; set; }
        public string erorMsg;
        int nomorData = 0;


        public formTampilanData()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nomorData < 9)
                nomorData++;
            else
            {
                erorMsg = "Data sudah data terakir";
                eror();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (nomorData > 0)
                nomorData--;
            else
            {
                erorMsg = "Data sudah data pertama";
                eror();
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNama.Text = dataArray[nomorData, 0];
            txtAlamat.Text = dataArray[nomorData, 1];
            txtTelp.Text = dataArray[nomorData, 2];
        }

        public void eror()
        {
            FormError formError = new FormError();
            formError.erorMsg = erorMsg;
            formError.ShowDialog();
        }
    }
}
