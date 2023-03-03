using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Diagnostics;
using System.Dynamic;
using System.Windows.Forms;
using IniParser.Model;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core;
using WebAppMX.Properties;
using System.Resources;
using System.Drawing;
using Newtonsoft.Json;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using WebAppMX.Custom;

namespace WebAppMX
{
    public partial class SplashForm : Form
    {
        App App;

        public IniData app;
        public KeyDataCollection WINDOW;
        public KeyDataCollection SERVER;
        public KeyDataCollection SPLASH;
        public int _timerLoad = 0;
        public int _splashTime = 0;
        public string _splashText;
        public bool _splashOpen = false;

        public bool _loadBar = false;
        public Color _toolBarColor;
        public Color _toolBarFontColor;
        public Image _splashIcon;
        public Icon _taskbarIcon;
        public int _radius = 0;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public SplashForm(IniData ini)
        {
            App = new App(ini, this);
            InitializeComponent();
            
            // Initial definitions

            app = ini;
            WINDOW = app["WINDOW"];
            SERVER = app["SERVER"];
            SPLASH = app["SPLASH"];

            // Exceptions

            try
            {
                if (SERVER["Start"] != null && SERVER["Name"] != null)
                {
                    CGI.Shell(SERVER["Start"]);
                    Process p = CGI.Shell($"Get-Process {SERVER["Name"]} | Select-Object -Property  Id, StartTime | ConvertTo-Json");

                    DateTime startTime = p.StartTime;
                    DateTime jstartTime;

                    string output = p.StandardOutput.ReadToEnd();
                    dynamic json = JsonConvert.DeserializeObject(output);
                    CGI.LogInfo($"Servidor {SERVER["Name"]} Startado em : {SERVER["Start"]}");

                    try
                    {
                        foreach (var item in json)
                        {
                            jstartTime = item.StartTime;
                            if (startTime.ToUniversalTime() <= jstartTime.ToUniversalTime() && startTime.ToUniversalTime().AddMinutes(2) >= jstartTime.ToUniversalTime())
                                App.pid_server = item.Id;
                        }
                    }
                    catch
                    {
                        App.pid_server = json.Id;
                    }

                    CGI.LogInfo($"PID do servidor {SERVER["Name"]}: {App.pid_server}");
                }
            }
            catch (Exception e)
            {
                CGI.LogInfo("Servidor não inicado:" + e.Message);
            }

            try { _toolBarColor = ColorTranslator
                                    .FromHtml(WINDOW["ToolBarColor"]);  } catch { _toolBarColor = this.BackColor; }
            try { _splashIcon   = Image.FromFile(SPLASH["Icon"]);       } catch { _splashIcon = App.ToolBarLogo.Image; }
            try { _splashTime   = (int.Parse(SPLASH["Timer"])
                                       * 1000) / TimerLoad.Interval;    } catch { _splashTime = 5; }
            try { _loadBar      = bool.Parse(SPLASH["LoadBar"]);        } catch { }
            try { _splashText   = SPLASH["Text"];                       } catch { }
            try { _splashOpen   = bool.Parse(SPLASH["Open"]);           } catch { }
            try { _radius       = int.Parse(SPLASH["Radius"]);          } catch { }


            CenterLogo.BackColor = _toolBarColor;
            CenterLogo.Image = _splashIcon;

            LoadBar.Visible = _loadBar;
           // LoadBar.BackColor = App.Theme(LoadBar.BackColor, 1, 0.55f);
            LoadColor.BackColor = App.Theme(LoadColor.BackColor, 1, 0.55f);
            SplahText.Text = _splashText;
            SplahText.ForeColor = App.Theme(SplahText.ForeColor, 1, 0.55f);

            // Atribuitions App
            Bitmap icon = (Bitmap)CGI.SquareImage(_splashIcon);
            _taskbarIcon = Icon.FromHandle((icon).GetHicon());
            this.BackColor = _toolBarColor;
            this.Icon = _taskbarIcon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(App.App_Closing);

            if(_radius > 0 )
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));

            TimerLoad.Start();      

        }       


        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void App_Loaded(object sender, EventArgs e)
        {
            if (_splashOpen)
            {
                this.Opacity = 1;
                _timerLoad += 1;
                if (_loadBar)
                {
                    int c = (int)Math.Round(0.75 * _timerLoad);
                    LoadColor.Width = (int)Math.Round((2.4 * _timerLoad));
                    CounterLoad.Text = (c<=100 ? c : 100).ToString() + "%";
                }

                if (_timerLoad == _splashTime)
                {
                    Task.Delay(1000).Wait();
                    TimerLoad.Stop();
                    AppOpen();
                }
            }
            else
            {
                TimerLoad.Stop();
                AppOpen();
            }
        }

        private void AppOpen()
        {
            if (_splashOpen)
            {
                while (this.Opacity > 0)
                {
                    Task.Delay(1).Wait();
                    this.Opacity -= 0.1;
                }
                this.Hide();
                Task.Delay(1000).Wait();
            }
            else { 
                this.Hide();
            }

            App.Opacity = 0;
            App.Show();
            while (App.Opacity < 1)
            {
                Task.Delay(1).Wait();
                App.Opacity += 0.1;
            }
            App.Opacity = 1;
        }
    }
}

