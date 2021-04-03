using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReactNetVanilla.Controllers.Resources;
using ReactNetVanilla.Core;
using ReactNetVanilla.Core.Models;

namespace ReactNetVanilla.Controllers
{
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(IMapper mapper, ICommentRepository repository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("/api/comments")]
        public async Task<IActionResult> GetComments()
        {
            var comments = await _repository.GetComments();

            if (comments == null)
            {
                return NotFound();
            }

            var commentsResource = _mapper.Map<IList<Comment>, IList<CommentResource>>(comments);

            return Ok(comments);
        }
    }
}
