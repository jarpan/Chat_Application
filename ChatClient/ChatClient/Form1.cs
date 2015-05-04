using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ChatRemote;
namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = textBox3.Text;
            label2.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;

            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
        }
        TcpChannel chan = new TcpChannel();
        RemoteClass obj;
        private void Form1_Load(object sender, EventArgs e)
        {
            ChannelServices.RegisterChannel(chan, false);
            obj = (RemoteClass)Activator.GetObject(typeof(RemoteClass), "tcp://localhost:1234/Multi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetMsg(this.Text, textBox2.Text);
            }
            else
            {
                textBox1.Text = "No Service Found";
            }
            textBox2.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = obj.GetMsg();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

       
      
    }
}
