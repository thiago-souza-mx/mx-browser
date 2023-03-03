using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace WebAppMX.Custom
{
    public class Browser : WebView2
    {
        public Browser() {


        }

        public async void InitializeAsync()        {
            await this.EnsureCoreWebView2Async(null);            
            this.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            this.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
        }

    }
}
