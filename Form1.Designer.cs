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
            tboListBox = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(40, 43);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            lblTitle.Click += lblTitle_Click;
            // 
            // tboListBox
            // 
            tboListBox.Font = new Font("맑은 고딕", 11F);
            tboListBox.Location = new Point(40, 149);
            tboListBox.Margin = new Padding(6);
            tboListBox.Name = "tboListBox";
            tboListBox.Size = new Size(1116, 604);
            tboListBox.TabIndex = 1;
            tboListBox.SelectedIndexChanged += tboListBox_SelectedIndexChanged;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 11F);
            txtInput.Location = new Point(40, 832);
            txtInput.Margin = new Padding(6);
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
            btnSend.Margin = new Padding(6);
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
            Controls.Add(tboListBox);
            Controls.Add(txtInput);
            Controls.Add(btnSend);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox tboListBox;
        private TextBox txtInput;
        private Button btnSend;
    }
}
