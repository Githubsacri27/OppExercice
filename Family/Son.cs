namespace Family
{
    public class Son : Father
    {
        public string Languages { get; set; }
        protected string FavoriteSport { get; set; }
        private string VideoGames { get; set; }

        //Añadir un constructor en la clase Son que asigne valor a cada uno de los nueve campos
        public Son(string name, int age, string favoriteColor, string job, string country, string address,
                   string languages, string favoriteSport, string videoGames)
            : base(name, age, favoriteColor, job, country, address) 
        {
            Languages = languages;
            FavoriteSport = favoriteSport;
            VideoGames = videoGames;
        }

        public string GetVideoGames() => VideoGames;
        public void SetVideoGames(string value) => VideoGames = value;

        // Añadir un método en la clase Son que muestre por consola el valor de los nueve campos
        public void ShowValues()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Favorite Color: {GetFavoriteColor()}");
            Console.WriteLine($"Job: {Job}");
            Console.WriteLine($"Hobby: {Country}");
            Console.WriteLine($"Address: {GetAddress()}");
            Console.WriteLine($"Languages: {Languages}");
            Console.WriteLine($"Favorite Sport: {FavoriteSport}");
            Console.WriteLine($"VideoGames: {GetVideoGames()}");
        }

        // Añadir un método en la clase Son que permita modificar el valor de cada uno de los nueve campos, y vuelva a mostrar los nueve campos tras aplicar las modificaciones
        public void ModifyValues()
        {
            Console.WriteLine("Modify Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Modify Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Modify Favorite Color: ");
            SetFavoriteColor(Console.ReadLine());

            Console.WriteLine("Modify Job: ");
            Job = Console.ReadLine();

            Console.WriteLine("Modify Country: ");
            Country = Console.ReadLine();

            Console.WriteLine("Modify Address: ");
            SetAddres(Console.ReadLine());

            Console.WriteLine("Modify Languages: ");
            Languages = Console.ReadLine();

            Console.WriteLine("Modify Favorite Sport: ");
            FavoriteSport = Console.ReadLine();

            Console.WriteLine("Modify VideoGames: ");
            SetVideoGames(Console.ReadLine());

            // Mostrar nuevamente
            Console.WriteLine("Updated Values:");
            ShowValues();
        }
    }

}
