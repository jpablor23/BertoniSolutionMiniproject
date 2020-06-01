using BertoniSolutions.Miniproyecto.Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BertoniSolutions.Miniproyecto.Application.Services
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAllAlbums();
    }
}
