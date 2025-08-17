using System.Text;
using GCAssignment;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

//Best practice: using → Dispose() gets called, finalizer suppressed
using (var p = new Play("Кассандра", "Леся Українка", "Драма", 1907))
{
    Console.WriteLine(p);
}

using (var s = new Shop("Dolce", "вул. Хрещатик, 15", ShopType.Footwear))
{
    Console.WriteLine(s);
}

//What hapens when we don't use using and forget to dispose manually: "forgotten" objects are created in a separate method to make sure they are out of scope at the end
CreateForgottenObjects();

// force GC so we can see finalizers work
GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();

static void CreateForgottenObjects()
{
    var forgottenPlay = new Play("Лісова пісня", "Леся Українка", "Драма-феєрія", 1911);
    var forgottenShop = new Shop("АТБ", "вул. Каштанова, 10", ShopType.Groceries);
    Console.WriteLine(forgottenPlay);
    Console.WriteLine(forgottenShop);
    // no Dispose(), no return → after this method returns they’re collectible
}