using DataBaseFirstEF.DataLayer;
using DataBaseFirstEF.EntityLayer;
using DataBaseFirstEF.EntityLayer.Associate;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataBaseFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Chapter 2

            #region Recipe 2
            //using (var context = new EF6RecipesEntities1())
            //{
            //    try
            //    {
            //        var poet = new Poet { FirstName = "John", LastName = "Milton" };
            //        var poem = new Poem { Title = "Paradise Lost" };
            //        var meter = new Meter { MeterName = "Iambic Pentameter" };
            //        poem.Meter = meter;
            //        poem.Poet = poet;
            //        context.Poems.Add(poem);
            //        poem = new Poem { Title = "Paradise Regained" };
            //        poem.Meter = meter;
            //        poem.Poet = poet;
            //        context.Poems.Add(poem);
            //        poet = new Poet { FirstName = "Lewis", LastName = "Carroll" };
            //        poem = new Poem { Title = "The Hunting of the Shark" };
            //        meter = new Meter { MeterName = "Anapestic Tetrameter" };
            //        poem.Meter = meter;
            //        poem.Poet = poet;
            //        context.Poems.Add(poem);
            //        poet = new Poet { FirstName = "Lord", LastName = "Byron" };
            //        poem = new Poem { Title = "Don Juan" };
            //        poem.Meter = meter;
            //        poem.Poet = poet;
            //        context.Poems.Add(poem);
            //        context.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //        throw;
            //    }

            //}

            //using (var context = new EF6RecipesEntities1())
            //{

            //    var poets = context.Poets;
            //    foreach (var poet in poets)
            //    {
            //        Console.WriteLine("{0} {1}", poet.FirstName, poet.LastName);
            //        foreach (var poem in poet.Poems)
            //        {
            //            Console.WriteLine("\t {0} ({1})", poem.Title, poem.Meter.MeterName);
            //        }
            //    }
            //}
            #endregion

            #region Recipe 3
            //using (var context = new Entities())
            //{
            //    // add an artist with two albums
            //    var artist = new Artist { FirstName = "Alan", LastName = "Jackson" };
            //    var album1 = new Album { AlbumName = "Drive" };
            //    var album2 = new Album { AlbumName = "Live at Texas Stadium" };

            //    artist.Albums.Add(album1);
            //    artist.Albums.Add(album2);
            //    context.Artists.Add(artist);
            //    // add an album for two artists
            //    var artist1 = new Artist { FirstName = "Tobby", LastName = "Keith" };
            //    var artist2 = new Artist { FirstName = "Merle", LastName = "Haggard" };
            //    var album = new Album { AlbumName = "Honkytonk University" };
            //    artist1.Albums.Add(album);
            //    artist2.Albums.Add(album);
            //    context.Albums.Add(album);
            //    context.SaveChanges();
            //}
            #endregion

            #region Recipe 4
            //using (var context = new EF6RecipesEntities3())
            //{
            //    var order = new OrderT { OrderId = 1, OrderDate = new DateTime(2010, 1, 18) };
            //    var item = new Item { SKU = 1729, Description = "Backpack", Price = 29 };
            //    var oi = new OrderItem { OrderT = order, Item = item, COUNT = 1 };
            //    item = new Item { SKU = 2929, Description = "Water Filter", Price = 13 };
            //    oi = new OrderItem { OrderT = order, Item = item, COUNT = 3 };
            //    item = new Item
            //    {
            //        SKU = 1847,
            //        Description = "Camp Stove",
            //        Price = 43
            //    };
            //    oi = new OrderItem { OrderT = order, Item = item, COUNT = 1 };

            //    context.OrderTs.Add(order);
            //    context.SaveChanges();
            //}

            //using (var conext = new EF6RecipesEntities3())
            //{
            //    foreach (var order in conext.OrderTs)
            //    {
            //        Console.WriteLine("Order # {0}, orderd on {1}", order.OrderId.ToString(), order.OrderDate.ToString());
            //        Console.WriteLine("SKU\tDescription\tQty\tPrice");
            //        Console.WriteLine("---\t-----------\t---\t-----");
            //        foreach (var oi in order.OrderItems)
            //        {
            //            Console.WriteLine("{0}\t{1}\t{2}\t{3}", oi.Item.SKU,
            //            oi.Item.Description, oi.COUNT.ToString(),
            //            oi.Item.Price.ToString());
            //        }
            //    }

            //}
            #endregion

            //Not Working
            #region 2-5. Modeling a Self-Referencing Relationship with a Code-First Approach
            //using (var context = new PictureContext())
            //{
            //    var updatedUser = context.Database;
            //    var louvre = new PictureCategory { Name = "Louvre" };
            //    var child = new PictureCategory { Name = "Egyptian Antiquites" };
            //    louvre.Subcategories.Add(child);
            //    child = new PictureCategory { Name = "Sculptures" };
            //    louvre.Subcategories.Add(child);
            //    child = new PictureCategory { Name = "Paintings" };
            //    louvre.Subcategories.Add(child);
            //    var paris = new PictureCategory { Name = "Paris" };
            //    paris.Subcategories.Add(louvre);
            //    var vacation = new PictureCategory { Name = "Summer Vacation" };
            //    vacation.Subcategories.Add(paris);
            //    context.PictureCategories.Add(paris);
            //    context.SaveChanges();
            //}
            #endregion

            #region 2-6. Splitting an Entity Among Multiple Tables
            //using (var context = new ProductContext())
            //{
            //    var product = new Product
            //    {
            //        //SKU = 147,
            //        Description = "Expandable Hydration Pack",
            //        Price = 19.97M,
            //        ImageURL = "/pack147.jpg"
            //    };
            //    context.Products.Add(product);
            //    product = new Product
            //    {
            //        //SKU = 178,
            //        Description = "Rugged Ranger Duffel Bag",
            //        Price = 39.97M,
            //        ImageURL = "/pack178.jpg"
            //    };
            //    context.Products.Add(product);
            //    product = new Product
            //    {
            //        //SKU = 186,
            //        Description = "Range Field Pack",
            //        Price = 98.97M,
            //        ImageURL = "/noimage.jp"
            //    };
            //    context.Products.Add(product);
            //    product = new Product
            //    {
            //        //SKU = 202,
            //        Description = "Small Deployment Back Pack",
            //        Price = 29.97M,
            //        ImageURL = "/pack202.jpg"
            //    };
            //    context.Products.Add(product);
            //    context.SaveChanges();
            //}
            #endregion

            #region 2-9. Using Conditions to Filter an ObjectSet
            //using (var context = new EF6RecipesEntities4())
            //{
            //    context.Database.ExecuteSqlCommand(@"insert into Chapter2.Account
            //        (DeletedOn,AccountHolderID) values ('2/10/2009',1728)");

            //    //var account = new FullTimeEmployee { AccountHolderID = 2320 };
            //    //context.Accounts.Add(account);
            //    //account = new FullTimeEmployee { AccountHolderID = 2502 };
            //    //context.Accounts.Add(account);
            //    //account = new FullTimeEmployee { AccountHolderID = 2603 };
            //    //context.Accounts.Add(account);
            //    //context.SaveChanges();
            //}

            //using (var context = new EF6RecipesEntities4())
            //{
            //    foreach (var account in context.Accounts)
            //    {
            //        Console.WriteLine("Account Id = {0}",
            //        account.AccountHolderID.ToString());
            //    }
            //}
            #endregion

            #region 2-10. Modeling Table per Hierarchy Inheritance
            //using (var context = new EmployeeContext())
            //{
            //    var fullTimeEmployee = new FullTimeEmployee { FirstName = "Jane", LastName = "Doe", Salary = 71500M };
            //    context.Employees.Add(fullTimeEmployee);

            //    var fte = new FullTimeEmployee
            //    {
            //        FirstName = "John",
            //        LastName = "Smith",
            //        Salary = 62500M
            //    };
            //    context.Employees.Add(fte);

            //    var hourly = new HourlyEmployee
            //    {
            //        FirstName = "Tom",
            //        LastName = "Jones",
            //        Wage = 8.75M
            //    };
            //    context.Employees.Add(hourly);
            //    context.SaveChanges();
            //}

            //using (var context = new EmployeeContext())
            //{
            //    Console.WriteLine("--- All Employees ---");
            //    foreach (var emp in context.Employees)
            //    {
            //        var fullTime = emp is FullTimeEmployee ? true : false;
            //        Console.WriteLine("{0} {1} {2}", emp.FirstName, emp.LastName, fullTime ? "Full Time" : "Hourly");
            //    }

            //    Console.WriteLine("--- Full Time ---");
            //    foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
            //    }

            //    Console.WriteLine("--- Hourly ---");
            //    foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
            //    {
            //        Console.WriteLine("{0} {1}", hourly.FirstName, hourly.LastName);
            //    }
            //}
            #endregion

            #region 2-12. Creating, Modifying, and Mapping Complex Types
            /*
                1. A property whose type is a complex type cannot be null
                2. Occasionally, when the value of a complex type property is unimportant
                   for a particular operation, you may need to create a dummy value for the property so that it has some nonnull value.
                3. When you modify any field in complex type property, the property is marked as changed by Entity Framework,
                   and an update statement will be generated that will update all of the fields of the complex type property
            */
            //using (var context = new EF6RecipesEntitiesAgent())
            //{
            //    var name = new Name { FirstName = "Robin", LastName = "Rosen" };
            //    var name2 = new Name { FirstName = "Alex", LastName = "St. James" };
            //    var address1 = new Address
            //    {
            //        Address1 = "510 N. Grant",
            //        Address2 = "Apt. 8",
            //        City = "Raytown",
            //        State = "MO",
            //        ZipCode = "64133"
            //    };
            //    var address2 = new Address
            //    {
            //        Address1 = "222 Baker St.",
            //        Address2 = "Apt.22B",
            //        City = "Raytown",
            //        State = "MO",
            //        ZipCode = "64133"
            //    };
            //    context.Agents.Add(new Agent { Address = address1, Name = name });
            //    context.Agents.Add(new Agent { Address = address2, Name = name2 });
            //    context.SaveChanges();
            //}

            //using (var context = new EF6RecipesEntitiesAgent())
            //{
            //    foreach (var agent in context.Agents)
            //    {
            //        Console.WriteLine("{0} {1}", agent.Name.FirstName, agent.Name.LastName);
            //        Console.WriteLine("{0}", agent.Address.Address1);
            //        Console.WriteLine("{0}", agent.Address.Address2);
            //        Console.WriteLine("{0} {1} {2}", agent.Address.City, agent.Address.State, agent.Address.ZipCode);
            //        Console.WriteLine("\n----------------------------------------\n");
            //    }
            //}
            #endregion

            #endregion

            #region Chapter 3

            #region 3-1. Querying Asynchronously
            //var asyncTask = EF6AsyncDemo();
            //foreach (var c in BusyChars())
            //{
            //    if (asyncTask.IsCompleted)
            //    {
            //        break;
            //    }
            //    Console.Write(c);
            //    Console.CursorLeft = 0;
            //    Thread.Sleep(100);
            //}
            #endregion

            #region 3-2. Updating with Native SQL Statements
            // ExecuteSqlCommand enables us to query the underlying database table directly
            //using (var context = new EF6RecipesEntitiesPayment())
            //{
            //    // delete previous test data
            //    context.Database.ExecuteSqlCommand("delete from chapter3.Payment");
            //}
            //using (var context = new EF6RecipesEntitiesPayment())
            //{

            //    // insert two rows of data
            //    // note how using the following syntax with parameter place holders of @p0 and @p1
            //    // automatically create the ADO.NET SqlParameters object for you
            //    var sql = @"insert into chapter3.payment(Amount,Vendor) values(@p0,@p1)";
            //    var rowCount = context.Database.ExecuteSqlCommand(sql, 99.97M, "Ace Plumbing");
            //    rowCount += context.Database.ExecuteSqlCommand(sql, 43.83M, "Joe's Trash Service");
            //    Console.WriteLine("{0} rows inserted", rowCount);
            //}
            //using (var context = new EF6RecipesEntitiesPayment())
            //{
            //    // retrieve and materialize data using
            //    Console.WriteLine("Payments");
            //    Console.WriteLine("========");
            //    foreach (var payment in context.Payments)
            //    {
            //        Console.WriteLine("Paid {0} to {1}", payment.Amount, payment.Vendor);
            //    }
            //}
            #endregion

            #region 3-3. Fetching Objects with Native SQL Statements
            //using (var context = new StudentContext())
            //{
            //    // delete previous test data
            //    context.Database.ExecuteSqlCommand("delete from chapter3.student");
            //    // insert student data
            //    context.Students.Add(new Student
            //    {
            //        FirstName = "Robert",
            //        LastName = "Smith",
            //        Degree = "Masters"
            //    });
            //    context.Students.Add(new Student
            //    {
            //        FirstName = "Julia",
            //        LastName = "Kerns",
            //        Degree = "Masters"
            //    });
            //    context.Students.Add(new Student
            //    {
            //        FirstName = "Nancy",
            //        LastName = "Stiles",
            //        Degree = "Doctorate"
            //    });

            //    context.SaveChanges();
            //}

            //using (var context = new StudentContext())
            //{
            //    string sql = "select * from Chapter3.Student where Degree = @Major";
            //    var parameters = new DbParameter[] { new SqlParameter {ParameterName="Major",Value="Masters" } };
            //    var students = context.Students.SqlQuery(sql,parameters);
            //    Console.WriteLine("Students...");
            //    foreach (var student in students)
            //    {
            //        Console.WriteLine("{0} {1} is working on a {2} degree", student.FirstName,student.LastName,student.Degree);
            //    }
            //}
            #endregion

            #endregion

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private static IEnumerable<char> BusyChars()
        {
            while (true)
            {
                yield return '\\';
                yield return '|';
                yield return '/';
                yield return '-';
            }
        }

        private static async Task EF6AsyncDemo()
        {
            await Cleanup();
            await LoadData();
            await RunForEachAsyncExample();
            await RunToListAsyncExampe();
            await RunSingleOrDefaultAsyncExampe();
        }

        private static async Task Cleanup()
        {
            using (var conetxt = new AssociateContext())
            {
                // delete previous test data
                // execute raw sql statement asynchronoulsy
                Console.WriteLine("Cleaning Up Previous Test Data");
                Console.WriteLine("=========\n");
                await conetxt.Database.ExecuteSqlCommandAsync("delete from chapter3.AssociateSalary");
                await conetxt.Database.ExecuteSqlCommandAsync("delete from chapter3.Associate");

                await Task.Delay(5000);
            }
        }

        private static async Task LoadData()
        {
            using (var context = new AssociateContext())
            {
                // add new test data
                Console.WriteLine("Adding Test Data");
                Console.WriteLine("=========\n");

                var assoc1 = new Associate { Name = "Janis Roberts" };
                var assoc2 = new Associate { Name = "Kevin Hodges" };
                var assoc3 = new Associate { Name = "Bill Jordan" };
                var salary1 = new AssociateSalary { Salary = 39500M, SalaryDate = DateTime.Parse("8/4/09") };
                var salary2 = new AssociateSalary
                {
                    Salary = 41900M,
                    SalaryDate = DateTime.Parse("2/5/10")
                };
                var salary3 = new AssociateSalary
                {
                    Salary = 33500M,
                    SalaryDate = DateTime.Parse("10/08/09")
                };
                assoc1.AssociateSalaries.Add(salary1);
                assoc2.AssociateSalaries.Add(salary2);
                assoc3.AssociateSalaries.Add(salary3);
                context.Associates.Add(assoc1);
                context.Associates.Add(assoc2);
                context.Associates.Add(assoc3);

                // update datastore asynchronoulsy
                await context.SaveChangesAsync();
                await Task.Delay(5000);
            }




        }

        private static async Task RunForEachAsyncExample()
        {
            using (var context = new AssociateContext())
            {
                Console.WriteLine("Async ForEach Call");
                Console.WriteLine("=========");
                // leverage ForEachAsync
                await context.Associates.Include(x => x.AssociateSalaries).ForEachAsync(x =>
                {
                    Console.WriteLine("Here are the salaries for Associate {0}:", x.Name);

                    foreach (var salary in x.AssociateSalaries)
                    {
                        Console.WriteLine("\t{0}", salary.Salary);
                    }
                });
                await Task.Delay(5000);
            }
        }

        private static async Task RunToListAsyncExampe()
        {
            using (var context = new AssociateContext())
            {
                Console.WriteLine("\n\nAsync ToList Call");
                Console.WriteLine("=========");
                // leverage ToListAsync

                var associates = await context.Associates.Include(x => x.AssociateSalaries).OrderBy(x => x.Name).ToListAsync();
                foreach (var associate in associates)
                {
                    Console.WriteLine("Here are the salaries for Associate {0}:", associate.Name);
                    foreach (var salaryInfo in associate.AssociateSalaries)
                    {
                        Console.WriteLine("\t{0}", salaryInfo.Salary);
                    }
                }
                await Task.Delay(5000);
            }
        }

        private static async Task RunSingleOrDefaultAsyncExampe()
        {
            using (var context = new AssociateContext())
            {
                Console.WriteLine("\n\nAsync SingleOrDefault Call");
                Console.WriteLine("=========");
                var associate = await context.Associates.Include(x => x.AssociateSalaries).OrderBy(x => x.Name).FirstOrDefaultAsync(y => y.Name == "Kevin Hodges");
                Console.WriteLine("Here are the salaries for Associate {0}:", associate.Name);
                foreach (var salaryInfo in associate.AssociateSalaries)
                {
                    Console.WriteLine("\t{0}", salaryInfo.Salary);
                }
                await Task.Delay(5000);
            }
        }
    }
}
