using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddDbContext<LibraryContext>(ServiceLifetime.Scoped)
            .AddScoped<IBookService, BookService>()
            .BuildServiceProvider();

        using (var context = serviceProvider.GetService<LibraryContext>())
        {
            context.Database.EnsureCreated();
        }
        
        Console.WriteLine("Database created successfully!");

        using (var scope = serviceProvider.CreateScope())
        {
            var libraryContext = scope.ServiceProvider.GetRequiredService<LibraryContext>();
            var bookService = scope.ServiceProvider.GetRequiredService<IBookService>();

            Book book = new Book
            {
                Name = "A wonderful dream",
                IBAN = "2981297127830192301283981",
                Author = "H, Daniel",
                InternalBookId = 1,
                ShelfNumber = "K5" 
            };

            Book book2 = new Book
            {
                Name = "A wonderful nightmare",
                IBAN = "20904872874019284912421321",
                Author = "J, Adam",
                InternalBookId = 2,
                ShelfNumber = "L3"
            };

            bookService.Add(book);
            bookService.Add(book2);
        }
    }
}