using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReactNetVanilla.Controllers.Resources;

namespace ReactDemo.Controllers
{
    public class CommentController : ControllerBase
    {
        private static readonly IList<CommentResource> _comments;

        static CommentController()
        {
            _comments = new List<CommentResource>
            {
                new CommentResource
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentResource
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new CommentResource
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is another comment"
                },
            };
        }

        [HttpGet("/api/comments")]
        public IActionResult GetComments()
        {
            var comments = JsonConvert.SerializeObject(_comments);
            return Ok(comments);
        }
    }
}
