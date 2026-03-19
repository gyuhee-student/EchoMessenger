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
            lblCount = new Label();
            txtInput = new TextBox();
            btnSend = new Button();
            btnDelete = new Button();
            btnClearAll = new Button();
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
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("맑은 고딕", 10F);
            lblCount.Location = new Point(40, 770);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(191, 37);
            lblCount.TabIndex = 2;
            lblCount.Text = "현재 대화: 0개";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 11F);
            txtInput.Location = new Point(40, 832);
            txtInput.Margin = new Padding(6);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(856, 47);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
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
            // btnDelete
            // 
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(40, 920);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(240, 72);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "선택 삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.DodgerBlue;
            btnClearAll.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(300, 920);
            btnClearAll.Margin = new Padding(6);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(240, 72);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "전체 초기화";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1240, 1020);
            Controls.Add(lblTitle);
            Controls.Add(tboListBox);
            Controls.Add(lblCount);
            Controls.Add(txtInput);
            Controls.Add(btnSend);
            Controls.Add(btnDelete);
            Controls.Add(btnClearAll);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox tboListBox;
        private Label lblCount;
        private TextBox txtInput;
        private Button btnSend;
        private Button btnDelete;
        private Button btnClearAll;
    }
}
