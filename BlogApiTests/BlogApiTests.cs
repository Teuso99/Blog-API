using BlogApi;
using BlogApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace BlogApiTests
{
    public class BlogApiTests
    {
        private readonly BlogController _blogController;
        private Mock<List<Post>> _mockPostsList;

        public BlogApiTests()
        {
            _mockPostsList = new Mock<List<Post>>();
            _blogController = new BlogController(_mockPostsList.Object);
        }


        [Fact]
        public void GetPosts_ReturnListOfPosts()
        {
            // Arrange
            var mockPosts = new List<Post>
            {
                new Post{Title = "Post 1"},
                new Post{Title = "Post 2"}
            };

            _mockPostsList.Object.AddRange(mockPosts);

            // Act
            var result = _blogController.Get();

            //Assert
            var model = Assert.IsAssignableFrom<ActionResult<List<Post>>>(result);

        }
    }
}
