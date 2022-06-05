using System.Text.Json;
using System.Text.Json.Serialization;

public class Book
{
    public string Title {get;set;}
    public int PageCount { get;set;}
    public string Status { get;set;}
    public string[] Authors { get;set;}
    public string[] Categories { get;set;}
    public DateTime PublishedDate { get;set;}
}

public class PublishedDate
{    
     [JsonPropertyName("$date")]
    public DateTime  Date {get;set;}
}