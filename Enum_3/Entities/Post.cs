using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_3.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Text { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment text)
        {
            Text.Add(text);
        }
        public void RemoveComment(Comment text)
        {
            Text.Remove(text);
        }
        /*public string AllComments()
        {
            foreach(Comment comment in Text)
            {
                //Console.WriteLine(comment.CommentText);
                return comment.CommentText;
            }
        }*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Modelo que o nelio alves utilizou para compactação do Program.cs
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Text)
            {
                sb.AppendLine(c.CommentText);
            }
            return sb.ToString();
        }
    }
}
