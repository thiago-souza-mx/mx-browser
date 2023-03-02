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

namespace WebAppMX
{
    public partial class App : Form
    {

        private bool mouseClicked;
        private Point clickedAt;
        private bool fullActive = false;
        private IniData app;
        private KeyDataCollection WINDOW;
        private KeyDataCollection SERVER;
        private KeyDataCollection SPLASH;
        private CGI cgi;
        private int _timerLoad = 0;
        private int _splashTime = 0;
        private string _splashText;

        private bool _loadBar = false;
        private Color _toolBarColor;
        private Color _toolBarFontColor;
        private int _height;
        private int _width;
        private int _fullSceen = 1;
        private Uri _source;
        private Image _windowIcon;
        private Image _splashIcon;
        private Icon _taskbarIcon;
        private string _appTitle;
        private int pid_server ;


        public App(IniData ini)
        {
            InitializeComponent();            
            cgi = new CGI(this);
            this.TopMost = false;

            // Initial definitions

            app = ini;
            WINDOW = app["WINDOW"];
            SERVER = app["SERVER"];
            SPLASH = app["SPLASH"];
            //TASKBAR = app["TASKBAR"];

            TimerLoad.Start();

            // Exceptions

            try 
            {
                if (SERVER["Start"] != null && SERVER["Name"] != null)
                {
                    CGI.Shell(SERVER["Start"]);
                    Process p = CGI.Shell($"Get-Process {SERVER["Name"]} | Select-Object -Property  Id, StartTime | ConvertTo-Json");

                    DateTime startTime = p.StartTime;
                    DateTime jstartTime ;

                    string output = p.StandardOutput.ReadToEnd();
                    dynamic json = JsonConvert.DeserializeObject(output);
                    CGI.LogInfo($"Servidor {SERVER["Name"]} Startado em : { SERVER["Start"]}");

                    try
                    {
                        foreach (var item in json)
                        {
                            jstartTime = item.StartTime;    
                            if(startTime.ToUniversalTime() <= jstartTime.ToUniversalTime() && startTime.ToUniversalTime().AddMinutes(2) >= jstartTime.ToUniversalTime())
                                pid_server = item.Id;
                        }
                    }
                    catch
                    {
                        pid_server = json.Id;
                    }

                    CGI.LogInfo($"PID do servidor {SERVER["Name"]}: {pid_server}");
                }
            } 
            catch(Exception e) {
                CGI.LogInfo("Servidor não inicado:" + e.Message);
            }

            try { _height           = int.Parse(WINDOW["Height"]);      } catch { _height = this.Height; }
            try { _width            = int.Parse(WINDOW["Width"]);       } catch { _width = this.Width; }
            try { _toolBarColor     = ColorTranslator
                                      .FromHtml(WINDOW["ToolBarColor"]);} catch { _toolBarColor = this.BackColor; }
            try { _fullSceen        = int.Parse(WINDOW["FullScreen"]);  } catch { }
            try { _source           = new Uri(WINDOW["Source"]);        } catch { _source = Browser.Source; }
            try { _windowIcon       = Image.FromFile(WINDOW["Icon"]);   } catch { _windowIcon = ToolBarLogo.Image; }
            try { _splashIcon       = Image.FromFile(SPLASH["Icon"]);   } catch { _splashIcon = _windowIcon; }
            try { _splashTime       = int.Parse(SPLASH["Timer"]) 
                                       * TimerLoad.Interval;            } catch { _splashTime = 5; }
            try { _loadBar          = bool.Parse(SPLASH["LoadBar"]);    } catch { }
            try { _splashText       = SPLASH["Text"];                   } catch { }


            // Variables declare

            _appTitle = WINDOW["Title"] ?? AppTitle.Text;
            _toolBarFontColor = MinusButton.ForeColor;

            Bitmap icon = (Bitmap) CGI.SquareImage(_windowIcon);
            _taskbarIcon = Icon.FromHandle((icon).GetHicon());

            // Atribuitions components

            MaxiButton.FlatAppearance.MouseOverBackColor  = Theme(_toolBarColor, 0.3f);
            MinusButton.FlatAppearance.MouseOverBackColor = Theme(_toolBarColor, 0.3f);
            CloseButton.FlatAppearance.MouseOverBackColor = Theme(_toolBarColor, 0.3f); 
            
            MaxiButton.BackgroundColor  = _toolBarColor;
            MinusButton.BackgroundColor = _toolBarColor;
            CloseButton.BackgroundColor = _toolBarColor;

            MaxiButton.IconColor = Theme(_toolBarFontColor, 1, 0.55f);
            MinusButton.IconColor = Theme(_toolBarFontColor, 1, 0.55f);
            CloseButton.IconColor = Theme(_toolBarFontColor, 1, 0.55f);

            Browser.Source = _source;
            ToolBar.BackColor = _toolBarColor;
            AppTitle.Text = _appTitle;
            ToolBarLogo.Image = _windowIcon;
            ToolBarLogo.Size = new Size(_windowIcon.Width * ToolBarLogo.MaximumSize.Height / _windowIcon.Height, ToolBarLogo.MaximumSize.Height);

            CenterLogo.BackColor = _toolBarColor;
            CenterLogo.Image = _splashIcon;

            LoadBar.Visible = _loadBar;
            SplahText.Text = _splashText;

            // Atribuitions App

            this.Text = _appTitle;
            this.Height = _height;
            this.Width = _width;
            this.Icon = _taskbarIcon;
            this.BackColor = _toolBarColor;

            ChangeStyleComponent();
            Browser.InitializeAsync();
        }

