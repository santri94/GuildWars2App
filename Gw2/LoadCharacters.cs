using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gw2
{
    public static class LoadCharacters
    {
        public static List<Character> charactersList = new List<Character>();
        public static async Task GetAllCharactersAsync(string token)
        {
            string action = "characters?ids=all";
            SetUpConnection.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            string url = SetUpConnection.httpClient.BaseAddress.AbsoluteUri + action;

            string rawJSON = await SetUpConnection.httpClient.GetStringAsync(url);

            charactersList = JsonConvert.DeserializeObject<List<Character>>(rawJSON);



        }
    }
}
