using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace SportsInfoPopulator
{
    class Formatter
    {
        internal List<string> FormatTeams(JObject o) {
            // Init vars
            var teamNames = new List<string>();
            // Get the token we want from the JObject
            JToken teams = o["Teams"];
            // Iterate thru the collection to get all names
            foreach (var team in teams)
                // Add team name to the list
                teamNames.Add(team["name"].ToString());
            // Return list of team names
            return teamNames;
        }

        internal List<string> FormatConferences(JObject o)
        {
            // Init vars
            var conferenceNames = new List<string>();
            // Get the token we want from the JObject
            JToken conferences = o["Conferences"];
            // Iterate thru the collection to get all names
            foreach (var conference in conferences)
                // Add conference name to the list
                conferenceNames.Add(conference["name"].ToString());
            // Return list of conference names
            return conferenceNames;
        }
    }
}
