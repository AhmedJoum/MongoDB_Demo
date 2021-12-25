
using System;

namespace MongoDB_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //db.InsertRecord("Users", new PersonModel
            //{
            //    FirstName = "Hussam",
            //    LastName = "Hassan", 
            //    PrimaryAddress = new AddressModel
            //    {
            //        City =  "Kahrtoum", 
            //        PostalCode =    "1111", 
            //        State = "Khrtoum", 
            //        StreetAddress = "...",
            //    }
            //});

            var recs = db.LoadRecords<NameModel>("Users");

            foreach (var rec in recs)
            {
                Console.WriteLine($" {rec.FirstName} {rec.LastName}");
                // Console.WriteLine($"{rec.PrimaryAddress?.City}");
            }

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("8fe354a3-2970-40f5-9343-1411e75ccf8d"));
            //oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0,0,0, DateTimeKind.Utc);
            //db.UpsertRecord<PersonModel>("Users", oneRec.Id, oneRec);

            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.WriteLine();

        }
    }
}
