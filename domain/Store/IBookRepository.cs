namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);

        Book[] GetAllByTitleOrAuthor(string titlePartOeAythor);

        Book GetById(int id);
    }
} 
