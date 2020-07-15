using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public interface IReviewerRepositoryMvc
    {
        // Get all reviewers
        IEnumerable<ReviewerDto> GetReviewers();

        // Get specifid reviewer by id
        ReviewerDto GetReviewerById(int reviewerId);

        // Get all reviews by a reviewer 
        IEnumerable<ReviewDto> GetReviewsByReviewer(int reviewerId);

        // Get reviewer of a specific review
        ReviewerDto GetReviewerOfAReview(int reviewId);

    }
}
