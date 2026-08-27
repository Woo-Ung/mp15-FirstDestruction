using System;
using System.Collections.Generic;

public class WHAT
{
    public string Who { get; set; }
    public string When { get; set; }
    public string Where { get; set; }
    public string What { get; set; }
    public string How { get; set; }
    public string Why { get; set; }

    public void Pringinfo()
    {
        Console.WriteLine($"{How}");
    }
}