namespace CRUDApp.Models;

public class Category{
    public int Id   {get;set;}
    public string Name {get;set;}
    public string Author {get;set;}

    public ICollection<Book> books;

}