using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace SportsInfoPopulator
{
    class SportRadarService
    {
        public async Task<JObject> GetSportsData(string formatter, CancellationToken token)
        {
            var client = new HttpClient();

            var r = await client.GetAsync($"http://api.sportradar.us/nfl-ot2/seasontd/2017/standings.json?api_key=kprbs6drnp6w3n5um2rh3wc6", token);

            var o = JObject.Parse(await r.Content.ReadAsStringAsync());

            switch (formatter) {
                case ""


            }
                




            return o;
        }
    }
}
