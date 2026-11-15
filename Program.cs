string [] movies = {"Leo","beast","master","scene"};

decimal[] price = {110m,180m,120m,130m};

decimal highestvalue = 0m;
string highestname= "";
int number = 1;
decimal total = 0;

for(int i =0; i< movies.Length;i++)
{
   if(price[i] > highestvalue)
    {
         highestvalue = price[i];
         highestname = movies[i];
    }

    if(price[i] > 160m)
    {
        Console.WriteLine($"{number} . the {movies[i]} is {price[i]} price and its premium");
    

    }
    else
    {
        Console.WriteLine($"{number} . the {movies[i]} is {price[i]} price");
    
    }

    total = total + price[i];
    number = number + 1;
}
    Console.WriteLine($"Highest name{highestname} value is {highestvalue}");

Console.WriteLine($"Total is {total}");