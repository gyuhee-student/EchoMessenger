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
            string typed_msg = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(typed_msg))
                return;
            string time_stamp = DateTime.Now.ToString("HH:mm:ss");
            tboListBox.Items.Add($"[{time_stamp}] {typed_msg}");
            lblCount.Text = $"현재 대화: {tboListBox.Items.Count}개";
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
