
Movie leo = new Movie("Leo",150m);
Movie beast = new Movie("Beast",180m);
Movie Master = new Movie("Master",250m);

List<Movie> movies = new List<Movie> {leo,beast,Master};

foreach(Movie m in movies)
{
    Console.WriteLine($"movie {m.Title} Rs is {m.Price} with gst {m.PremiumGst()}");
}


class Movie
{
    public string Title { get; set;}
    //public decimal Price {get;set;}
    private decimal _price;

    public decimal Price
    {
        get {return _price;}
        set
        {
            if(value <0)
            {
                throw new ArgumentException("Price can't be in minus");
            }
            _price = value;
        }
    }

    public decimal PremiumGst()
    {
        return Price + Price * 0.18m;
    }

    public Movie(string title,decimal price)
    {
        Title = title;
        Price = price;
    }

}

