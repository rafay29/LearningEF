using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadLine();
        }
    }
}
