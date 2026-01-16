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

            var MultipleJoinQuery =  from customer in context.Customers
                                     join CustomerOrder in context.CustomerOrders
                                     on customer.Id equals CustomerOrder.CustomerId
                                     join person in context.People
                                     on customer.Id equals person.Id
                                     select person.Name + " " + person.Surname + " " + customer.Id + " Order ID: " + CustomerOrder.Id;

            var SumAndGroupByQuery = from CustomerOrder in context.CustomerOrders
                                     join OrderDetail in context.OrderDetails
                                     on CustomerOrder.Id equals OrderDetail.CostumerOrderId
                                     group OrderDetail by CustomerOrder.Id into grouped
                                     select new
                                     {
                                         CustomerOrderId = grouped.Key,
                                         TotalAmount = grouped.Sum(od => od.ProductAmount),
                                         TotalQuantity = grouped.Sum(od => od.Price),
                                         OrderCount = grouped.Count()
                                     };

            var WherePersonIsAbove18 = from person in context.People
                                       where DateTime.Now.Year - person.BirthDate.Value.Year > 18
                                       select person.Name + " " + person.Surname + " Age: " + (DateTime.Now.Year - person.BirthDate.Value.Year);

            var WhenPriceIsAbove800 = from product in context.Products
                                      where product.Price > 800
                                      select product.ProductTitleId + " Price: " + product.Price;

            var OrderByProductsByPrice = from product in context.Products
                                        orderby product.Price descending
                                        select product.ProductTitleId + " Price: " + product.Price;

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