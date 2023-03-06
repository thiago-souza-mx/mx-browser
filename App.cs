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
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System;
using WebAppMX.Custom;
using System.Web;

namespace WebAppMX
{
    public partial class App : Form
    {
        SplashForm splashForm;
        public bool mouseClicked;
        public Point clickedAt;
        public bool fullActive = false;
        public IniData app;
        public KeyDataCollection WINDOW;
        public KeyDataCollection SERVER;
        public KeyDataCollection SPLASH;
        public KeyDataCollection SISTEM;
        public CGI cgi;
        public int _timerLoad = 0;
        public int _splashTime = 0;
        public string _splashText;
        public string _local_path;

        public bool _loadBar = false;
        public bool _loadApp = false;
        public bool _log = false;
        public bool _ctxMenu = false;
        public bool _startApi = false;
        public Color _toolBarColor;
        public Color _toolBarFontColor;
        public int _height;
        public int _width;
        public int _fullSceen = 1;
        public Uri _source;
        public Image _windowIcon;
        public Image _splashIcon;
        public Icon _taskbarIcon;
        public string _appTitle;
        public int _radius = 0;
        private bool Exiting = false;
        public int pid_server { get; set; }


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
        public App(IniData ini, SplashForm Main)
        {
            splashForm = Main;
            InitializeComponent();


            cgi = new CGI(this);
            this.TopMost = false;

            // Initial definitions
            app = ini;
            WINDOW = app["WINDOW"];
            SERVER = app["SERVER"];
            SPLASH = app["SPLASH"];
            SISTEM = app["SISTEM"];

            // Exceptions         

            try { _height = int.Parse(WINDOW["Height"]); } catch { _height = this.Height; }
            try { _width = int.Parse(WINDOW["Width"]); } catch { _width = this.Width; }
            try
            {
                _toolBarColor = ColorTranslator
                                      .FromHtml(WINDOW["ToolBarColor"]);
            }
            catch { _toolBarColor = this.BackColor; }
            try { _fullSceen = int.Parse(WINDOW["FullScreen"]); } catch { }
            try { _source = new Uri(WINDOW["Source"]); } catch { _source = Browser.Source; }
            try { _windowIcon = Image.FromFile(WINDOW["Icon"]); } catch { _windowIcon = ToolBarLogo.Image; }
            try { _radius = int.Parse(WINDOW["Radius"]); } catch { }
            try { _log = bool.Parse(SISTEM["Log"]); } catch { }
            try { _ctxMenu = bool.Parse(SISTEM["ContextMenu"]); } catch { }


            // Variables declare

            _appTitle = WINDOW["Title"] ?? AppTitle.Text;
            _toolBarFontColor = MinusButton.ForeColor;

            Bitmap icon = (Bitmap)CGI.SquareImage(_windowIcon);
            _taskbarIcon = Icon.FromHandle((icon).GetHicon());

            // Atribuitions components

            MaxiButton.FlatAppearance.MouseOverBackColor = Theme(_toolBarColor, 0.3f);
            MinusButton.FlatAppearance.MouseOverBackColor = Theme(_toolBarColor, 0.3f);
            CloseButton.FlatAppearance.MouseOverBackColor = Theme(_toolBarColor, 0.3f);

            MaxiButton.BackgroundColor = _toolBarColor;
            MinusButton.BackgroundColor = _toolBarColor;
            CloseButton.BackgroundColor = _toolBarColor;

            MaxiButton.IconColor = Theme(_toolBarFontColor, 1, 0.55f);
            MinusButton.IconColor = Theme(_toolBarFontColor, 1, 0.55f);
            CloseButton.IconColor = Theme(_toolBarFontColor, 1, 0.55f);

            Browser.Source = _source;
            Browser.BackColor = _toolBarColor;
            Browser.DefaultBackgroundColor = _toolBarColor;
            ToolBar.BackColor = _toolBarColor;
            AppTitle.Text = _appTitle;
            ToolBarLogo.Image = _windowIcon;
            ToolBarLogo.Size = new Size(_windowIcon.Width * ToolBarLogo.MaximumSize.Height / _windowIcon.Height, ToolBarLogo.MaximumSize.Height);


            // Atribuitions App

            this.Text = _appTitle;
            this.Height = _height;
            this.Width = _width;
            this.Icon = _taskbarIcon;
            this.BackColor = _toolBarColor;
            if (_radius > 0)
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));

            _local_path = Path.GetDirectoryName(Application.ExecutablePath);

