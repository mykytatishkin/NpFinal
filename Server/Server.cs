using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;

namespace Server
{
    public partial class Server : Form
    {
        TcpListener listener;
        public Server()
        {
            InitializeComponent();
            tbIP_Server.Text = "127.0.0.1";
            tbPort_Server.Text = "1234";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void tbIP_Server_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbPort_Server_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            tbIP_Server.Enabled = false;
            tbPort_Server.Enabled = false;
            try
            {
                listener = new TcpListener(IPAddress.Parse(tbIP_Server.Text), int.Parse(tbPort_Server.Text));
                listener.Start();
                startButton.Enabled = false;
                _ = WaitForConnectionAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    
        async Task WaitForConnectionAsync()
        {
            while (true)
            {
                var cl = await listener.AcceptTcpClientAsync();
                _ = HandleClientAsync(cl);
            }

        }
        async Task HandleClientAsync(TcpClient client)
        {
            var reader = new StreamReader(client.GetStream(), Encoding.Unicode);
            string msg = await reader.ReadToEndAsync();

            Dictionary<string,string> auth = new Dictionary<string, string>();


            lbMessages.Items.Add(msg);
            client.Close();
            if (msg.ToLower() == "exit")
            {
                listener.Stop();
                Close();
            }
        }
    }
 
}