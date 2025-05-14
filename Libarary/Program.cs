using Libarary;
using Libarary.Adapter;
using Libarary.Bridge;
using Libarary.Composite;
using Libarary.Decorator;
using Libarary.Facade;
using Libarary.Flyweight;
using Libarary.Proxy;




Console.WriteLine("Starting Library System Demo:\n");

// Flyweight & Book creation
Book book1 = new Book("50-50", "Dvoru Rand", BookCategory.Holocaust);
Book book2 = new Book("Harry Potter", "J.K. Rowling", BookCategory.ChildrensBooks);
Book book3 = new Book("Mens", "Ronen", BookCategory.Biography);
Book book4 = new Book("isterak", "Maya Kinan", BookCategory.Adult);

book1.Display();
book2.Display();
book3.Display();
book4.Display();

Category thrillerCategory = new Category(BookCategory.Thriller);
thrillerCategory.AddBook(book1);

Category childrenCategory = new Category(BookCategory.ChildrensBooks);
childrenCategory.AddBook(book2);

Category holocaustCategory = new Category(BookCategory.Holocaust);
holocaustCategory.AddBook(book3);

Console.WriteLine("Displaying Categories:");
thrillerCategory.Display();
childrenCategory.Display();
holocaustCategory.Display();

// Facade
Library library = new Library();
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

LibararyFacade libraryFacade = new LibararyFacade();
Console.WriteLine("Facade - Printing books by category:");
libraryFacade.PrintBooksByCategory(BookCategory.Thriller);

// Decorator
IBook recommendedBook = new RecommendedBook(book2);
IBook libraryOnlyBook = new LibraryOnlyBook(book3);

Console.WriteLine("Decorator - Special Books:");
recommendedBook.Display();
libraryOnlyBook.Display();

// Adapter
Console.WriteLine("Adapter - Coloring Book Display:");
IBookColoring textColoring = new TextColoring();
BookDIsplayAdapter displayAdapter = new BookDIsplayAdapter(book1);
displayAdapter.Display(textColoring, "Thriller Book Display");

// Proxy
Console.WriteLine("Proxy - User Access:");
User user1 = new User("Regular User", false);
User adminUser = new User("Admin User", true);

ProxyBookService proxyService = new ProxyBookService(library);
proxyService.BorrowBook(book2.Id, user1);
proxyService.BorrowBook(book3.Id, adminUser);
