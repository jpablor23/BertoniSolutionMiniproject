using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniSolutions.Miniproyecto.Application.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
