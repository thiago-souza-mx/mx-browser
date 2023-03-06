namespace WebAppMX
{
    partial class SplashForm
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.Wrapper = new System.Windows.Forms.Panel();
            this.CounterLoad = new System.Windows.Forms.Label();
            this.CenterLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SplahText = new System.Windows.Forms.Label();
            this.LoadBar = new System.Windows.Forms.Panel();
            this.LoadColor = new System.Windows.Forms.Panel();
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            this.Wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.LoadBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wrapper
            // 
            this.Wrapper.AutoScroll = true;
            this.Wrapper.BackColor = System.Drawing.Color.Transparent;
            this.Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Wrapper.Controls.Add(this.CounterLoad);
            this.Wrapper.Controls.Add(this.CenterLogo);
            this.Wrapper.Controls.Add(this.panel3);
            this.Wrapper.Controls.Add(this.LoadBar);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(920, 580);
            this.Wrapper.TabIndex = 9;
            // 
            // CounterLoad
            // 
            this.CounterLoad.AutoSize = true;
            this.CounterLoad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CounterLoad.ForeColor = System.Drawing.Color.White;
            this.CounterLoad.Location = new System.Drawing.Point(597, 472);
            this.CounterLoad.Name = "CounterLoad";
            this.CounterLoad.Size = new System.Drawing.Size(45, 19);
            this.CounterLoad.TabIndex = 7;
            this.CounterLoad.Text = "100%";
            // 
            // CenterLogo
            // 
            this.CenterLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CenterLogo.Location = new System.Drawing.Point(296, 90);
            this.CenterLogo.MaximumSize = new System.Drawing.Size(320, 300);
            this.CenterLogo.Name = "CenterLogo";
            this.CenterLogo.Size = new System.Drawing.Size(320, 300);
            this.CenterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CenterLogo.TabIndex = 1;
            this.CenterLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.SplahText);
            this.panel3.Location = new System.Drawing.Point(205, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 86);
            this.panel3.TabIndex = 6;
            // 
            // SplahText
            // 
            this.SplahText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplahText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplahText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SplahText.ForeColor = System.Drawing.Color.White;
            this.SplahText.Location = new System.Drawing.Point(0, 0);
            this.SplahText.Name = "SplahText";
            this.SplahText.Size = new System.Drawing.Size(500, 86);
            this.SplahText.TabIndex = 6;
            this.SplahText.Text = "MX Corporat";
            this.SplahText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadBar
            // 
            this.LoadBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBar.Controls.Add(this.LoadColor);
            this.LoadBar.Location = new System.Drawing.Point(271, 480);
            this.LoadBar.Name = "LoadBar";
            this.LoadBar.Size = new System.Drawing.Size(320, 5);
            this.LoadBar.TabIndex = 0;
            // 
            // LoadColor
            // 
            this.LoadColor.BackColor = System.Drawing.Color.White;
            this.LoadColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadColor.Location = new System.Drawing.Point(0, 0);
            this.LoadColor.Name = "LoadColor";
            this.LoadColor.Size = new System.Drawing.Size(85, 5);
            this.LoadColor.TabIndex = 0;
            // 
            // TimerLoad
            // 
            this.TimerLoad.Interval = 30;
            this.TimerLoad.Tick += new System.EventHandler(this.App_Loaded);
            // 
            // SplashForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.ControlBox = false;
            this.Controls.Add(this.Wrapper);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SplashForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.LoadBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Wrapper;
        private PictureBox CenterLogo;
        private System.Windows.Forms.Timer TimerLoad;
        private Panel LoadBar;
        private Panel LoadColor;
        private Panel panel3;
        private Label SplahText;
        private Label CounterLoad;
    }
}