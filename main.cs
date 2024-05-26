using System;

class Program {
  public static void Main (string[] args) {
   var unitTestOne = string.Join(
    Environment.NewLine,
     "Lucinda Potter",
     "6/24/1992",
     "work 000-000-0101",
     "cell 000-000-0189");
    var unitTestTwo = string.Join(
      Environment.NewLine,
       "John Smith",
       "8/15/1978",
       "work 000-111-0101",
       "cell 000-111-0189");
    var unitTestThree = string.Join(
      Environment.NewLine,
       "Chris Johnson",
       "12/01/1987",
       "work 000-222-0101",
       "cell 000-222-0189");
    var unitTestFour = string.Join(
      Environment.NewLine,
       "Robert Hall",
       "2/27/1949",
       "work 000-333-0101",
       "cell 000-333-0189");
    Console.WriteLine (unitTestOne);
    Console.WriteLine (unitTestTwo);
    Console.WriteLine (unitTestThree);
    Console.WriteLine (unitTestFour);
  }
}