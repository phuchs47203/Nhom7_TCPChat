namespace TCPChat_Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIP = new TextBox();
            DisplayChat = new TextBox();
            txtInput = new TextBox();
            label2 = new Label();
            btnStart = new Button();
            btnSend = new Button();
            lstClientConnted = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Server: ";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(132, 48);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(494, 23);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:3000";
            // 
            // DisplayChat
            // 
            DisplayChat.Location = new Point(132, 105);
            DisplayChat.Multiline = true;
            DisplayChat.Name = "DisplayChat";
            DisplayChat.ReadOnly = true;
            DisplayChat.ScrollBars = ScrollBars.Both;
            DisplayChat.Size = new Size(494, 258);
            DisplayChat.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(132, 392);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(494, 25);
            txtInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 397);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Write Meassage: ";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(641, 45);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(152, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start Server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(645, 386);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(148, 35);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send Message";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lstClientConnted
            // 
            lstClientConnted.FormattingEnabled = true;
            lstClientConnted.ItemHeight = 15;
            lstClientConnted.Location = new Point(671, 105);
            lstClientConnted.Name = "lstClientConnted";
            lstClientConnted.Size = new Size(247, 259);
            lstClientConnted.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(779, 87);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 8;
            label3.Text = "List of Client connecting:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 450);
            Controls.Add(label3);
            Controls.Add(lstClientConnted);
            Controls.Add(btnSend);
            Controls.Add(btnStart);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(DisplayChat);
            Controls.Add(txtIP);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private TextBox DisplayChat;
        private TextBox txtInput;
        private Label label2;
        private Button btnStart;
        private Button btnSend;
        private ListBox lstClientConnted;
        private Label label3;
    }
}
