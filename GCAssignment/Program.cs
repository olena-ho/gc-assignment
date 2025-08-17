using System.Text;
using GCAssignment;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

var p1 = new Play("Лісова пісня", "Леся Українка", "Драма-феєрія", 1911);
var p2 = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1601);
Console.WriteLine(p1);
Console.WriteLine(p2);

using (var s1 = new Shop("АТБ", "вул. Каштанова, 10", ShopType.Groceries))
{
    Console.WriteLine(s1);
}


var s2 = new Shop("Zara", "пр. Червоної Калини, 3", ShopType.Clothing);
Console.WriteLine(s2);
s2.Dispose();

p1 = null;
p2 = null;
GC.Collect();
GC.WaitForPendingFinalizers();

Console.ReadLine();