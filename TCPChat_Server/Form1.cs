using SuperSimpleTcp;
using System.Text;

namespace TCPChat_Server
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            DisplayChat.Text += $"Server is running...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // lấy dữ liệu nhận được bỏ vào ô text
                DisplayChat.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // hiện log
                DisplayChat.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";

                // xóa địa chỉ ip hiển thị khi không kết nối đến đó
                lstClientConnted.Items.Remove(e.IpPort);
            });
            
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // hiện log
                DisplayChat.Text += $"{e.IpPort} connected.{Environment.NewLine}";

                // xóa địa chỉ ip hiển thị khi không kết nối đến đó
                lstClientConnted.Items.Add(e.IpPort);
            });
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(server.IsListening)
            {
                // kieemr tra thoong tin truocs khi gửi
                if(!string.IsNullOrEmpty(txtInput.Text) && lstClientConnted.SelectedItem != null)
                {
                    server.Send(lstClientConnted.SelectedItem.ToString(),txtInput.Text);
                    DisplayChat.Text += $"Server: {txtInput.Text}{Environment.NewLine}";
                    // gửi thành công thì xóa dữ liệu trong ô nhập
                    txtInput.Text = string.Empty;
                }    
            }
        }
    }
}