        private void ChangeStyleComponent()
        {
            switch (_fullSceen)
            {
                case 0:
                    MaxiButton.Visible = false;
                    break;
                case 1:
                    this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
                    break;
                case 2:
                    this.MaximumSize = Screen.FromControl(this).Bounds.Size;
                    break;
            }
        }

        private void App_Load(object sender, EventArgs e)
        {
        }

        private void App_Loaded(object sender, EventArgs e)
        {
            _timerLoad+=1;
            if(_loadBar)
                LoadColor.Width = (LoadBar.Width / _splashTime) * _timerLoad;

            if ( _timerLoad == _splashTime ) { 
                Browser.Visible = true;
                LoadBar.Visible = false;
                SplahText.Visible = false;
                TimerLoad.Stop();
                TimerLoad.Enabled = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void MinusButton_Click(object sender, EventArgs e)
        {
            await cgi.Minimize(!fullActive);
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxiButton_Click(object sender, EventArgs e)
        {
            ChangeStyleComponent();

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                fullActive = false;
                MaxiButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                fullActive = true;
                MaxiButton.IconChar = FontAwesome.Sharp.IconChar.Minimize;
            }
        }

        private async void App_Minimize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized) { 
                 await cgi.Minimize(!fullActive);
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private async void App_Restore(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)            
                await cgi.Maximize(!fullActive);
            else if(this.WindowState == FormWindowState.Normal)
                await cgi.Maximize(!fullActive);
        }
        
        private async void App_Closing(object sender, EventArgs e)
        {
            CGI.LogInfo("Fechando");
            if(pid_server > 0)
            {
                Process process= Process.GetProcessById(pid_server);
                try
                {
                    process.Kill();
                    CGI.LogInfo($"Servidor PID {pid_server} Finalizado");
                }
                catch (Exception ex) { 
                    CGI.LogInfo(ex.Message);
                }
            }
            CGI.LogInfo("----");

        }

        private void ToolBar_MouseMove(object sender, EventArgs e)
        {
            int Top = Cursor.Position.Y - clickedAt.Y;
            int Left = Cursor.Position.X - clickedAt.X;
            if (mouseClicked)
            {
                this.Location = new Point(Left, Top);
            }
        }

        private void ToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void ToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeStyleComponent();
            int Top = Cursor.Position.Y - clickedAt.Y;
            int Left = Cursor.Position.X - clickedAt.X;
            int Right = (Cursor.Position.X - clickedAt.X) + this.Width;
            int WorkingWidth = Screen.FromControl(this).WorkingArea.Width;
            int WorkingLeft = Screen.FromControl(this).WorkingArea.Left;
            bool negative = false;

            if (mouseClicked)
            {
                if (Right < this.Width)
                {
                    Right = WorkingWidth + Right;
                    negative = true;
                }

                if (Top < 0)
                {
                    Top = 0;
                    this.Height = Screen.FromControl(this).WorkingArea.Height;
                }
                else
                {
                    this.Height = _height;
                }

                if (Right > WorkingWidth)
                {
                    Left = negative ? this.Width * -1 : WorkingWidth - this.Width;
                }

                if (Left < WorkingLeft)
                    Left = WorkingLeft;

                this.Location = new Point(Left, Top);

            }
            mouseClicked = false;
        }

        private Color Theme(Color color, float perc, float param = 0.2f )
        {
            Color theme;            

            if (_toolBarColor.GetBrightness() >= param)
                theme = ControlPaint.Dark(color, -perc);
            else
                theme = ControlPaint.Light(color, perc);
            return theme;
        }
    }
}

