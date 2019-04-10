using SpotifyTrek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpotifyTrek.JSONClasses;

namespace SpotifyTrek.Service
{
    public class Service
    {
        private Random Random;
        private readonly SpotifyAPIHandler ApiHandler;
        readonly private int diff = 5;
        public Artist CurrentArtist { get; set; }
        public List<Artist> Related { get; set; }
        public Artist FinalArtist { get; set; }
        private SoundHandler SoundHandler;
        static List<string> genres = new List<string>() { "afrobeat", "alternative", "ambient", "anime",
            "bluegrass", "blues", "breakbeat", "british", "cantopop","classical", "comedy", "country",
            "dancehall", "disco", "dub", "dubstep", "edm", "electro", "electronic","emo", "folk", "funk", "gospel",
            "grindcore", "grunge", "hardcore", "hardstyle", "hip-hop", "house", "idm", "industrial", "jazz", "kids",
            "latin", "mandopop", "metal", "metalcore", "mpb", "opera", "pop", "punk",
            "reggae", "reggaeton", "rock", "rockabilly", "romance", "sad", "salsa", "samba", "ska", "soul", "soundtracks",
            "tango", "techno", "trance" };

        public Service(SpotifyAPIHandler aH, SoundHandler sH)
        {
            ApiHandler = aH;
            SoundHandler = sH;
            StartGame();
        }

        public void StartGame()
        {
            Random = new Random(DateTime.Now.Millisecond);

            int rand = Random.Next(0, genres.Count - 1);
            var gen = genres[rand];
            JSONArtist cA = ApiHandler.GetRandomArtist(gen).Result;
            CurrentArtist = JsonToArtist(cA);
            
            JSONArtist fA = ApiHandler.GetRandomArtist(gen).Result;
            FinalArtist = JsonToArtist(fA);

            Related = GetRelated().Result;
        }

        public void StopPlaying()
        {
            SoundHandler.Stop();
        }

        public bool CheckWin()
        {
            return CurrentArtist == FinalArtist;
        }

        public async Task PlayPreview(Artist a)
        {
            var TrackTask = ApiHandler.GetPreviewTrack(a.Id);
            string sT = SoundHandler.SoundTag;
            var track = await TrackTask;
            if (SoundHandler.Playing)
                SoundHandler.Stop();
            string url = track.preview_url;
            if (sT != url)
                SoundHandler.PlayFromUrl(url);
        }

        public async Task PickArtist(int index)
        {
            CurrentArtist = Related[index];
            Related = await GetRelated();
        }
        
        private async Task<List<Artist>> GetRelated()
        {
            var RelTask = ApiHandler.GetRelated(CurrentArtist.Id).ConfigureAwait(false);
            List<JSONArtist> rel = await RelTask;
            List<Artist> relA = rel.Select(x => JsonToArtist(x))
                .Where(x => Related == null ? true : !Related.Contains(x) && x != CurrentArtist).ToList<Artist>();
            return relA.Skip(Random.Next(diff, relA.Count-1-diff)).Take(diff).ToList<Artist>();
        }

        private Artist JsonToArtist(JSONArtist a)
        {
            return new Artist(a.name, a.id, a.genres);
        }
    }
}
