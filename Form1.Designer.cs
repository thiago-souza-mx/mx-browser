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
            this.components = new System.ComponentModel.Container();
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
            this.CenterLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SplahText = new System.Windows.Forms.Label();
            this.LoadBar = new System.Windows.Forms.Panel();
            this.LoadColor = new System.Windows.Forms.Panel();
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBarLogo)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ContainerTitle.SuspendLayout();
            this.Wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.LoadBar.SuspendLayout();
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
            this.Wrapper.Controls.Add(this.CenterLogo);
            this.Wrapper.Controls.Add(this.panel3);
            this.Wrapper.Controls.Add(this.LoadBar);
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
            this.Browser.Visible = false;
            this.Browser.ZoomFactor = 1D;
            // 
            // CenterLogo
            // 
            this.CenterLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CenterLogo.Image = ((System.Drawing.Image)(resources.GetObject("CenterLogo.Image")));
            this.CenterLogo.Location = new System.Drawing.Point(510, 160);
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
            this.panel3.Location = new System.Drawing.Point(345, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 45);
            this.panel3.TabIndex = 6;
            // 
            // SplahText
            // 
            this.SplahText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SplahText.AutoSize = true;
            this.SplahText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SplahText.ForeColor = System.Drawing.Color.White;
            this.SplahText.Location = new System.Drawing.Point(236, 4);
            this.SplahText.Name = "SplahText";
            this.SplahText.Size = new System.Drawing.Size(184, 37);
            this.SplahText.TabIndex = 6;
            this.SplahText.Text = "MX Corporate";
            this.SplahText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadBar
            // 
            this.LoadBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBar.Controls.Add(this.LoadColor);
            this.LoadBar.Location = new System.Drawing.Point(345, 541);
            this.LoadBar.Name = "LoadBar";
            this.LoadBar.Size = new System.Drawing.Size(650, 5);
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
            this.TimerLoad.Enabled = true;
            this.TimerLoad.Interval = 30;
            this.TimerLoad.Tick += new System.EventHandler(this.App_Loaded);
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
            ((System.ComponentModel.ISupportInitialize)(this.CenterLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LoadBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.ButtonPro CloseButton;
        private Custom.ButtonPro MinusButton;
        private PictureBox ToolBarLogo;
        private Panel ToolBar;
        private Panel Wrapper;
        private Custom.Browser Browser;
        private Custom.ButtonPro MaxiButton;
        private Label label1;
        private Panel panel1;
        private Label AppTitle;
        private Panel ContainerTitle;
        private PictureBox CenterLogo;
        private System.Windows.Forms.Timer TimerLoad;
        private Panel LoadBar;
        private Panel LoadColor;
        private Panel panel3;
        private Label SplahText;
    }
}