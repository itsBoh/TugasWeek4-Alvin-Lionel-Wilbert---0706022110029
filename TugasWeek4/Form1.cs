namespace TugasWeek4
{
    public partial class FormPenambahanData : Form
    {
        public string[,] dataArray = new string[10,3];
        public string erorMsg = "Data telah penuh!";
        int nomorData = 0;
        public FormPenambahanData()
        {
            InitializeComponent();
        }
        private void btnSImpan_Click(object sender, EventArgs e)
        {
            if (nomorData > 9)
            {
                FormError formError = new FormError();
                formError.erorMsg = erorMsg;
                formError.ShowDialog();
            }
            else
            {
                dataArray[nomorData, 0] = txtNama.Text;
                dataArray[nomorData, 1] = txtAlamat.Text;
                dataArray[nomorData, 2] = txtTelp.Text;
                nomorData++;
                normal();
            }
        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            formTampilanData frm = new formTampilanData();
            frm.dataArray = dataArray;
            frm.ShowDialog();
        }
        private void normal()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelp.Text = ""; 
        }
    }
}