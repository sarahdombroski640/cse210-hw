using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        
        Video v1 = new Video("Cats play piano", "Billy Bob", 34);
        Comment c1 = new Comment("John Boy", "Cats are the best!");
        Comment c2 = new Comment("Suzie Anne", "Ahh sooo cute!!");
        Comment c3 = new Comment("user1293", "Subscribe to me for free robux.");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);

        videoList.Add(v1);

        Video v2 = new Video("I'm batman", "Totally Batman", 356);
        Comment c4 = new Comment("the real batman", "no im batman");
        Comment c5 = new Comment("BatFan", "Wut this is literally fake");
        Comment c6 = new Comment("user1293", "Subscribe to me for free VBucks.");

        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);

        videoList.Add(v2);

        Video v3 = new Video("I stare at a wall for five hours", "Wizard22", 18000);
        Comment c7 = new Comment("bluedabadi", "i can't believe i sat through all of that");
        Comment c8 = new Comment("Twilight Lover", "Did he actually do it for all five hours?!?");
        Comment c9 = new Comment("user1293", "Subscribe to me for free Monopoly Money.");
        Comment c10 = new Comment("jimmyjr", "Your wall looks like it needs a new paintjob.");

        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);
        v3.AddComment(c10);
       
       videoList.Add(v3);

        Console.Clear();

       foreach (Video video in videoList)
       {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()} is {video.GetLength()} seconds long with {video.CountComments()} comments.");
            
            Console.WriteLine("Comments:");

            List<Comment> commentsList = video.GetCommentList();
            foreach (Comment comment in commentsList)
            {
                Console.WriteLine(comment.GetText());
            }

            Console.WriteLine();
       }
    }
}