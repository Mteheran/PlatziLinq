// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my app!");

LinqQueries queries = new LinqQueries();

PrintValues(queries.BookList());

void PrintValues( List<Book> bookList)
{
    //Console.WriteLine($"--------------- Title ----- PageCount ----- Published Date ---------------");
    Console.WriteLine("{0,-70} {1,7} {2,11}\n", "Title", "PageCount", "Published date");
    foreach(var item in bookList)
    {
        Console.WriteLine("{0,-70} {1,7} {2,11}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
    }
}
