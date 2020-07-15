using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public interface ICategoryRepositoryMvc
    {
        // Get all categories
        IEnumerable<CategoryDto> GetCategories();

        // Get a specific category by id 
        CategoryDto GetCategoryById(int categoryId);

        // Get all book per category
        IEnumerable<BookDto> GetAllBooksForCategory();

        // Get all category for a book
        IEnumerable<CategoryDto> GetAllCategoriesOfABooks();

    }
}
