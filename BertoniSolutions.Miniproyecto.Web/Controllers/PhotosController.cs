using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BertoniSolutions.Miniproyecto.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutions.Miniproyecto.Web.Controllers
{
    public class PhotosController : Controller
    {
        private readonly IPhotoService _photoService;

        public PhotosController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<ActionResult> List(int? albumId)
        {
            if (!albumId.HasValue)
            {
                return NotFound();
            }

            var photos = await _photoService.GetByAlbumId(albumId.Value);
            return View(photos);
        }
    }
}