            ChangeStyleComponent();
            string script = $@"{_local_path}\LoadDomScript.js";
            Browser.InitializeAsync(script);
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
            Browser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = _ctxMenu;
            Browser.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
        }

        private void CloseButton_Click(object sender, EventArgs e) => Window_Close();
        private void MinusButton_Click(object sender, EventArgs e) => Window_Minimize();
        private void MaxiButton_Click(object sender, EventArgs e) => Window_Maximize();

        private void CoreWebView2_SourceChanged(object? sender,
            CoreWebView2SourceChangedEventArgs e)
        {
            if (Browser.Source.ToString().IndexOf("#api?") > -1)
            {
                String query = Browser.Source.ToString().Split('?')[1];
                var api = HttpUtility.ParseQueryString(query);
                if (api.Get("method") != null)
                {
                    String method = api.Get("method");
                    if (api.Get("parameters") != null) {
                        dynamic parameters = JsonConvert.DeserializeObject(api.Get("parameters"));
                        Dispatch(method, parameters);
                    }
                    else
                    {
                        Dispatch(method);
                    }
                }
            }
        }

        private void Dispatch(String action, dynamic parameters)
        {
            try
            {
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod(
                    action,
                    BindingFlags.NonPublic | BindingFlags.Instance
                );

                theMethod.Invoke(this, parameters);
            }
            catch { }
        }

        private void Dispatch(String action)
        {
            Dispatch(action, false);
        }

        private async void Window_Minimize()
        {
            await Api("MX_BROWSER.onMinimize();");
            await cgi.Minimize(!fullActive);
            this.WindowState = FormWindowState.Minimized;
            AppTitle.Focus();
        }

        private async void Window_Maximize()
        {
            ChangeStyleComponent();

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                fullActive = false;
                await Api("MX_BROWSER.onNormalize();");
                MaxiButton.IconChar = FontAwesome.Sharp.IconChar.Square;
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                fullActive = true;
                await Api("MX_BROWSER.onMaximize();");
                MaxiButton.IconChar = FontAwesome.Sharp.IconChar.Minimize;
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 0, 0));
            }
            AppTitle.Focus();
        }

        private async void Window_Close()
        {
            try
            {
                String result = await Api("MX_BROWSER.onClose();");
                if (bool.Parse(result))
                    Application.Exit();
            }
            catch
            {
                Application.Exit();
            }
            AppTitle.Focus();
        }

        private async void App_Minimize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                await cgi.Minimize(!fullActive);
                await Browser.CoreWebView2.ExecuteScriptAsync("MX_BROWSER.onMinimize();");
                this.WindowState = FormWindowState.Minimized;
                AppTitle.Focus();
            }
        }

        private async void App_Restore(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                await cgi.Maximize(!fullActive);
                await Api("MX_BROWSER.onNormalize();");
                this.WindowState = FormWindowState.Normal;
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                if (_loadApp)
                {
                    await cgi.Minimize(!fullActive);
                    this.WindowState = FormWindowState.Minimized;
                    await Api("MX_BROWSER.onMinimize();");
                    this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));
                }
                else
                {
                    _loadApp = true;
                }
            }
            AppTitle.Focus();
        }

        public void App_Closing(object sender, EventArgs e)
        {
            if (!Exiting)
            {
                if (_log) CGI.LogInfo("Fechando");
                if (pid_server > 0)
                {
                    Process process = Process.GetProcessById(pid_server);
                    try
                    {
                        process.Kill();
                        if (_log) CGI.LogInfo($"Servidor PID {pid_server} Finalizado");
                        pid_server = 0;
                    }
                    catch (Exception ex)
                    {
                        if (_log) CGI.LogInfo(ex.Message);
                    }
                }
                if (_log) CGI.LogInfo("----");
                Exiting = true;

                splashForm.Close();
            }
        }

        private void ToolBar_MouseMove(object sender, EventArgs e)
        {
            int Top = Cursor.Position.Y - clickedAt.Y;
            int Left = Cursor.Position.X - clickedAt.X;
            if (mouseClicked)
            {
                this.Location = new Point(Left, Top);
            }
            Api("MX_BROWSER.onMouseMove();");
        }

        private void ToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            mouseClicked = true;
            clickedAt = e.Location;
            Api("MX_BROWSER.onMouseDown();");
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
                    this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 0, 0));
                }
                else
                {
                    this.Height = _height;
                    this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));
                }

                if (Right > WorkingWidth)
                {
                    Left = negative ? this.Width * -1 : WorkingWidth - this.Width;
                    this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _radius, _radius));
                }

                if (Left < WorkingLeft)
                    Left = WorkingLeft;

                this.Location = new Point(Left, Top);

            }
            mouseClicked = false;
            Api("MX_BROWSER.onMouseUp();");
        }

        public Color Theme(Color color, float perc, float param = 0.2f)
        {
            Color theme;

            if (_toolBarColor.GetBrightness() >= param)
                theme = ControlPaint.Dark(color, -perc);
            else
                theme = ControlPaint.Light(color, perc);
            return theme;
        }

        private void Browser_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {
                _startApi = true;
                String page_error = $"file:///{_local_path}/erro.html";
                Browser.CoreWebView2.Navigate(page_error);
            }
            else
            {
                if (!this.Visible)
                   splashForm.AppOpen();
                _startApi = true;
            }
            Api("MX_BROWSER.getTheme({primary:'" + CGI.ToHexString(_toolBarColor) + "', secondary:'" + CGI.ToHexString(_toolBarFontColor) + "'})");
        }

        private Task<string> Api(string method)
        {
            if (_startApi)
                return Browser.CoreWebView2.ExecuteScriptAsync(method);
            else
                return Task.FromResult("true");
        }
    }
}

