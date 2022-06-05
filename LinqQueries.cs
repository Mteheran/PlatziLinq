public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
  
    public LinqQueries()
    {
        using (StreamReader r = new StreamReader("books.json"))
        {
            string json = r.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions(){ PropertyNameCaseInsensitive = true });
        }
    }

    public List<Book> ListaDeLibros()
    {
        return librosCollection;
    }

}