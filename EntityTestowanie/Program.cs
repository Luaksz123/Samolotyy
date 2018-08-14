using System;
using Microsoft.Data.Sqlite;
using Samoloty.Entitiesss;


namespace EntityTestowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SamolotyyyyContext();

                var test = new Samoloty.Entitiesss.Samoloty();
                context.Samoloty.Add(test);
                context.SaveChanges();
        }
    }



}
