using Libarary.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Facade
{
    internal class Library
    {
        private List<Category> categories;
        public Library()
        {
            categories = new List<Category>();
        }
        public void AddCategory(Category category)
        {
            if (categories.Contains(category)) Console.WriteLine("its exists"); ;
            if (category != null)
            { Console.WriteLine("EROR its null"); }
            categories.Add(category);

        }
        public void RemoveCategory(Category category)
        {
            if (categories.Contains(category))
            {
                categories.Remove(category);
            }
            if (category != null)
            {
                Console.WriteLine("EROR its null");
            }
            else { Console.WriteLine("itsnt exists"); }
        }
        public List<Category> GetCategories() { return categories; }

        public void AddBook(Book b)
        {
            Category existingCategory = categories.FirstOrDefault(c => c._name == b.baseBook.Category);

            if (existingCategory == null)
            {
                existingCategory = new Category(b.baseBook.Category);
                categories.Add(existingCategory);
            }

            existingCategory.AddBook(b);
        }
        public Book FindBookById(int bookId)
        {
            foreach (var category in categories)
            {
                Book foundBook = category.books.FirstOrDefault(b => b.Id == bookId);
                if (foundBook != null)
                    return foundBook;
            }
            return null;
        }
        public List<Book> GetBooksByCategory(BookCategory category)
        {
            Category foundCategory = categories.FirstOrDefault(c => c._name == category);
            return foundCategory != null ? foundCategory.books : new List<Book>();
        }
    }
}
