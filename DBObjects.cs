using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Very Fast Cars",
                        longDesc = "Modern electric car, good for city...",
                        img = "/img/TeslaModelS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобиль"]
                    },

                    new Car
                    {
                        name = "Lada Largus Cross",
                        shortDesc = "Family Car",
                        longDesc = "This car has increased cross-country ability, it is well suited for family trips to nature...",
                        img = "/img/LadaLargusCross.jpg",
                        price = 11000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классический автомобиль"]
                    },

                    new Car
                    {
                        name = "Ford Focus II",
                        shortDesc = "City ​​Car",
                        longDesc = "Well suited for city trips, has reduced fuel consumption",
                        img = "https://assets.avtocod.ru/storage/images/articles/m4bVnZNkJyynKstMKV3O41WGxJTCiW35Px5jOn6v.jpg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классический автомобиль"]
                    },

                    new Car
                    {
                        name = "Zero",
                        shortDesc = "New Urban Mini-Electric Car",
                        longDesc = "Zero is an electric city car that can seriously compete with Renault Twizy in the city transport segment with electric drive and compact dimensions.",
                        img = "https://24gadget.ru/uploads/posts/2018-05/thumbs/1526891776_zero-001.jpeg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобиль"]
                    }
                );

            }
            content.SaveChanges();
        }

        

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Электромобиль", desc="Современный вид транспорта" },
                        new Category{ categoryName = "Классический автомобиль", desc="Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category el in list)
                          category.Add(el.categoryName, el);

                }
                return category;
            }
        }
    }
}
