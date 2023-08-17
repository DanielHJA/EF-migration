public class BookService : IBookService
{
    private LibraryContext _context { get; }
    public BookService(LibraryContext context)
    {
        _context = context;
    }

    public void Add(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Delete(Book book)
    {

    }
}