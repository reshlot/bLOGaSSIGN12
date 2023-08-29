using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogging.Models
{
    public partial class Comment
    {
        public Nullable<int> Id { get; set; }
        public string Content { get; set; }
        public System.DateTime PublicationDate { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}