using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace OraiMunka
{
    public partial class FormAPP : Form
    {
        public FormAPP()
        {
            InitializeComponent();
        }

        private async void buttonLeft_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.randomuser.me");
                    var response = await client.GetAsync("https://api.randomuser.me");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawData = JsonConvert.DeserializeObject<Rootobject>(stringResult);
                    NameLabel.Text = String.Join(" ", "Name:", rawData.results[0].name.first + " " + rawData.results[0].name.last);
                    email.Text = String.Join(" ", "Email:", rawData.results[0].email);
                    pictureBox1.Load(rawData.results[0].picture.large.ToString());
                    pictureBox2.Load("https://robohash.org/" + rawData.results[0].name.first);
                    
                }

                catch (HttpRequestException httpRequestException)
                {
                    MessageBox.Show("Catched!");
                }
            }
        }

        private void WriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string row = NameLabel.Text + " || " + email.Text + "\n";
                File.AppendAllText("Tesztek.txt", row);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
