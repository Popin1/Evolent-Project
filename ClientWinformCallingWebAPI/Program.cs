using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ClientWinformCallingWebAPI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HttpClient _client = new HttpClient();
            string server = ConfigurationManager.AppSettings["Server:Port"];
            string uri = string.Format("http://{0}/api/", server);
            _client.BaseAddress = new Uri(uri);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Application.Run(new gridForm(_client));
        }
    }
}
