static decimal Addgst(decimal price)
{
    decimal gst = 0.18m * price;
    return price = price + gst;
}

static decimal AddpricewithDiscount(decimal price)
{
    decimal gst = 0.18m * price;
    decimal discount = 10m * price/100;
    return price = price + gst - discount;

}
Console.WriteLine(Addgst(200));
Console.WriteLine(Addgst(50));

Console.WriteLine(AddpricewithDiscount(200));
Console.WriteLine(AddpricewithDiscount(50));