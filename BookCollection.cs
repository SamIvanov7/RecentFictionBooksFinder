using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class BookCollection
    {
        public static IEnumerable<Book> FindRecentFictionBooks(IEnumerable<Book> books)
        {
            return books.Where(book => book.YearOfPublication > 2010 && book.Genre.ToLower() == "fiction");
        }
    }
}
