string itemname = "ironrod";
int quantity = 5;
decimal unitprice = 50;

decimal totalvalue = quantity * unitprice;
decimal gst = totalvalue * 18/100;

Console.WriteLine($"Item name {itemname} quantity is {quantity} unit price is {unitprice} gst is {gst}");
