using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BertoniSolutions.Miniproyecto.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutions.Miniproyecto.Web.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumsController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        // GET: Albuns
        public async Task<ActionResult> Index()
        {
            var albums = await _albumService.GetAllAlbums();

            return View(albums);
        }
    }
}