using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Book 
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string IBAN { get; set; }
    public string Author { get; set; }
    public int InternalBookId { get; set; }
    public string ShelfNumber { get; set; }  
}