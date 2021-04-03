using System;
using System.Linq;
namespace Store.Memory
{
    public class BookRepositiry : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 0201038013", "D. Knuth", "Art of Programming, Vol. 1",
                "This volume begins with basic programming and techniq", 7.19m),
            new Book(2, "ISBN 02010485672", "M. Fowier", "Refactoring",
                "As the applicationg of opject technology--particulary the Java", 12.45m),
            new Book(3, "ISBN 0131101633", "B. W. Kernighan, D. Richie" ,"C Programming Language",
                "Know as the bible of C, this classic bestseller introduces", 14.98m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titlePart)
        {
            return books.Where(book => book.Author.Contains(titlePart) 
                                    || book.Title.Contains(titlePart))
                .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
