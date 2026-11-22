#region question 1
//double[] prices = { 25.5, 40.0, 33.75 };

//Console.WriteLine(prices[1]);
#endregion
#region question 2
//int[,] shelfCopies = { 
//{3,5},
//{1,4}
//};
//Console.WriteLine(shelfCopies[1, 0]);
#endregion
#region question 3
//static void printWelcomewMessage()
//{
//    Console.WriteLine("Welcome  to library");
//}
//printWelcomewMessage();
#endregion
#region question 4
//static void printBookTitle(string title)
//{
//    Console.WriteLine("Book title: " + title);
//}
//printBookTitle("clean code");
#endregion
#region question 5
//class program
//{
//    static void addBonusPages(int pages)
//    {
//        pages = pages + 50;
//    }
//    static void Main()
//    {
//        int pages = 400;
//        addBonusPages(pages);

//        Console.WriteLine(pages);
//    }
//}
#endregion
#region question 6
//class program
//{
//    static void ApplyDiscount(double[] prices)
//    {//#region question 6
//        prices[0] = prices[0] - 5;
//    }
//    static void Main()
//    {
//        double[] prices = { 25.5, 40.0 };

//        ApplyDiscount(prices);

//        Console.WriteLine(prices[0]);
//    }
//}

#endregion
#region question 7
//class program
//{
//    static void addBonusPagesByRef(ref int pages)
//    {
//        pages = pages + 50;
//    }
//    static void Main()
//    {
//        int pages = 400;

//        addBonusPagesByRef(ref pages);

//        Console.WriteLine(pages);
//    }
//}
#endregion
#region question 8
//class program
//{

//    static void ReplaceArray(ref double[] prices)
//    {
//        prices = new double[] { 10.0, 12.5, 15.0 };
//    }
//    static void Main()
//    {
//        double[] prices = { 25.5, 40.0 };

//        ReplaceArray(ref prices);

//        Console.WriteLine(prices.Length);
//    }
//}
#endregion
#region question 9
//class program
//{
//    static bool TryGetPrice(string title, out double price)
//    {
//        if (title == "Clean Code")
//        {
//            price = 25.5;
//            return true;
//        }
//        else
//        {
//            price = 0;
//            return false;
//        }
//    }
//    static void Main()
//    {
//        double price;

//        if (TryGetPrice("Clean Code", out price))
//        {
//            Console.WriteLine(price);
//        }
//    }
//}

#endregion
#region question 10
//class program
//{
//    static void PrintBookInfo(string title, int pages = 300)
//    {
//        Console.WriteLine("Book title: " + title);
//        Console.WriteLine("Pages: " + pages);
//    }
//    static void Main()
//    {
//        PrintBookInfo("Clean Code");

//        PrintBookInfo("Java Basics", 450);
//    }
//}
#endregion
#region question 11 
//class program
//{
//    static void PrintBookInfo(string title, int pages = 300)
//    {
//        Console.WriteLine("Book title: " + title);
//        Console.WriteLine("Pages: " + pages);
//    }
//    static void Main()
//    {
//        PrintBookInfo(pages: 500, title: "C# Programming");
//    }
//}
#endregion
#region question 12
// class program
//{
//    static void PrintAllTitles(params string[] titles)
//    {
//        foreach (string title in titles)
//        {
//            Console.WriteLine(title);
//        }
//    }
//    static void Main()
//    {
//        PrintAllTitles("Clean Code", "Java Basics", "C# Programming");
//    }
//}
#endregion
