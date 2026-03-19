namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += (s, e) => txtInput.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg = txtInput.Text;
            if (string.IsNullOrWhiteSpace(typed_msg))
                return;
            tboListBox.Items.Add(typed_msg);
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void tboListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
