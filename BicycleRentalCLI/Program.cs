﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class Program
    {
        static void Main(string[] args)
        {

            //<VehicleTesting>
            Vehicle v = new Vehicle("Schwinn", "5813", "SCH58", "Red", "Classy", "Welcome Center", "Good", "-", "Active", "2015-10-02");
            Vehicle v1 = new Vehicle("Huffy", "7878", "H78A8", "Blue", "Dark", "Seymour Union", "Okay", "-", "Active", "2015-07-02"); 
            //.insert() test
            Console.WriteLine("Starting .insert() test for Vehicle class ------------------------");
            v.insert();
            v1.insert();
            Console.WriteLine("Ending .insert() test for Vehicle class --------------------------");
            //.populate() test
            Console.WriteLine("Starting .populate() test for Vehicle class ------------------------");
            v.populate(1);
            Console.WriteLine("Ending .populate() test for Vehicle class --------------------------");
            Console.WriteLine("Bike Make: "+v.BikeMake);
            Console.WriteLine("Model Number: "+v.ModelNumber);
            Console.WriteLine("Serial Number: "+v.SerialNumber);
            Console.WriteLine("Color: "+v.Color);
            Console.WriteLine("Description: "+v.Description);
            Console.WriteLine("Location: "+v.Location);
            Console.WriteLine("Physical Condition: "+v.PhysicalCondition);
            Console.WriteLine("Notes: "+v.Notes);
            Console.WriteLine("Status: "+v.Status);
            Console.WriteLine("DateStatusUpdated: "+v.DateStatusUpdated);
            //.update() test
            Console.WriteLine("Starting .update() test for Vehicle class ------------------------");
            v.Notes = "What a challenger, wow.";
            v.update();
            Console.WriteLine("Ending .update() test for Vehicle class --------------------------");
            //.delete() test
            Console.WriteLine("Starting .delete() test for Vehicle class ------------------------");
            v.delete();  //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for Vehicle class --------------------------\n\n");
            //</VehicleTesting>

            //<UserTesting>
            //(int bid, string f, string l, string pn, string em, string ut, string note, string st, string dstu)
            User u = new User(800111222, "Lenny", "John", "585-395-5151", "rich@poor.com", "Student", "My notes", "Active", "2015-01-30");
            //.insert() test
            Console.WriteLine("Starting .insert() test for User class");
            u.insert();
            Console.WriteLine("Ending .insert() test for User class");
            //.populate() test
            Console.WriteLine("Starting .populate() test for User class");
            u.populate(2);
            Console.WriteLine("Ending .populate() test for User class");
            Console.WriteLine("BannerID: " + u.BannerID);
            Console.WriteLine("FirstName: " + u.FirstName);
            Console.WriteLine("LastName: " + u.LastName);
            Console.WriteLine("PhoneNumber: " + u.PhoneNumber);
            Console.WriteLine("EmailAddress: " + u.EmailAddress);
            Console.WriteLine("UserType: " + u.UserType);
            Console.WriteLine("Notes: " + u.Notes);
            Console.WriteLine("Status: " + u.Status);
            Console.WriteLine("DateStatusUpdated: " + u.DateStatusUpdated);
            //.update() test
            Console.WriteLine("Starting .update() test for User class");
            u.EmailAddress = "newemail@email.com";
            u.update();
            Console.WriteLine("Ending .update() test for User class");
            //.delete() test
            Console.WriteLine("Starting .delete() test for User Class");
            u.delete(); //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for User Class\n\n");
            //</UserTesting>

            //<FineTesting>
            //(int id, int bid, double fa, string dfi, string stat, string dsu)
            Fine f = new Fine(1, 800112358, 5.50, "2015-02-30", "Active", "2015-03-02");
            //.insert() test
            Console.WriteLine("Starting .insert() test for Fine class");
            f.insert();
            Console.WriteLine("Ending .insert() test for Fine class");
            //.populate() test
            Console.WriteLine("Starting .populate() test for Fine class");
            f.populate(1);
            Console.WriteLine("Ending .populate() test for Fine class");
            Console.WriteLine("BorrowerID: " + f.BorrowerID);
            Console.WriteLine("FineAmount: " + f.FineAmount);
            Console.WriteLine("DateFineImposed: " + f.DateFineImposed);
            Console.WriteLine("Status: " + u.Status);
            Console.WriteLine("DateStatusUpdated: " + u.DateStatusUpdated);
            //.update() test
            Console.WriteLine("Starting .update() test for Fine class");
            f.FineAmount = 6.75;
            f.update();
            Console.WriteLine("Ending .update() test for Fine class");
            //.delete() test
            Console.WriteLine("Starting .delete() test for Fine Class");
            f.delete(); //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for Fine Class\n\n");
            //</FineTesting>*/

            //<VehicleCollectionTesting>
            Console.WriteLine("Starting test for VehicleCollection class");
            VehicleCollection vc = new VehicleCollection();
            Console.WriteLine("Ending test for VehicleCollection class");




            Console.ReadLine();
        }
    }
}
