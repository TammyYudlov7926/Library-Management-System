using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Libarary.Composite
{
    internal class Category
    {
        public BookCategory _name { get; set; }
        public List<Book> books { get; set; } = new List<Book>();

        public List<Category> categories { get; set; } = new List<Category>();

        public Category(BookCategory bookCategory)
        {
            _name = bookCategory;
        }

        public void AddBook(Book b)
        {
            if (b != null)
                books.Add(b);
            else
                Console.WriteLine("EROR!!! The Category cant added");

        }
        public void AddCategory(Category c)
        {
            if (c != null)
                categories.Add(c);
            else
                Console.WriteLine("EROR!!! The Category cant added");
        }

        public void Display()
        {
            Console.WriteLine($" Category: {_name}");

            foreach (Category c in categories)
            {
                c.Display();
            }

            foreach (var item in books)
            {
                item.Display();
            }
        }
        public void RemoveBook(Book b)
        {
            if (books.Contains(b))
            {
                books.Remove(b);
                Console.WriteLine($"The book '{b.baseBook.Name}' has been removed from the category '{_name}'.");
            }
            else
            {
                Console.WriteLine($"The book '{b.baseBook.Name}' was not found in the category '{_name}'.");
            }
        }
        public void RemoveSubCategory(Category c)
        {
            if (categories.Contains(c))
            {
                categories.Remove(c);
                Console.WriteLine($"The subcategory '{c._name}' has been removed from '{c._name}'.");
            }
            else
            {
                Console.WriteLine($"The subcategory '{c._name}' was not found.");
            }
        }

    }
}
