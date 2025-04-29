using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    public class Post
    {
        public string title;
        public string description;
        public DateTime dateTime;
        public void publish()
        {
            Console.Write("My post title is {0} \n", title);
            Console.WriteLine("Content: {0} \nPublished in: {1}", description,
            dateTime);
        }
        public static void like()
        {
            
        }
        public static void comment(string message)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.title = "IT203 - Lab 3";
            post.description = "Object Oriented Programing in C#.NET ...";
            post.dateTime = DateTime.Now;
            post.publish();
            Console.ReadKey();
        }
    }
}