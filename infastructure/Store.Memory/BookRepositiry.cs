﻿using System;
using System.Linq;
namespace Store.Memory
{
    public class BookRepositiry : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "art of Programming"),
            new Book(2, "ISBN 12312-31232", "M. Fowier", "Refactoring"),
            new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Richie" ,"C Programming Language"),
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
    }
}
