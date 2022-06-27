using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_3.Entities
{
    class Comment
    {
        public string CommentText { get; set; }

        public Comment()
        {

        }
        public Comment(string commentText)
        {
            CommentText = commentText;
        }
    }
}
