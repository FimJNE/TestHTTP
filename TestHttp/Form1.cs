using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

// http://stackoverflow.com/questions/4015324/http-request-with-post
// Task + continue with

namespace TestHttp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private async void SendPost()
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                   { "thing1", "hello" },
                   { "thing2", "world" }
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

                var responseString = await response.Content.ReadAsStringAsync();
            }
        }

        private void SendGet()
        {
            using (var client = new HttpClient())
            {
                var responseString = client.GetStringAsync("http://www.example.com/recepticle.aspx");
            }
        }

    }
}
