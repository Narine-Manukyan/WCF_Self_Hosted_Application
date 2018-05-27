using System.Runtime.Serialization;

namespace BookLibrary
{
    /// <summary>
    /// Class which describes a Book.
    /// </summary>
    [DataContract]
    public class Book
    {
        private static int counter = 0;
        [DataMember]
        public int ID { set; get; }
        [DataMember]
        public string Author { set; get; }
        [DataMember]
        public string Title { set; get; }
        [DataMember]
        public decimal Price { set; get; }
        [DataMember]
        public int Year { set; get; }

        /// <summary>
        /// The Parameterfull constructor.
        /// </summary>
        public Book(string author, string title, decimal price, int year)
        {
            this.ID = ++counter;
            this.Author = author;
            this.Title = title;
            this.Price = price;
            this.Year = year;
        }

        /// <summary>
        /// Overriding ToString() static method.
        /// </summary>
        public override string ToString()
        {
            return this.ID + "\t" + this.Author + "\t" + this.Title +
                "\t" + this.Price + this.Year;
        }
    }
}
