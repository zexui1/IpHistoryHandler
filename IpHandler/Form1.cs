using System.Diagnostics;
using System.Text.Json;

namespace IpHandler
{
    public partial class IpHistory : Form
    {
        static readonly HttpClient _httpClient = new HttpClient();
        string accessurl = "https://api.myip.com";

        List<Ip> ips = new List<Ip>();

        public IpHistory()
        {
            InitializeComponent();
            Main();
        }

        private async void Main()
        {
            ips = StorageHandler.ReadDataInStorage();
            CurrentIpUpdater();
        }

        private async void CurrentIpUpdater()
        {
            Ip ip = await Task.Run(() => GetIp());
            CurrentIp.Text = ip.ip;

            if (!PrevIps.Items.Contains(ip.ip))
            {
                PrevIps.Items.Add(ip.ip);
            }

            if (!ips.Any(x => x.ip == ip.ip))
            {
                ips.Add(ip);
            }
        }


        private async Task<Ip> GetIp()
        {
            string ResponseBody = await _httpClient.GetStringAsync(accessurl);

            Ip ip = JsonSerializer.Deserialize<Ip>(ResponseBody);

            return ip;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            CurrentIpUpdater();
        }

        private void IpHistory_FormClosing(object sender, FormClosingEventArgs e)
        {

            StorageHandler.SaveDataInStorage(ips);
        }

        private void IpHistory_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                MinimizeIcon.Visible = true;
            }
        }

        private void MinimizeIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            MinimizeIcon.Visible = false;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program helps you keep track of your ip, it stores what your previous ips have been and what your current ip is.\nThis way you can know if your ip changed and what is changed from and to.\nIt has a button to manually refresh incase you want to check if it changed while you pc is running.\nBut it will auto-refresh when you start up your computer.");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to clear the history of all your ips?", "Confirm delete!", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                StorageHandler.ClearDataInStorage();
                ips.Clear();
                PrevIps.Items.Clear();
            }
        }
    }
}