using BertoniSolutions.Miniproyecto.Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BertoniSolutions.Miniproyecto.Application.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetByPhotoId(int photoId);
    }
}
