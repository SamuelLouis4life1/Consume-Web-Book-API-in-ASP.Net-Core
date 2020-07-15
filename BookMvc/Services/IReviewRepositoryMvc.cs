using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public interface IReviewRepositoryMvc
    {
        // Get all reviews
        IEnumerable<ReviewDto> GetReviews();

        //Get a specific review by id
        ReviewDto GetReviewById(int reviewId);

        // Get all reviews for a book
        IEnumerable<ReviewDto> GetReviewsForABook(int bookId);

        // Get a book of a specific review
        BookDto GetBookOfAReview(int reviewId);
    }
}
