
string[] names = { "Arun", "Meena", "Karthik", "Divya", "Ravi", "Sneha", "RV", "RK", "RB" };
string[] movies = { "Leo", "Beast", "Master", "Scene", "Leo", "Beast", "A", "B", "C" };
decimal[] prices = { 150, 180, 250, 130, 150, 180, 190, 190, 190 };
int[] ages = { 25, 11, 60, 12, -5, 59, 0, 120, 121 };
int[] tickets = { 2, 3, 1, 4, 2, 2, 3, 2, 2 };

static decimal GetDiscountRate(int age)
{
    if (age < 0 || age > 120)
    {
        return -1m;
    }
    else
    {

        if (age < 12)
        {
            return 0.5m;
        }
        else if (age >= 60)
        {
            return 0.2m;
        }
        else
        {
            return 0m;
        }
    }
}

static decimal CalculateBill(decimal price, int ticket, decimal discountrate)
{
    decimal Subprice = price * ticket;
    decimal priceafterdisc = Subprice - (Subprice * discountrate);
    decimal newprice = priceafterdisc + (priceafterdisc * 18 / 100);

    return Math.Round(newprice, 2);
}

static bool Validticketcheck(int ticket)
{
    if (ticket < 1 || ticket > 10)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int numberofskipped = 0;
decimal totalgrand = 0m;
decimal highchk = 0m;
string highest = "";

int billed = 0;
for (int i = 0; i < movies.Length; i++)
{
    bool ticvalid = Validticketcheck(tickets[i]);

    decimal discrate = GetDiscountRate(ages[i]);
    if (discrate == -1m || ticvalid == false)
    {
        if (discrate == -1m)
        {
            Console.WriteLine($"{names[i]} is invalid age so skipped");
        }
        if (ticvalid == false)
        {
            Console.WriteLine($"{i + 1}. {names[i]} has selected invalid ticket count");

        }
        numberofskipped = numberofskipped + 1;
    }

    else
    {
        decimal finalbill = CalculateBill(prices[i], tickets[i], discrate);

        Console.WriteLine($"{i + 1}. {names[i]} - {movies[i]}x{tickets[i]}- Rs {finalbill:F2}");
        totalgrand = totalgrand + finalbill;

        if (finalbill > highchk)
        {
            highest = $"{names[i]} have the highest price{finalbill:F2}";
            highchk = finalbill;
        }

        billed = billed + 1;




    }



}

Console.WriteLine($"Grand Total is {totalgrand:F2} and total skipped is {numberofskipped}");
Console.WriteLine(highest);
decimal average = billed == 0 ? 0 : totalgrand / billed;
if(average !=0)
{
    Console.WriteLine($"Average of Booking is {Math.Round(average,2)}");
}
else
{
    
    Console.WriteLine($"Average of Booking is not available no booking happened");
}