using System;
using ExercicioDemoStringBuilder.Entities;

namespace ExercicioDemoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow! That's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), //moment
                "Traveling to New Zealand", //title
                "I'm going to visit this wonderful country!", //content
                12 //likes
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good nigth!");
            Comment c4 = new Comment("May the force be with you!");
            Post p2 = new Post(
                DateTime.Parse("27/08/2018 23:14:19"), //moment
                "Good nigth guys", //title
                "See you tomorrow", //content
                5 //likes
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
