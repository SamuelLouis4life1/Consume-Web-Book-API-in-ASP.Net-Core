using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public interface IBookRepositoryMvc
    {
        //Get all books
        IEnumerable<BookDto> GetBooks();

        //Get specific book by id
        BookDto GetBookById(int bookId);

        //Get specific books by ISBN
        BookDto GetBookByIsbn(string bookIsbn);

        //Get books rating
        decimal GetBookByRating(int bookId);
    }
}
