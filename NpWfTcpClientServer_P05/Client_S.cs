using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NpWfTcpClientServer_P05
{
    public partial class Client_S : Form
    {
        TcpClient client;
        public Client_S()
        {
            InitializeComponent();
            tbIP.Text = "127.0.0.1";
            tbPort.Text = "1234";

            regLogin.Enabled = false;
            regPassword.Enabled = false;
            logLogin.Enabled = false;
            logPassword.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbIP.Enabled = false;
            tbPort.Enabled = false;
            try
            {
                var endPoint = new IPEndPoint(IPAddress.Parse(tbIP.Text), int.Parse(tbPort.Text));
                client = new TcpClient();
                client.Connect(endPoint);
                //var stream = client.GetStream();
                //var buffer = Encoding.Unicode.GetBytes(tbMessage.Text);
                //stream.Write(buffer, 0, buffer.Length);

                var writer = new StreamWriter(client.GetStream(), Encoding.Unicode);
                writer.Write($"LOG:{regLogin.Text} PAS:{regPassword.Text} MSG:{tbMessage.Text}");
                
                writer.Flush();
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            regLogin.Enabled = true;
            regPassword.Enabled = true;
            logLogin.Enabled = false;
            logPassword.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logLogin.Enabled = true;
            logPassword.Enabled = true;
            regLogin.Enabled = false;
            regPassword.Enabled = false;
        }

        private void okRegButton_Click(object sender, EventArgs e)
        {
           
        }

        private void okLogButton_Click(object sender, EventArgs e)
        {

        }
    }

}