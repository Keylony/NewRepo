using System;

namespace SortString
{
  class Program
  {
    string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
    string[] sa = s.Split(“ “);

    Array.Sort(sa);

      s = string.Join(" ", sa); Console.WriteLine(s);
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
