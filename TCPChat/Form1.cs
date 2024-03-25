using SuperSimpleTcp;
using System.Text;

namespace TCPChat
{
    public partial class Form1 : Form
    {
        SimpleTcpClient tcpClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Connect();
                btnSend.Enabled = true; 
                btnConnect.Enabled = false;
            }
            catch(Exception ec) { 
                MessageBox.Show(ec.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // kieemr tra xem đã kết nôi chauw thì mới gửi được tin nhắn
            if(tcpClient.IsConnected)
            {
                tcpClient.Send(txtInput.Text);
                DisplayChat.Text += $"You: {txtInput.Text}{Environment.NewLine}";
                txtInput.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpClient = new(txtIP.Text);
            tcpClient.Events.Connected += Events_Connected;
            tcpClient.Events.DataReceived += Events_DataReceived;
            tcpClient.Events.Disconnected += Events_Disconnected;

            //không cho gửi khi chưa kết nối
            btnSend.Enabled = false;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                DisplayChat.Text += $"Disconnencted.{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                DisplayChat.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                DisplayChat.Text += $"Connect Successfully.{Environment.NewLine}";
            });
        }
    }
}
