using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            btnNormalExecute.Click += BtnNormalExecute_Click;
            btnAsyncExecute.Click += BtnAsyncExecute_Click;
            btnParallelAsyncExecute.Click += BtnParallelAsyncExecute_Click;
        }

        private async void BtnParallelAsyncExecute_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            txtProgress.Text = "";
            txtProgress.Font = new Font("", 12);

            await RunDownloadDataAsyncParallel();

            timer.Stop();

            txtProgress.Text += $"Total Runtime duration is {timer.ElapsedMilliseconds} milliseconds";
        }

        private async void  BtnAsyncExecute_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            txtProgress.Text = "";
            txtProgress.Font = new Font("", 12);

            await RunDownloadDataAsync();

            timer.Stop();

            txtProgress.Text += $"Total Runtime duration is {timer.ElapsedMilliseconds} milliseconds";
        }

        private void BtnNormalExecute_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            txtProgress.Text = "";
            txtProgress.Font = new Font("", 12);

            RunDownloadData();

            timer.Stop();

            txtProgress.Text += $"Total Runtime duration is {timer.ElapsedMilliseconds} milliseconds";
        }

        private void RunDownloadData()
        {
            var websites=PrepareData();
            foreach (var website in websites)
            {
                var websiteModel=downloadWebsite(website);

                reportWebsiteData(websiteModel);
            }
        }

        private async Task RunDownloadDataAsync()
        {
            var websites = PrepareData();
            foreach (var website in websites)
            {
                var websiteModel =await Task.Run(()=> downloadWebsite(website));

                reportWebsiteData(websiteModel);
            }
        }
        private async Task RunDownloadDataAsyncParallel()
        {
            var websites = PrepareData();
            List<Task< WebsiteDataModel >> tasks=new List<Task< WebsiteDataModel > >();
            foreach (var website in websites)
            {
                //tasks.Add(Task.Run(()=> downloadWebsite(website)));
                tasks.Add(downloadWebsiteAsync(website));

            }
            var results=await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                reportWebsiteData(item);
            }
        }

        private void reportWebsiteData(WebsiteDataModel websiteModel)
        {
            txtProgress.Text += $"{websiteModel.WebsiteURL} is downloaded: {websiteModel.WebSiteData.Length} characters long {Environment.NewLine}";
        }

        private WebsiteDataModel downloadWebsite(string WebsiteURL)
        {
            WebClient client= new WebClient();
            var websiteData = client.DownloadString(WebsiteURL);
            var wesiteModel = new WebsiteDataModel(WebsiteURL,websiteData);
            return wesiteModel;
        }
        private async Task<WebsiteDataModel> downloadWebsiteAsync(string WebsiteURL)
        {
            WebClient client= new WebClient();
            var websiteData = await client.DownloadStringTaskAsync(WebsiteURL);
            var wesiteModel = new WebsiteDataModel(WebsiteURL,websiteData);
            return wesiteModel;
        }

        private List<string> PrepareData()
        {
            List<string> output = new List<string>();
            output.Add("https://www.yahoo.com/");
            output.Add("https://www.google.com/");
            output.Add("https://www.bbc.com/");
            output.Add("https://www.w3schools.com/");
            output.Add("https://www.tutorialspoint.com/");
            output.Add("https://www.tesla.com/");
            output.Add("https://www.yahoo.com/");
            output.Add("https://www.google.com/");
            output.Add("https://www.bbc.com/");
            output.Add("https://www.w3schools.com/");
            output.Add("https://www.tutorialspoint.com/");
            output.Add("https://www.tesla.com/");

            return output;
        }
    }
}
