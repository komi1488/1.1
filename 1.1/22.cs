using System;
class Program {
  static int Main() {
    
  int a = 0;
  int n = 0;
  int index = 0;
  int result = 1;

  Console.Write("a = ");
  a = int.Parse(Console.ReadLine());

  Console.Write("n = ");
  n = int.Parse(Console.ReadLine());

  for (index = 0; index < n; index++) {
    result = result * a;
  }

  Console.WriteLine(a + "^" + n + " = " + result);
  return 0;
  }
}
