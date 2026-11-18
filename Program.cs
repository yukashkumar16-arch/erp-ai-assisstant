static decimal Calculateprice(decimal price,int ticket)
{
    decimal subtotal = 0m;
    return subtotal = price * ticket;
}

static decimal finalprice(decimal price,int ticket)
{
    decimal subtotal = 0m;
    decimal finalprice = 0m;
   subtotal = Calculateprice(price,ticket);
   return finalprice = subtotal + subtotal * 0.18m;

}

Console.WriteLine(Calculateprice(150m,3));
Console.WriteLine(Calculateprice(120m,5));
Console.WriteLine(finalprice(100m,2));

string[] movies = {"beast","leo","AA","bb","ccc"};
decimal[] price = {120m,110,100,150m,250m};

// foreach(string movie in movies)
// {
    
    
// }

for(int i=0;i<movies.Length;i++)
{
    Console.WriteLine($"Movies final {movies[i]} price is {finalprice(price[i],2)}");
}