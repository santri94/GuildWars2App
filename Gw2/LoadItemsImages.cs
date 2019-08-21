using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gw2
{
    public static class LoadItemsImages
    {
        public static async Task<Items> GetAllItemsImages(string itemId)
        {
            string action = "items//";
            SetUpConnection.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "87302DF2-6802-A749-9C17-15A51A939584DFF9040B-3EA2-4923-B4A0-8F0717175939");
            string url = SetUpConnection.httpClient.BaseAddress.AbsoluteUri + action + itemId;
            string rawJSON = await SetUpConnection.httpClient.GetStringAsync(url);
            Items item = JsonConvert.DeserializeObject<Items>(rawJSON);
            return item;




        }
    }
}
