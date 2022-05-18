using System;

namespace Exercicio2EnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            string title = "Traveling to New Zeland";
            string content = "I'm going to visit this wonderful country!";
            int likes = 12;
            Post post1 = new Post(moment, title, content, likes);
            string commentText = "Have a nice trip!";
            Comment comment1 = new Comment(commentText);
            post1.AddComment(comment1);
            commentText = "Wow! That's awesome!";
            post1.AddComment(comment1);

            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Likes + "-" + post1.Moment);
            foreach(Comment comment in post1.comments)
            {
                Console.WriteLine(comment.Text);
                Console.WriteLine();
            }
        }
    }
}
