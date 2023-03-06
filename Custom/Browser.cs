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
        public bool loaded = false;
        public Browser() {

           
        }

        public async void InitializeAsync( string path ) {
            string script = await File.ReadAllTextAsync(path);
            await this.EnsureCoreWebView2Async(null);
            this.CoreWebView2.Settings.IsStatusBarEnabled = false;
            this.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;            
            this.CoreWebView2.Settings.IsBuiltInErrorPageEnabled = false;
            await this.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(script);
            await this.CoreWebView2.ExecuteScriptAsync(script);
            loaded = true;

            //this.CoreWebView2.Navigate(navigate);
        }

    }
}
