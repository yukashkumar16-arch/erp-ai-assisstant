static decimal Ticketprice(int Age)
{
    if(Age < 0 || Age > 120)
    {
        return -1m;
    }
    else if(Age < 12)
    {
     return 80m;   
    }
    else if(Age < 60)
    {
        return 150m;
    }
    
    else
    {
        return 100m;
    }
}
Console.WriteLine(Ticketprice(0));
Console.WriteLine(Ticketprice(120));
Console.WriteLine(Ticketprice(121));