what ive learned today, ive learned that \t is tabs and that \n is new line.
  ex.
  Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
ive learned that \" can make certain invalid things valid.
  ex.
  Console.WriteLine("Hello "World"!"); (non valid)
Console.WriteLine("Hello \"World\"!"); (is valid)
if you wanna display a \ in a string you can use \\ to make it valid
ex.
  Console.WriteLine("c:\source\repos"); (non valid)
Console.WriteLine("c:\\source\\repos"); (is valid and shows the \)
using @ before a string makes all empty space valid
ex
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
