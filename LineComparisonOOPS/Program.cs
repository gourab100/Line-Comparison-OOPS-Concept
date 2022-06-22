using LineComparisonOOPS;



 
    Line line = new Line();

    double line1 = line.lengthofline();
    double line2 = line.lengthofline();

    Console.WriteLine(line1);
    Console.WriteLine(line2);

    if (line1 == line2)
    {
        Console.WriteLine("to equal");
    }
    else if (line1 < line2)
    {
        Console.WriteLine("line2 greater then line1");
    }
    else
    {
        Console.WriteLine("line2 is less");
    }
