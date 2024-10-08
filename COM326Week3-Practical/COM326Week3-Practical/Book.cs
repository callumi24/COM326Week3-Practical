using System.Xml.Linq;

namespace COM326Week3_Practical
{
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private int ibsn;
        private static int ibsnCount = 1;
        private string year;
        private string publisher;

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Genre { get { return genre; } set { genre = value; } }
        public int Ibsn { get { return ibsn; } set { ibsn = value; } }
        public string Year { get { return year; } set { year = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }

        public Book()
        {
            title = "It";
            author = "Stephen King";
            genre = "Horror";
            ibsn = ibsnCount++;
            year = "1986";
            publisher = "Hodder & Stoughton";
        }

        public Book(string title, string author, string genre, string year, string publisher)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.ibsn = ibsnCount++;
            this.year = year;
            this.publisher = publisher;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {title}\nAuthor: {author}\nGenre: {genre}\nIbsn: {ibsn}\nYear: {year}\nPublisher: {publisher}");
        }
    }
}
