
namespace PointOfSale
{
    public class Program
    {
        public static void Main()
        {
            Product bagOfOranges = new Product("Bag Of Oranges", Product.Category.Produce, "8 pound bag of oranges", 6.99);
            Product bagOfLimes = new Product("Bag of Limes", Product.Category.Produce, "1 pound bag of key limes", 3.99);
            Product bagOfSpinach = new Product("Bag of Spinach", Product.Category.Produce, "10 ounce bag of spinach", 2.18);
            
            Product PopcornBag = new Product("Microwave Popcorn", Product.Category.Snacks, "Cousin WIllies Butter Explosion 3 pack microwave popcorn", 2.29);
            Product BagOfPretzels = new Product("Bag of Pretzels", Product.Category.Snacks, "Bag of dots original seasonzed pretzels 16 ounces", 5.99);
            Product Cheezits = new Product("Box of Cheez-Its", Product.Category.Snacks, "21 0unce family size box of original cheez its", 4.54);

            Product WhiteBread = new Product("Loaf of white bread", Product.Category.Bread, "1 loaf of sunbeam white bread", 2.08);
            Product SourDough = new Product("Loaf of sourdough bread", Product.Category.Bread, "1 loaf of Brownberry Sourdough bread", 3.18);
            Product HotDogBuns = new Product("Pack of Hot Dog buns", Product.Category.Bread, "8 count ball park white hot dog buns", 2.58);

            Product GallonOfMilk = new Product("Gallon of 2% Milk", Product.Category.Dairy, "Gallon of fairlife 2% milk", 3.98);
            Product PackOfYogurt = new Product("Yoplait Yogurt", Product.Category.Dairy, "8 pack of Yoplait Strawberry and Banana Yogurt", 4.36);
            Product CoffeeCreamer = new Product("Carmel Macchiato Creamer", Product.Category.Dairy, "32 ounce container of Internation delight coffee creamer", 3.24);

            List<Product> Products = new List<Product>();
            Products.Add(CoffeeCreamer);
            Products.Add(GallonOfMilk);
            Products.Add(PackOfYogurt);
            Products.Add(WhiteBread);
            Products.Add(SourDough);
            Products.Add(HotDogBuns);
            Products.Add(bagOfLimes);
            Products.Add(bagOfOranges);
            Products.Add(bagOfSpinach);

           

        }
    }
}