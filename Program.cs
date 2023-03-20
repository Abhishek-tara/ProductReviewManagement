﻿using System.Data;

namespace ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Review Mangement");

            // UC1 - Adding a values in a list
            List<ProductReview> list = new List<ProductReview>
            {
                new ProductReview(){ProductID = 1, UserID = 1, Rating =3, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 2, UserID = 2, Rating =2, Review ="Good", isLike = false },
                new ProductReview(){ProductID = 3, UserID = 3, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 4, UserID = 4, Rating =5, Review ="nice", isLike = true },
                new ProductReview(){ProductID = 5, UserID = 5, Rating =0, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 6, UserID = 6, Rating =7, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 7, UserID = 6, Rating =10, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 8, UserID = 5, Rating =9, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 9, UserID = 7, Rating =8, Review ="nice", isLike = true },
                new ProductReview(){ProductID = 10, UserID = 3, Rating =2, Review ="Good", isLike = false },
                new ProductReview(){ProductID = 11, UserID = 2, Rating =5, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 12, UserID = 8, Rating =9, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 13, UserID = 9, Rating =1, Review ="Good", isLike = false },
                new ProductReview(){ProductID = 14, UserID = 6, Rating =8, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 15, UserID = 7, Rating =3, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 16, UserID = 4, Rating =7, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 17, UserID = 3, Rating =4, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 18, UserID = 10, Rating =2, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 19, UserID = 8, Rating =3, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 20, UserID = 1, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 21, UserID = 7, Rating =10, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 22, UserID = 4, Rating =7, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 23, UserID = 6, Rating =8, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 24, UserID = 9, Rating =4, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 25, UserID = 10, Rating =2, Review ="Bad", isLike = false },
            };

            // UC8-- > Using DataTable
            //table
            DataTable dataTable = new DataTable();
            //columns
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("isLike", typeof(bool));
            //rows
            dataTable.Rows.Add(1, 1, 3, "Bad", false);
            dataTable.Rows.Add(2, 2, 2, "Bad", false);
            dataTable.Rows.Add(3, 3, 1, "Bad", false);
            dataTable.Rows.Add(4, 4, 5, "Good", true);
            dataTable.Rows.Add(5, 5, 0, "Bad", false);
            dataTable.Rows.Add(6, 6, 7, "Good", true);
            dataTable.Rows.Add(7, 7, 10, "Best", true);
            dataTable.Rows.Add(8, 8, 9, "Best", true);
            dataTable.Rows.Add(9, 9, 8, "Best", true);
            dataTable.Rows.Add(10, 10, 2, "Bad", false);
            dataTable.Rows.Add(11, 11, 5, "Good", true);
            dataTable.Rows.Add(12, 12, 9, "Best", true);
            dataTable.Rows.Add(13, 13, 1, "Bad", false);
            dataTable.Rows.Add(14, 14, 8, "Best", true);
            dataTable.Rows.Add(15, 15, 3, "Bad", false);
            dataTable.Rows.Add(16, 16, 7, "Good", true);
            dataTable.Rows.Add(17, 17, 4, "Good", true);
            dataTable.Rows.Add(18, 18, 2, "Bad", false);
            dataTable.Rows.Add(19, 19, 3, "Bad", false);
            dataTable.Rows.Add(20, 19, 1, "Bad", false);
            dataTable.Rows.Add(21, 19, 10, "Best", true);
            dataTable.Rows.Add(22, 19, 7, "Good", true);
            dataTable.Rows.Add(23, 19, 8, "Best", true);
            dataTable.Rows.Add(24, 19, 4, "Good", true);
            dataTable.Rows.Add(25, 19, 2, "Bad", false);
            // Display the details in list
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"Product ID: {item.ProductID}, User ID: {item.UserID}, Rating: {item.Rating}, Review: {item.Review}, Like: {item.isLike}");
            //}

            ///UC2
            //Management.GetTopThree(list);

            //UC3
            //Management.RatingAboveThree(list);

            //UC4
            //Management.CountByReview(list);

            //UC5
            // Management.GetParticularFields(list);

            //UC6
            //Management.SkipTopRecords(list);

            //UC7
            //Management.GetParticular(list);

            //UC8
            //Management.PrintTable(dataTable);

            //UC9
            Management management = new Management();
            //management.PrintTrueTable(dataTable);

            //UC10
            //Management.AverageRating(dataTable);

            //UC11
            management.ReviewIsBest(dataTable);

        }
    }
}