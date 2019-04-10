using Newtonsoft.Json;
using SpotifyTrek.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SpotifyTrek.JSONClasses;


namespace SpotifyTrek
{

    public class SpotifyAPIHandler
    {
        private string clientid = "CLIENT ID HERE";
        private string clientsecret = "CLIENT SECRET HERE";

        private HttpClient httpClient;
        private string tok;
        
        public SpotifyAPIHandler()
        {
            tok = GetToken().GetAwaiter().GetResult();
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + tok);
        }

        private async Task<string> GetToken()
        {
            SpotifyToken token = new SpotifyToken();
            string url5 = "https://accounts.spotify.com/api/token";
            var encode_clientid_clientsecret = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", clientid, clientsecret)));

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url5);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Accept = "application/json";
            webRequest.Headers.Add("Authorization: Basic " + encode_clientid_clientsecret);

            var request = ("grant_type=client_credentials");
            byte[] req_bytes = Encoding.ASCII.GetBytes(request);
            webRequest.ContentLength = req_bytes.Length;

            Stream st = webRequest.GetRequestStream();
            st.Write(req_bytes, 0, req_bytes.Length);
            st.Close();

            HttpWebResponse res = (HttpWebResponse) await webRequest.GetResponseAsync().ConfigureAwait(false);
            
            string json = "";

            using (Stream respStr = res.GetResponseStream())
            {
                using (StreamReader streamReader = new StreamReader(respStr, Encoding.UTF8))
                {
                    json = streamReader.ReadToEnd();
                }
            }
            token = JsonConvert.DeserializeObject<SpotifyToken>(json);
            return token.Access_token;
        }
        
        public async Task<List<string>> GetGenreList()
        {
            var url = "https://api.spotify.com/v1/recommendations/available-genre-seeds";
            HttpResponseMessage resp = await httpClient.GetAsync(url);

            var json = "";

            if (resp.IsSuccessStatusCode)
            {
                json = await resp.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<GenreList>(json).genres;
        }

        public async Task<Track> GetPreviewTrack(string artistId)
        {
            var uri = string.Format("https://api.spotify.com/v1/artists/{0}/top-tracks?country=US", artistId);
            HttpResponseMessage resp = await httpClient.GetAsync(uri).ConfigureAwait(false);

            var json = "";
            if (resp.IsSuccessStatusCode)
            {
                json = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            else
            {
                throw new WebException(resp.StatusCode.ToString());
            }
            return JsonConvert.DeserializeObject<TrackList>(json).tracks[0];

        }

        public async Task<List<JSONArtist>> GetRelated(string id)
        {
            var uri = string.Format("https://api.spotify.com/v1/artists/{0}/related-artists", id);
            HttpResponseMessage resp = await httpClient.GetAsync(uri).ConfigureAwait(false);

            var json = "";
            if (resp.IsSuccessStatusCode)
            {
                json = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            else
            {
                throw new WebException(resp.StatusCode.ToString());
            }
            return JsonConvert.DeserializeObject<RelatedArtistList>(json).artists;
        }

        public async Task<JSONArtist> GetRandomArtist(string genre)
        {
            if (genre.Contains(' ')) 
                genre = '"' + genre + '"';

            Random r = new Random(DateTime.Now.Millisecond);
            var uri = string.Format("https://api.spotify.com/v1/search?q=genre:{0}&type=artist&limit=1&offset={1}", genre, r.Next(1,100));
            HttpResponseMessage resp = await httpClient.GetAsync(uri).ConfigureAwait(false);

            var json = "";
            if(resp.IsSuccessStatusCode)
            {
                json = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
            else
            {
                throw new WebException(resp.StatusCode.ToString());
            }
            return JsonConvert.DeserializeObject<ArtistSearchResult>(json).artists.items[0];
        }
    }
}
