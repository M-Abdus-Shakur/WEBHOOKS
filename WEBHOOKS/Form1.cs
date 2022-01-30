using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEBHOOKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void send(string url,string message,string botname)
        {
            connection.post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    botname
                },
                {
                    "content",
                    message
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            send("https://ptb.discord.com/api/webhooks/937250272118472724/yMfwEax4h_FfobLl_oVWaTac4GDtlgQi1Lb6vPon1hkxrnvzXw5N5D9x22oUrFb-FTBF", siticoneTextBox1.Text, "TEST BOT NAME");
        }
    }
}
