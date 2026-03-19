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
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이하로 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string time_stamp = DateTime.Now.ToString("HH:mm:ss");
            tboListBox.Items.Add($"[{time_stamp}] {typed_msg}");
            lblCount.Text = $"현재 대화: {tboListBox.Items.Count}개";
            txtInput.Clear();
            txtInput.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tboListBox.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 항목을 먼저 선택해주세요.", "선택 없음", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tboListBox.Items.RemoveAt(tboListBox.SelectedIndex);
            lblCount.Text = $"현재 대화: {tboListBox.Items.Count}개";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tboListBox.Items.Clear();
            lblCount.Text = "현재 대화: 0개";
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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
