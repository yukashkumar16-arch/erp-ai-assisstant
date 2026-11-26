
Movielibrary lib = new Movielibrary();
Console.WriteLine(lib.AddMovie(new Movie("KAKA",150)));
Console.WriteLine(lib.AddMovie(new Movie("Jilla",160)));
Console.WriteLine(lib.AddMovie(new Movie("GTA", 170)));
Console.WriteLine(lib.AddMovie(new Movie("KAKA", 150)));
Console.WriteLine($"Movie Count is {lib.count}");

Console.WriteLine($"The Current Count is {lib.count}");

lib.Remove("KAKA");

Console.WriteLine($"The Current Count after remove is {lib.count}");


Console.WriteLine($"Remove KAKA Again{lib.Remove("KAKA")}");
Console.WriteLine($"Remove Kaithi{lib.Remove("Kaithi")}");

Console.WriteLine($"Find KAKA {(lib.FindMovie("KAKA") == null ? "null" : "Found")}");

Movie? Findresult = lib.FindMovie("Beast");

if(Findresult != null)
{
    Console.WriteLine($"{Findresult.Title} Rs is {Findresult.Price}");
}
else
{
    Console.WriteLine($"Not Found");
}

Movie? FindMovie2 = lib.FindMovie("GTA");

if(FindMovie2 != null)
{
    Console.WriteLine($"{FindMovie2.Title} Rs {FindMovie2.Price}");
}
else
{
    Console.WriteLine($"Not Found");
}
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

    public Movie? FindMovie(string title)
    {
        foreach(Movie m in _movies)
        {
            if(m.Title == title)
            {
                return m;
            }
        }
        return null;
    }

    public bool Remove(String title)
    {
        Movie? m = FindMovie(title);

        if(m != null)
        {
            _movies.Remove(m);
            return true;
        }
        else
        {
             return false;
        }

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

