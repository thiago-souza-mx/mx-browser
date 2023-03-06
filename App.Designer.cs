namespace WebAppMX
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.CloseButton = new WebAppMX.Custom.ButtonPro();
            this.MinusButton = new WebAppMX.Custom.ButtonPro();
            this.ToolBarLogo = new System.Windows.Forms.PictureBox();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxiButton = new WebAppMX.Custom.ButtonPro();
            this.ContainerTitle = new System.Windows.Forms.Panel();
            this.AppTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.Browser = new WebAppMX.Custom.Browser();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBarLogo)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ContainerTitle.SuspendLayout();
            this.Wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.CloseButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.CloseButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CloseButton.BorderRadius = 0;
            this.CloseButton.BorderSize = 0;
            this.CloseButton.CausesValidation = false;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.CloseButton.IconSize = 24;
            this.CloseButton.Location = new System.Drawing.Point(106, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(55, 44);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.TextColor = System.Drawing.SystemColors.ControlLight;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.MinusButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.MinusButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MinusButton.BorderRadius = 0;
            this.MinusButton.BorderSize = 0;
            this.MinusButton.CausesValidation = false;
            this.MinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinusButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinusButton.IconColor = System.Drawing.Color.White;
            this.MinusButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MinusButton.IconSize = 20;
            this.MinusButton.Location = new System.Drawing.Point(-4, 0);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.MinusButton.Size = new System.Drawing.Size(55, 44);
            this.MinusButton.TabIndex = 100;
            this.MinusButton.TabStop = false;
            this.MinusButton.TextColor = System.Drawing.SystemColors.ControlLight;
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // ToolBarLogo
            // 
            this.ToolBarLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolBarLogo.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarLogo.Image")));
            this.ToolBarLogo.Location = new System.Drawing.Point(15, 6);
            this.ToolBarLogo.MaximumSize = new System.Drawing.Size(200, 32);
            this.ToolBarLogo.Name = "ToolBarLogo";
            this.ToolBarLogo.Size = new System.Drawing.Size(56, 32);
            this.ToolBarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ToolBarLogo.TabIndex = 2;
            this.ToolBarLogo.TabStop = false;
            this.ToolBarLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            this.ToolBarLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseMove);
            this.ToolBarLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseUp);
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ToolBar.Controls.Add(this.panel1);
            this.ToolBar.Controls.Add(this.ContainerTitle);
            this.ToolBar.Controls.Add(this.label1);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1349, 44);
            this.ToolBar.TabIndex = 3;
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            this.ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseMove);
            this.ToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinusButton);
            this.panel1.Controls.Add(this.MaxiButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 44);
            this.panel1.TabIndex = 3;
            // 
            // MaxiButton
            // 
            this.MaxiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.MaxiButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.MaxiButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MaxiButton.BorderRadius = 0;
            this.MaxiButton.BorderSize = 0;
            this.MaxiButton.CausesValidation = false;
            this.MaxiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxiButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxiButton.FlatAppearance.BorderSize = 0;
            this.MaxiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.MaxiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxiButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaxiButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.MaxiButton.IconColor = System.Drawing.Color.White;
            this.MaxiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaxiButton.IconSize = 20;
            this.MaxiButton.Location = new System.Drawing.Point(51, 0);
            this.MaxiButton.Name = "MaxiButton";
            this.MaxiButton.Size = new System.Drawing.Size(55, 44);
            this.MaxiButton.TabIndex = 0;
            this.MaxiButton.TabStop = false;
            this.MaxiButton.TextColor = System.Drawing.SystemColors.ControlLight;
            this.MaxiButton.UseVisualStyleBackColor = false;
            this.MaxiButton.Click += new System.EventHandler(this.MaxiButton_Click);
            // 
            // ContainerTitle
            // 
            this.ContainerTitle.Controls.Add(this.AppTitle);
            this.ContainerTitle.Controls.Add(this.ToolBarLogo);
            this.ContainerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContainerTitle.Location = new System.Drawing.Point(0, 0);
            this.ContainerTitle.Name = "ContainerTitle";
            this.ContainerTitle.Padding = new System.Windows.Forms.Padding(15, 6, 6, 6);
            this.ContainerTitle.Size = new System.Drawing.Size(250, 44);
            this.ContainerTitle.TabIndex = 5;
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppTitle.ForeColor = System.Drawing.Color.White;
            this.AppTitle.Location = new System.Drawing.Point(71, 6);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Padding = new System.Windows.Forms.Padding(3);
            this.AppTitle.Size = new System.Drawing.Size(119, 31);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "MX Browser";
            this.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            this.AppTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseMove);
            this.AppTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // Wrapper
            // 
            this.Wrapper.AutoScroll = true;
            this.Wrapper.BackColor = System.Drawing.Color.Transparent;
            this.Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Wrapper.Controls.Add(this.Browser);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 44);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1349, 681);
            this.Wrapper.TabIndex = 9;
            // 
            // Browser
            // 
            this.Browser.AllowExternalDrop = true;
            this.Browser.CreationProperties = null;
            this.Browser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1349, 681);
            this.Browser.Source = new System.Uri("http://localhost:8000", System.UriKind.Absolute);
            this.Browser.TabIndex = 0;
            this.Browser.ZoomFactor = 1D;
            this.Browser.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.Browser_NavigationCompleted);
            // 
            // App
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1349, 725);
            this.ControlBox = false;
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.ToolBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MX Browser";
            this.Activated += new System.EventHandler(this.App_Restore);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_Closing);
            this.Load += new System.EventHandler(this.App_Load);
            this.Resize += new System.EventHandler(this.App_Minimize);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBarLogo)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ContainerTitle.ResumeLayout(false);
            this.ContainerTitle.PerformLayout();
            this.Wrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.ButtonPro CloseButton;
        private Custom.ButtonPro MinusButton;
        private Panel ToolBar;
        private Panel Wrapper;
        private Custom.Browser Browser;
        private Custom.ButtonPro MaxiButton;
        private Label label1;
        private Panel panel1;
        private Label AppTitle;
        private Panel ContainerTitle;
        public PictureBox ToolBarLogo;
    }
}