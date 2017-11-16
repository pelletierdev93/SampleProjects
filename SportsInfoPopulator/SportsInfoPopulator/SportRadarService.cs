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
        public async Task<List<string>> GetSportsData(string format, CancellationToken token)
        {
            // Init vars
            var results = new List<string>();
            var formatter = new Formatter();
            var client = new HttpClient();
            // Service Call
            var r = await client.GetAsync($"http://api.sportradar.us/nfl-ot2/seasontd/2017/standings.json?api_key=kprbs6drnp6w3n5um2rh3wc6", token);
            // Parse Json
            var o = JObject.Parse(await r.Content.ReadAsStringAsync());
            // Format Json
            switch (format) {
                case "Conferences":
                    results = formatter.FormatConferences(o);
                    break;
                case "Teams":
                    results = formatter.FormatTeams(o);
                    break;
            }
            // Return results
            return results;
        }
    }
}
