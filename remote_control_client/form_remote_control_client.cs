using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace remote_control_client
{
    public partial class form_remote_control_client : Form
    {
        public form_remote_control_client()
        {
            InitializeComponent();
        }

        TcpListener mytcpl;
        Socket mysocket;
        NetworkStream myns;

        Thread myth;

        private void b_sent_message_Click(object sender, EventArgs e)
        {
            if (lb_list_servers.SelectedIndex != -1)
            {
                string s = "<Message><StartCaption>" + tb_caption_message.Text + "<EndCaption><StartText>" + tb_text_message.Text + "<EndText>";
                sent_arg(s);
            }
        }

        private void form_remote_control_client_Load(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"rcc.log", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            while (s != null)
            {
                lb_log.Items.Add(s);
                s = sr.ReadLine();
            }
            lb_log.SelectedIndex = lb_log.Items.Count - 1;
            sr.Close();
            fs.Close();

            Control.CheckForIllegalCrossThreadCalls = false;

            myth = new Thread(new System.Threading.ThreadStart(our_Server));
            myth.Start();
        }

        void our_Server()
        {
            try
            {
                mytcpl = new TcpListener(32);
                mytcpl.Start();
                mysocket = mytcpl.AcceptSocket();
                myns = new NetworkStream(mysocket);
                byte[] buffer = new byte[1024];
                myns.Read(buffer, 0, 1024);
                MemoryStream ms = new MemoryStream(buffer);

                string s = new StreamReader(ms).ReadToEnd();
                lb_log.Items.Add(s);
                lb_log.SelectedIndex = lb_log.Items.Count - 1;
                FileStream fs = new FileStream(@"rcc.log", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Close();
                fs.Close();

                mytcpl.Stop();

                if (mysocket.Connected == true)
                {
                    while (true)
                    {
                        our_Server();
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void form_remote_control_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                mytcpl.Stop();
                myth.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_update_server_Click(object sender, EventArgs e)
        {
            if (lb_list_servers.SelectedIndex != -1)
            {
                sent_arg("<Update>");
            }
        }

        public void sent_arg(string s)
        {
            try
            {
                string ip_comp = lb_list_servers.Items[lb_list_servers.SelectedIndex].ToString();
                ip_comp = ip_comp.Remove(0, ip_comp.IndexOf('(') + 1);
                ip_comp = ip_comp.Remove(ip_comp.Length - 1, 1);
                TcpClient myclient = new TcpClient(ip_comp, 23);
                NetworkStream myns = myclient.GetStream();
                MemoryStream ms = new MemoryStream();

                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(s);
                ms.Write(buffer, 0, buffer.Length);

                myns.Write(ms.ToArray(), 0, ms.ToArray().Length);
                myns.Close();
                myclient.Close();

            }
            catch (Exception ex)
            {
                lb_log.Items.Add(ex.Message);
                lb_log.SelectedIndex = lb_log.Items.Count - 1;
                FileStream fs = new FileStream(@"rcc.log", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(ex.Message);
                sw.Close();
                fs.Close();
            }
        }

        private void b_reserve_internet_Click(object sender, EventArgs e)
        {
            if (lb_list_servers.SelectedIndex != -1)
            {
                sent_arg("<ReserveInternet>");
            }
        }

        private void b_primary_internet_Click(object sender, EventArgs e)
        {
            if (lb_list_servers.SelectedIndex != -1)
            {
                sent_arg("<PrimaryInternet>");
            }
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            if (lb_list_servers.SelectedIndex != -1)
            {
                sent_arg("<Check>");
            }
        }

        private void tsmi_open_log_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.FileName = "rcc.log";
            pr.Start();
        }

        private void b_screenshot_Click(object sender, EventArgs e)
        {
            if (lb_list_servers.SelectedIndex != -1)
            {
                sent_arg("<Screen>");
            }
        }
    }
}
