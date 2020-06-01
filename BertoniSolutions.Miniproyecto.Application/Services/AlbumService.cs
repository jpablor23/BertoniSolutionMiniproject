using System;
using System.Collections;
using System.Collections.Generic;
using BertoniSolutions.Miniproyecto.Application.Entities;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using BertoniSolutions.Miniproyecto.Application.Helpers;

namespace BertoniSolutions.Miniproyecto.Application.Services
{
    public class AlbumService: IAlbumService
    {
        public async Task<IEnumerable<Album>> GetAllAlbums()
        {
            var url = "albums";
            var albums = await ApiClientHelper.GetAll<Album>(url);

            return albums;
        }
    }
}
