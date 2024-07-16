using ProductApp;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product[] product = new Product[]
            {
                new Product(1,"Shirt",2000,10),
                new Product(2,"Trouser",1500,5)
            };

            bool mainWhileLoop = true;
            int userProductId;

            while (mainWhileLoop)
            {
                Console.WriteLine("Press 1 for Entering the Product Id or 2 to Exit");

                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the Product Id");
                        userProductId = int.Parse(Console.ReadLine());
                        Product selectedProduct = product[userProductId - 1];

                        selectedProduct.GetAllDetails(out string productName, out int productPriceBeforeDiscount, out double productDiscountPercentage, out double productPriceAfterDiscount);

                        Console.WriteLine("The Product's Id is {0}", userProductId);
                        Console.WriteLine("The Product's Name is {0}", productName);
                        Console.WriteLine("The Product's Actual Price is {0}", productPriceBeforeDiscount);
                        Console.WriteLine("The Product's Discount Percentage is {0}", productDiscountPercentage);
                        Console.WriteLine("The Product's Price After Discount is {0}", productPriceAfterDiscount);
                        break;
                    case 2:
                        Console.WriteLine("Exiting......");
                        mainWhileLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }


            }
        }

    }
}