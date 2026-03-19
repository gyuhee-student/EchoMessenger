namespace EchoMessenger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lstMessages = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Text = "Echo Messenger";

            // lstMessages
            lstMessages.Font = new Font("맑은 고딕", 11F);
            lstMessages.Location = new Point(20, 70);
            lstMessages.Size = new Size(560, 300);

            // txtInput
            txtInput.Font = new Font("맑은 고딕", 11F);
            txtInput.Location = new Point(20, 390);
            txtInput.Size = new Size(430, 30);

            // btnSend
            btnSend.BackColor = Color.Lime;
            btnSend.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnSend.Location = new Point(460, 385);
            btnSend.Size = new Size(120, 40);
            btnSend.Text = "전송";
            btnSend.Click += new EventHandler(btnSend_Click);

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(620, 450);
            Controls.Add(lblTitle);
            Controls.Add(lstMessages);
            Controls.Add(txtInput);
            Controls.Add(btnSend);
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstMessages;
        private TextBox txtInput;
        private Button btnSend;
    }
}
