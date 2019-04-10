using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyTrek
{
    public class JSONClasses
    {
    
        public class SpotifyToken
        {
            public string Access_token { get; set; }
            public string Token_type { get; set; }
            public int Expires_in { get; set; }
        }

        public class JSONArtist
        {
            public List<string> genres { get; set; }
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Track
        {
            public string id { get; set; }
            public string name { get; set; }
            public string preview_url { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class TrackList
        {
            public List<Track> tracks { get; set; }
        }

        public class GenreList
        {
            public List<string> genres { get; set; }
        }

        public class RelatedArtistList
        {
            public List<JSONArtist> artists { get; set; }
        }

        public class SearchedArtistList
        {
            public List<JSONArtist> items { get; set; }
        }

        public class ArtistSearchResult
        {
            public SearchedArtistList artists { get; set; }
        }
    }
}
