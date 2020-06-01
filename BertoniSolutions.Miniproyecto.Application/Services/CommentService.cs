using BertoniSolutions.Miniproyecto.Application.Entities;
using BertoniSolutions.Miniproyecto.Application.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BertoniSolutions.Miniproyecto.Application.Services
{
    public class CommentService: ICommentService
    {
        public async Task<IEnumerable<Comment>> GetByPhotoId(int photoId)
        {
            var url = $@"posts/{photoId}/comments";
            var comments = await ApiClientHelper.GetAll<Comment>(url);

            return comments;
        }
    }
}
