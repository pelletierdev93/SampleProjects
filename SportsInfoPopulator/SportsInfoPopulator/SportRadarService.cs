using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Net;

namespace SportsInfoPopulator
{
    class SportRadarService
    {
        public async Task<List<string>> GetSportsData(string format, string key, CancellationToken token)
        {
            // Init vars
            var results = new List<string>();
            var formatter = new Formatter();
            var client = new HttpClient();
            // Service Call
            var r = await client.GetAsync($"", token);
            // Parse Json
            var o = JObject.Parse(await r.Content.ReadAsStringAsync());
            // Format Json
            switch (format) {
                case "Conferences":
                    results = formatter.FormatConferences(o, key);
                    break;
                case "Division":
                    results = formatter.FormatDivisions(o, key);
                    break;
            }
            // Return results
            return results;
        }
    }
}
