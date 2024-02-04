namespace SolarPowerEngineering
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int yearOfPublication, string genre)
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
            Genre = genre;
        }
    }
}
