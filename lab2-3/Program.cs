using System;

namespace lab2_3
{
    public class Book{
        public string book;
        void Show(){
            Console.Write($"\nBook: {this.book}");
        }
    }
    class Title{
        public string title;
        public void Show(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\nНазвание: {this.title}");
        }
    }
    class Author{
        public string author;
        public void Show(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\nАвтор: {this.author}");
        }
    }
    class Content{
        public string content;
        public void Show(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nСодержание: {this.content}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Author newAuthor = new Author();
            Title newTitle = new Title();
            Content newContent = new Content();

            Console.Write("Напишите название книги: ");
            newTitle.title = Console.ReadLine();
            Console.Write("Напишите автора книги: ");
            newAuthor.author = Console.ReadLine();
            Console.Write("Напишите содержание книги: ");
            newContent.content = Console.ReadLine();

            newTitle.Show();
            newAuthor.Show();
            newContent.Show();
        }
    }
}
