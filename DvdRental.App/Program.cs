using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DvdRental.Core.Models;
using DvdRental.Core.Components;

namespace DvdRental.App
{
    class Program
    {
        static void Main(string[] args)
        {

            // Show all articles    
            foreach (var a in Database.Session.Query<Dvd>("SELECT * FROM dvd"))
            {
                Console.WriteLine("{0} - {1}", a.Id, a.Title);
            }

            Console.WriteLine("Length Of Dvd = " + Database.GetNextID<Dvd>());
            Console.WriteLine("Length Of Genre = " + Database.GetNextID<Genre>());

            //Database.Session.Insert(new Dvd() { 
            //    Id = Database.GetNextID<Dvd>(),
            //    Title = "Tømmermænd i thailand",
            //    Genre = 1,
            //    ReleaseYear = 9999,
            //    Description = "Me love you long time"
            //});

            Console.ReadLine();
        }
    }
}
