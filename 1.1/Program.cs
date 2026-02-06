using System;
class Program {
  static int Main() {
  Console.Write("Enter the number x (at least 3 digits): ");
  string input = Console.ReadLine();

  int n = 0;
  char firstDigit = input[0];
  char secondDigit = input[1];
  string rest = input.Substring(2);

  string withoutSecond = firstDigit + rest;

  string resultStr = withoutSecond + secondDigit;

  n = int.Parse(resultStr);

  Console.WriteLine($"n = {n}");
  return 0;
  }
}
