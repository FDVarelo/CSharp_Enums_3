using System;
using Enum_3.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comments1 = new Comment("Have a nice trip");
            Comment comments2 = new Comment("Wow that's awesome!");
            
            Post post = new Post
            (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travel to New Zeland",
                "I'm going to visit this wonderful country!",
                12
            );

            post.AddComment(comments1);
            post.AddComment(comments2);

            Comment comments3 = new Comment("Good night");
            Comment comments4 = new Comment("May the Force be with you");

            Post post2 = new Post
            (
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
            );
            post2.AddComment(comments3);
            post2.AddComment(comments4);

            Console.WriteLine(post);
            Console.WriteLine(post2);

        }
    }
}
