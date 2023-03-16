using ATM.DATA.Database;
using ATM.DATA.Models;
using Microsoft.EntityFrameworkCore;
using ATM.DATA.DataAccess;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ATM.BLL.Implementations;
using ATM.UI.Views;
using System.Linq;
using ATM.UI.Forms;

//StartApp.AccessOptions();


public class Program
{

    static async Task Main()
    {
        AtmDbContextFactory toDoAppDbContextFactory = new AtmDbContextFactory();
        var dbcontext = toDoAppDbContextFactory.CreateDbContext(null);

        bool anycustomer = await dbcontext.Customers.AnyAsync();

        if (anycustomer == false)
        {
            var customer = new Customer()
            {
                FirstName = "Samuel",
                LastName = "Amadi",
                Email = "Samuel.Amadi@gmail.com",
                PhoneNumber = "081354366892",
                Address = "7 Adelaja street",
                Account = new Account { }

            };
            dbcontext.Add(customer);
            Console.WriteLine(dbcontext.SaveChanges());
        }

        Console.WriteLine("Fetch All Customers  ==========");
        Console.WriteLine();
        var AllCustomers = dbcontext.Customers.OrderBy(u => u.Id).Include(i => i.Account).ToList();

        foreach (var customer in AllCustomers)
        {
            Console.WriteLine($"Name:{customer.FirstName} {customer.LastName}, Email: {customer.Email} Phone{customer.PhoneNumber} Accountnum: {customer.Account.AccountNumber} AccountBal: {customer.Account.AccountBalance} Accountpin: {customer.Account.Accountpin}");
        }

        //IQueryable<Customer> userQuery = dbcontext.Customers.OrderByDescending(u => u.FirstName).Include(u=>u.Account);
        IQueryable<Customer> userQuery = dbcontext.Customers.Include(u => u.Account);

        //var userToUpdate = userQuery.First(u => u.FirstName == "johnson");
        var query = userQuery.AsTracking();
        foreach (var customer in userQuery)
        {
            if (customer.FirstName == "johnson")
            {
                //userToUpdate.Account.AccountBalance += 100;
                var msg = dbcontext.SaveChanges() > 0 ? "Update Successful" : "Update Failed";
                Console.WriteLine(msg);
                //Console.WriteLine("yes johnson dey {0}-{1}", customer.Account.AccountBalance, customer.Account.AccountNumber);
            }
        }

        //var query = GetData.UserQuaery();
        var accnt = int.Parse(Console.ReadLine());
        var pin = Console.ReadLine();
        var pin2 = Console.ReadLine();



        if (query.Account.AccountNumber == 2076225242 && query.Account.Accountpin == "1234")
        {
            //var msg = query.FirstName !== ? $"Welcome {query.FirstName}" : "This user does not exist";
            Console.WriteLine(query.FirstName);
        }


    }
}
