using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public interface IAuthorRepositoryMvc
    {
        // Get all Authors
        IEnumerable<AuthorDto> GetAuthors();

        // Get specific author by id
        AuthorDto GetAuthorById(int authorId);

        // Get all book written by author
        IEnumerable<BookDto> GetBooksByAuthor(int authorId);

        // Get all authors of a book
        IEnumerable<AuthorDto> GetAuthorsOfABook(int bookId);
    }
}
