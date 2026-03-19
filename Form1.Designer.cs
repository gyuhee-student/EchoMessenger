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
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(40, 43);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            lblTitle.Click += lblTitle_Click;
            // 
            // lstMessages
            // 
            lstMessages.Font = new Font("맑은 고딕", 11F);
            lstMessages.Location = new Point(40, 149);
            lstMessages.Margin = new Padding(6, 6, 6, 6);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(1116, 604);
            lstMessages.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 11F);
            txtInput.Location = new Point(40, 832);
            txtInput.Margin = new Padding(6, 6, 6, 6);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(856, 47);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Lime;
            btnSend.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnSend.Location = new Point(920, 821);
            btnSend.Margin = new Padding(6, 6, 6, 6);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(240, 85);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1240, 960);
            Controls.Add(lblTitle);
            Controls.Add(lstMessages);
            Controls.Add(txtInput);
            Controls.Add(btnSend);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
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
