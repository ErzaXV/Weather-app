using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
namespace Weather_app
{
    public partial class Form1 : Form
    {
        bool mousedown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            getinfo();
        }

        private async void getinfo()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apikey = "b7f222402e23fabddc47fd8f65ab76c6";
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={Countrytxtbox.Text}&appid={apikey}";
                    var json = await client.GetStringAsync(url);
                    Info.root info = JsonConvert.DeserializeObject<Info.root>(json);

                    pictureBox1.ImageLocation = "http://openweathermap.org/img/wn/" + info.weather[0].icon + "@2x.png";
                    labelcondition.Text = info.weather[0].main;
                    labeldetails.Text = info.weather[0].description;
                    labelsunrise.Text = convertdatetime(info.sys.sunrise).ToString();
                    labelsunset.Text = convertdatetime(info.sys.sunset).ToString();
                    labelwindspeed.Text = info.wind.speed.ToString();
                    labelpressure.Text = info.main.pressure.ToString();
                    tempCel_lable.Text = convertktoc(info.main.temp).ToString().Substring(0, 4);
                    TempK_label.Text = info.main.temp.ToString().Substring(0, 5);
                    TempF_label.Text = convertktof(info.main.temp).ToString().Substring(0, 5);
                    CountryLabel.Text = info.sys.country.ToString();
                    latlabel.Text = info.coord.lat.ToString();
                    lonlabel.Text = info.coord.lon.ToString();

                }
            }
            catch
            {
                MessageBox.Show("Enter the correct city name!");
            }
        }

        DateTime convertdatetime2(long sec)
        {
            DateTimeOffset dto = DateTimeOffset.FromUnixTimeSeconds(sec);
            return dto.LocalDateTime;
        }


        DateTime convertdatetime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }

        double convertktoc(double temp)
        {
            return temp - 273.15;
        }

        double convertktof(double temp)
        {
            double fahrenheit = (temp - 273.15) * 1.8 + 32;
            return fahrenheit;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Mouseup_event(object sender, MouseEventArgs e)
        {

            mousedown = false;
        }

        private void Mousemove_event(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void Mousedown_event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Countrytxtbox.Clear();
        }
    }
}
