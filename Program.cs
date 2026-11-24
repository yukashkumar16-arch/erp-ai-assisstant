using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Movie? found = FoundMovie("Master");

if(found == null)
{
    
Console.WriteLine($"not found");
}
else
{
    
Console.WriteLine($"found{found.Title}");
}


string[] cast = new string[3];
cast[0] = "Vijay";
if(cast[1]!= null)
{
    
Console.WriteLine($"Cast is {cast[1].ToUpper()}");
}


Movie[] shelf = new Movie[2];
shelf[0] = new Movie("Jilla",150m);

foreach(Movie m in shelf)
{
    if(m != null)
    {
      Console.WriteLine($"Movie name is {m.Title} and price {m.Price}");
   
    }
    else
    {
         Console.WriteLine($"Not Found");
   
    }
   }

static Movie? FoundMovie(string title)
{
    Movie[] all = {new Movie("Leo",150m),new Movie("Beast",150m)};
    
    foreach(Movie Candidate in all)
    {
        if(title == Candidate.Title)
        {
            return Candidate;
        }
    }
    return null;
}



class Movie
{
    
  public string Title { get; set;}

  public decimal Price {get;set;}

  public Movie(string name,decimal prices)
    {
        Title = name;
        Price = prices;
    }

}