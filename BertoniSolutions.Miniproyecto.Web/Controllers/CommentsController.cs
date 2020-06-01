using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BertoniSolutions.Miniproyecto.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutions.Miniproyecto.Web.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<ActionResult> List(int photoId)
        {
            var comments = await _commentService.GetByPhotoId(photoId);

            return PartialView("_Comments", comments);
        }
    }
}