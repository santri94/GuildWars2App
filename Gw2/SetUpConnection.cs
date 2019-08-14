using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gw2
{
    public static class SetUpConnection
    {
        public static HttpClient httpClient { get; set; } // open once per app

        public static void SetUp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.guildwars2.com/v2/");

        }
    }
}
