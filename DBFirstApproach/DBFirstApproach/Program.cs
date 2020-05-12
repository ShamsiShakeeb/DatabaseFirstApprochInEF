using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new Online_E_EducationEntities();

            /*Multiple Selection 

           
            var query = context.ApproveTables.Where(s => s.UserType.Equals("Student") && s.Email == "miju@gmail.com").Select(x => new { x.Name,x.Email }).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                Console.WriteLine(query[i].Name);
            }


            Console.ReadLine();

            var query = context.ApproveTables.Where(miju => miju.UserType == "Student").Select(shamsi => shamsi).ToList();
            for(int i = 0; i < query.Count; i++)
            {
                Console.WriteLine(query[i].Email +" "+ query[i].Password +" "+ query[i].UserType);
            }
            Console.ReadKey();


            Multiple Selection*/

            ///Select

            /*

            var query = context.ApproveTables.Select(x => x).ToList();
            for(int i = 0; i < query.Count; i++)
            {
                Console.WriteLine(query[i].Name +" "+ query[i].Email);
            }
            Console.ReadLine();
            */

            ////Update
            /*

            var query = context.ApproveTables.Where(x => x.Email == "mim@gmail.com").FirstOrDefault<ApproveTable>();
            query.PhoneNumber = "01762120546";
            query.Name = "Mim Asma";
            context.SaveChanges();
            */


            ////Remove
            /*
            var query = context.ApproveTables.Where(x => x.Email == "miju@gmail.com").FirstOrDefault<ApproveTable>();
            context.ApproveTables.Remove(query);
            context.SaveChanges();
            */



            /*Insert

             var post = new ApproveTable()
             {
                 Name = "Miju Ahamed",
                 Email = "miju@gmail.com",
                 PhoneNumber = "8801990251270",
                 Date = "3/2/2020",
                 Address = "Savar",
                 City = "Dhaka",
                 UserType = "Student",
                 Password = "12345"
             };
             context.ApproveTables.Add(post);
             context.SaveChanges();

            Insert */





        }
    }
}
