using System.Reflection.Metadata.Ecma335;

namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        public string Title { get; set; }

        public string Song { get; set; }

        public Decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }

        public ICollection<Artist> Artist { get; set; }

        public ICollection<Genre> Genre { get; set; }
    }
}
