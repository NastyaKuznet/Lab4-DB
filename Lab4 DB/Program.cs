namespace Lab4_DB
{
    internal class Program
    {
        static void Main()
        {
            PatternObjectDB patternBook = new PatternObjectDB("Book.json");
            ObjectDB[] books = LoadData.ReadObjectDB("books.csv", patternBook);
            PatternObjectDB patternReader = new PatternObjectDB("Reader.json");
            ObjectDB[] readers = LoadData.ReadObjectDB("readers.csv", patternReader);
        }
    }
}