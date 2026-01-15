using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LINQ
{
    internal class LINQ_Queries
    {

        private readonly ItStepProjectContext context = new ItStepProjectContext();

        public LINQ_Queries() 
        {
            var innerJoinQuery = from customer in context.Customers
                                 join person in context.People
                                 on customer.PersonId equals person.Id
                                 select person.Surname + " " + person.Name + " " + customer.Id;

        }

    }
}





//public void Example()
//{
//    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    // LINQ Query Syntax
//    var evenNumbersQuery = from num in numbers
//                           where num % 2 == 0
//                           select num;
//    // LINQ Method Syntax
//    var evenNumbersMethod = numbers.Where(num => num % 2 == 0);
//    Console.WriteLine("Even Numbers (Query Syntax): " + string.Join(", ", evenNumbersQuery));
//    Console.WriteLine("Even Numbers (Method Syntax): " + string.Join(", ", evenNumbersMethod));
//}