namespace TCPChat
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
            btnConnect = new Button();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Server IP Address ";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(132, 45);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(494, 23);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:3000";
            // 
            // DisplayChat
            // 
            DisplayChat.Location = new Point(30, 105);
            DisplayChat.Multiline = true;
            DisplayChat.Name = "DisplayChat";
            DisplayChat.ReadOnly = true;
            DisplayChat.ScrollBars = ScrollBars.Both;
            DisplayChat.Size = new Size(729, 258);
            DisplayChat.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(132, 392);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(494, 23);
            txtInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 395);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Write Meassage: ";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(650, 45);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(632, 392);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(127, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send Meassage";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(DisplayChat);
            Controls.Add(txtIP);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
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
        private Button btnConnect;
        private Button btnSend;
    }
}
