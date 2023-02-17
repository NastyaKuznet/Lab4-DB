namespace Lab4_DB
{
    internal class Program
    {
        static void Main()
        {
            PatternObjectDB patternBook = new PatternObjectDB("Book.json");
            ObjectDB[] books = LoadData.ReadObjectDB("books.csv", patternBook);

        }
    }
}