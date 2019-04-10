using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyTrek.Model
{
    public class Artist
    {
        public string Name { get; }
        public string Id { get; }
        public List<string> GenreList { get; }

        public Artist(string Name, string Id, List<string> GenreList)
        {
            this.Name = Name;
            this.Id = Id;
            this.GenreList = GenreList;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            Artist oth = (Artist)obj;
            return this.Id.Equals(oth.Id);
        }
    }
}
