namespace _09_Indexers
{

    class Laptop
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Model : {Model}, Price {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;
        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public Laptop GetLaptop(int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }
        public void SetLaptop(Laptop laptop , int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                laptops[index] = laptop;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set 
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

        }
        public Laptop this[string model]
        {
            get 
            { 
                foreach(Laptop laptop in laptops) 
                {
                    if(laptop.Model == model)
                    {
                        return laptop;
                    }
                }
                return null;
            }
            private set 
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    if (laptops[i].Model == model)
                    {
                        laptops[i] = value;
                        break;
                    }
                }
            }
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;
            }
            return -1;
        }
        public Laptop this[double price]
        { 
            get 
            { 
                int index = FindByPrice(price);
                if (index != -1)
                {
                    return laptops[index];
                }
                throw new Exception("Incorrect price");
            }
            set 
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    laptops[index] = value;
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(3);
            shop.SetLaptop(new Laptop() { Model = "HP", Price = 34444 }, 0);
            var laptop = shop.GetLaptop(0);
            Console.WriteLine(laptop);


            shop[1] = new Laptop() { Model = "DELL", Price = 14444 };
            Console.WriteLine(shop[1]);
            try
            {
                for (int i = 0; i < shop.Length + 3; i++)
                {
                    Console.WriteLine(shop[i]);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //shop["HP"] = new Laptop() { Model = "MAC", Price = 150000 };
            //Console.WriteLine(shop["MAC"]);
            shop[14444] = new Laptop() { Model = "Samsung", Price = 42000 };
            Console.WriteLine(shop[42000.00]);

        }
    }
}
