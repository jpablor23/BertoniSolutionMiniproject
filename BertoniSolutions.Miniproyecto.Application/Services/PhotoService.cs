using BertoniSolutions.Miniproyecto.Application.Entities;
using BertoniSolutions.Miniproyecto.Application.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BertoniSolutions.Miniproyecto.Application.Services
{
    public class PhotoService: IPhotoService
    {
        public async Task<IEnumerable<Photo>> GetByAlbumId(int albumId)
        {
            var url = $@"albums/{albumId}/photos";
            var photos = await ApiClientHelper.GetAll<Photo>(url);
            return photos;
        }
    }
}
