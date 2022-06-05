public class LinqQueries
{
    private List<Book> bookCollection = new List<Book>();
  
    public LinqQueries()
    {
        using (StreamReader r = new StreamReader("books.json"))
        {
            string json = r.ReadToEnd();
            this.bookCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions(){ PropertyNameCaseInsensitive = true });
        }
    }

    public List<Book> BookList()
    {
        return bookCollection;
    }
}