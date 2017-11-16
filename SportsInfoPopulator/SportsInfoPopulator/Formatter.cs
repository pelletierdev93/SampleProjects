using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace SportsInfoPopulator
{
    class Formatter
    {
        internal List<string> FormatDivisions(JObject o, string key) {
            // Init vars
            var divisionNames = new List<string>();
            //Split keys
            var keys = key.Split(":");
            // Get the token we want from the JObject
            JToken conferences = o[keys[0]];
            // Iterate thru the collection to get all names
            foreach (var conference in conferences)
                foreach (var division in conference[keys[1]])
                    // Add division name to the list
                    divisionNames.Add(division["name"].ToString());
            // Return list of division names
            return divisionNames;
        }

        internal List<string> FormatConferences(JObject o, string key)
        {
            // Init vars
            var conferenceNames = new List<string>();
            // Get the token we want from the JObject
            JToken conferences = o[key];
            // Iterate thru the collection to get all names
            foreach (var conference in conferences)
                // Add conference name to the list
                conferenceNames.Add(conference["name"].ToString());
            // Return list of conference names
            return conferenceNames;
        }

    }
}
