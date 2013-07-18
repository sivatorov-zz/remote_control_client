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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient myclient = new TcpClient(textBox1.Text, 185);
                NetworkStream myns = myclient.GetStream();
                MemoryStream ms = new MemoryStream();

                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(textBox2.Text);
                ms.Write(buffer, 0, buffer.Length);

                myns.Write(ms.ToArray(), 0, ms.ToArray().Length);
                myns.Close();
                myclient.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
