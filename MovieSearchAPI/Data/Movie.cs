using System;
namespace MovieSearchAPI.Data
{
	public class Movie
	{
		public string Title { get; set; } = String.Empty;
        public string Year { get; set; } = String.Empty;
        public string ImdbID { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public string Poster { get; set; } = String.Empty;
        public string Plot { get; set; } = String.Empty;
        public string Rated { get; set; } = String.Empty;
        public string Released { get; set; } = String.Empty;
        public string Genre { get; set; } = String.Empty;
        public string Actors { get; set; } = String.Empty;
        public string Runtime { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string Director { get; set; } = String.Empty;
        public string Language { get; set; } = String.Empty;
        public IEnumerable<Rating> Ratings { get; set; }
    }

    public class Rating
    {
        public RatingSource Source { get; set; }
        public string Value { get; set; } = String.Empty;
    }

    public enum RatingSource
    {
        InternetMovieDatabase,
        RottenTomatoes,
        Metacritic
    }
}

