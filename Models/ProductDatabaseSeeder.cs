using System.Data.Entity;
using System.Collections.Generic;

namespace WingtipToys.Models
{
    public class ProductDatabaseSeeder : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is super fast! The engine is powered by hyper fusion batteries" +
                    "(not included). Power it up and watch it fly!",
                    ImagePath = "carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Classic Car",
                    Description = "Vintage classic car toy, a real throwback and perfect for any collector",
                    ImagePath = "carearly.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Aqua Car",
                    Description = "A real speed demon on land but also can really fly through the water!",
                    ImagePath = "carfast.png",
                    UnitPrice = 32.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "F1 Car",
                    Description = "A real formula 1 car, just like the real thing...but smaller.",
                    ImagePath = "carfaster.png",
                    UnitPrice = 28.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Rally Car",
                    Description = "A sturdy racer that can take on the toughest of terrain.",
                    ImagePath = "carracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Bi-Plane",
                    Description = "A classic bi-plane model that can hang from your ceiling.",
                    ImagePath = "planeprop.png",
                    UnitPrice = 95.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "A glider made from balsa wood. Some assembly required",
                    ImagePath = "planeglider.png",
                    UnitPrice = 5.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Fighter Plane",
                    Description = "A scale model of the latest fighter jet. Warning: some small parts",
                    ImagePath = "planeace.png",
                    UnitPrice = 99.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Fire Truck",
                    Description = "A fire truck toy that squirts real water.",
                    ImagePath = "truckfire.png",
                    UnitPrice = 26.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Learning Truck",
                    Description = "A wooden truck with different shapes and holes to put them in. Ages 12months+",
                    ImagePath = "truckearly.png",
                    UnitPrice = 19.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Dump Truck",
                    Description = "A dumper truck with real moving jaws.",
                    ImagePath = "truckbig.png",
                    UnitPrice = 26.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Sailing Boat",
                    Description = "A wind powered sailing boat, it really floats!",
                    ImagePath = "boatsaily.png",
                    UnitPrice = 9.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "RC Speedboat",
                    Description = "Remote controlled speedboat, hours of fun!",
                    ImagePath = "boatbig.png",
                    UnitPrice = 100.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Paper Boat",
                    Description = "Can be assembled in seconds. Toys for the whole family",
                    ImagePath = "boatpaper.png",
                    UnitPrice = 2.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Rocket",
                    Description = "Can reach up to 200 feet in the air!",
                    ImagePath = "rocket.png",
                    UnitPrice = 122.99,
                    CategoryID = 5
                },

            };
            return products;
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {

                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boats"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                }
            };
            return categories;
        }
    }
}