using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTryArticles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            List<Articles> article = new List<Articles>();
            string title = "";
            string content = "";
            string author = "";

            for (int i = 0; i < nInput; i++)
            {
                List<string> command = Console.ReadLine().Split(", ").ToList();

                title = command[0];
                content = command[1];
                author = command[2];

                Articles articles = new Articles(title, content, author);
                article.Add(articles);
            }


            string order = Console.ReadLine();

            if (order == "title")
            {
                article = article.OrderBy(x => x.Title).ToList();
            }
            else if (order == "content")
            {
                article = article.OrderBy(x => x.Content).ToList();
            }
            else if (order == "author")
            {
                article = article.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, article));
        }
    }

    public class Articles
    {
        public string Title;
        public string Content;
        public string Author;
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return Title + " - " + Content + ": " + Author;
        }
    }
}
