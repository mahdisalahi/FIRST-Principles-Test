using FIRSTPrinciplesProj;

var orderBy = "Id, Name, Tel";

var sep = new IndependentExp();
var res = sep.Seprator(orderBy);

foreach (var item in res)
{
    Console.WriteLine(item.Trim());
}

Console.ReadKey();