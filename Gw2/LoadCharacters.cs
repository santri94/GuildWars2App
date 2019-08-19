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
        public static async Task GetAllCharactersAsync()
        {
            string action = "characters?ids=all";
            SetUpConnection.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "87302DF2-6802-A749-9C17-15A51A939584DFF9040B-3EA2-4923-B4A0-8F0717175939");

            string url = SetUpConnection.httpClient.BaseAddress.AbsoluteUri + action;

            string rawJSON = await SetUpConnection.httpClient.GetStringAsync(url);

            charactersList = JsonConvert.DeserializeObject<List<Character>>(rawJSON);
            //var myObj = charactersList[0];



        }
    }
}
