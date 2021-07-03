using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly List<Post> _posts;

        public BlogController(List<Post> posts)
        {
            _posts = posts;
        }

        [HttpGet]
        public ActionResult<List<Post>> Get()
        {
            return _posts.ToList();
        }
    }
}
