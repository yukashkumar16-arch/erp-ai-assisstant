


using System.Reflection.Metadata;
using System.Security.Cryptography;

Theatre th = new Theatre("PVR",10);

bool gl = th.Bookseats(4);
Console.WriteLine($"1.{gl} seats Left {th.Seatsleft}");

bool gl2 = th.Bookseats(7);
Console.WriteLine($"2.{gl2} seats Left {th.Seatsleft}");

bool gl3 = th.Bookseats(0);
Console.WriteLine($"3.{gl3} Seats Left {th.Seatsleft}");

bool gl4 = th.Bookseats(6);
Console.WriteLine($"4.{gl4} seats left {th.Seatsleft}");

bool gl5 = th.Bookseats(1);
Console.WriteLine($"5.{gl5} Seats left {th.Seatsleft}");


Theatre th2 = new Theatre("local",10);
Console.WriteLine(th2.Bookseats(-3));
class Theatre
{

    private int _seats;

    public int Seatsleft
    {
        get {return _seats;}
    }

    public string _name;
    public bool Bookseats(int count)
    {
        if (count <= 0 || count > _seats)
        {
            return false;
        }
        else
        {
            _seats = _seats - count;
            return true;
        }
    }
    public Theatre(string name, int seats)
    {
        _seats = seats;
        _name = name;

    }


}