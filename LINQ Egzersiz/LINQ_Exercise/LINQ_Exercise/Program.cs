using System.Security.Cryptography.X509Certificates;
using LINQ_Exercise;


CustomerList customerList = new CustomerList();

var customers = customerList.GetCustomers();

foreach (var item in customers)
    Console.WriteLine(item.Name);


customers.ForEach(x=> Console.WriteLine(x.City));

var highIncomeCustomers = from c in customers
    where c.Income > 12000
    select c;

foreach (var item in highIncomeCustomers)
{
    Console.WriteLine(item.Income);
}

var istanbulCustomers = customers.Where(x => x.City == "istanbul").ToList();

istanbulCustomers.ForEach(x=>Console.WriteLine($"{x.City} .... {x.Name}"));


var marriedCustomers = customers.Count(x => x.IsMarried == true);

Console.WriteLine(marriedCustomers);
