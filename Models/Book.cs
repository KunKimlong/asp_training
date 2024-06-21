
namespace CRUDApp.Models;

public class Book{
    public int Id   {get;set;}
    public string Name {get;set;}
    public string Author {get;set;}

    public int CategoryId;
    public Category category;
}