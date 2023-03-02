using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAppMX
{
    public partial class CGI
    {
        private Form form;
        private bool clicked = false;

        public CGI(Form _form)
        {
            this.form = _form;
        }
        public async Task FadeIn( int interval = 80, bool move = false)
        {
            form.Opacity = 0.5;
            form.Show();
            //Object is not fully invisible. Fade it in

            while (form.Opacity < 1)
            {
                await Task.Delay(interval);
                if (clicked && move)
                {
                    form.Top -= 20;
                    form.Left += 20;
                }
                    form.Update();
                form.Opacity += 0.1;

            }
            form.Opacity = 1;
            this.clicked = false;
        }

        public async Task FadeOut( int interval = 80, bool move = false)
        {
            //Object is fully visible. Fade it out
            int n = 1;
            while (form.Opacity > 0.5)
            {
                await Task.Delay(interval);
                form.Opacity -= 0.1;
                if( move)
                {
                    form.Top += 20;
                    form.Left -= 20;
                }
                    form.Update();
                n++;
            }

            form.Opacity = 0; //make fully invisible
        }

        public  async Task Minimize(bool move)
        {
            this.clicked = true;
            //Object is fully visible. Fade it out
            await FadeOut( 01, move);
        }

        public async Task Maximize(bool move)
        {
            await FadeIn( 01, move);
        }

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        public static Image SquareImage(Image originalImage)
        {
            int largestDimension = Math.Max(originalImage.Height, originalImage.Width);
            Size squareSize = new Size(largestDimension, largestDimension);
            Bitmap squareImage = new Bitmap(squareSize.Width, squareSize.Height);
               using (Graphics graphics = Graphics.FromImage(squareImage))
            {
                graphics.FillRectangle(Brushes.Transparent, 0, 0, squareSize.Width, squareSize.Height);
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                graphics.DrawImage(originalImage, (squareSize.Width / 2) - (originalImage.Width / 2), (squareSize.Height / 2) - (originalImage.Height / 2), originalImage.Width, originalImage.Height);
            }
            return squareImage;
        }

        public static Process Shell(string cmd)
        {
            ProcessStartInfo startInfo = new()
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = @"C:\windows\system32\WindowsPowerShell\v1.0\powershell.exe",
                Arguments = cmd,
                Domain = "MX_Started_process"
            };

            Process process = new()
            {
                EnableRaisingEvents = true,
                StartInfo = startInfo
            };
            process.Start();
            return process;
            
        }

        public static void LogInfo(string logMessage) {
            try
            {
                StreamWriter w = File.AppendText("log.txt");
                w.AutoFlush = true;
                w.Write($"[{DateTime.Now:MM/dd/yyyy HH:mm}]");
                w.WriteLine($" {logMessage}");
                w.Close();
            }
            catch { }
        }
    }
}
