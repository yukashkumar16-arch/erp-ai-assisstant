
Movielibrary lib = new Movielibrary();
Console.WriteLine(lib.AddMovie(new Movie("KAKA",150)));
Console.WriteLine(lib.AddMovie(new Movie("Jilla",160)));
Console.WriteLine(lib.AddMovie(new Movie("GTA", 170)));
Console.WriteLine(lib.AddMovie(new Movie("KAKA", 150)));
Console.WriteLine($"Movie Count is {lib.count}");


class Movielibrary
{
    private List<Movie> _movies = new List<Movie>();

    public int count
    {
        get
        { return _movies.Count; }
    }

    public bool AddMovie(Movie M1)
    {
        
            foreach (Movie m in _movies)
            {
                if (m.Title == M1.Title)
                {
                    return false;
                }
                
            }
        
            _movies.Add(M1);
             return true;

    }


}

class Movie
{

    public string Title { get; set; }

    private decimal _price;

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            _price = value;
        }
    }

    public Movie(string title, decimal price)
    {
        Title = title;
        Price = price;
    }




}

