using System;
using static System.Console;

class GCD {

  static void Main(String[] vars) {

    int[] numbas = Array.ConvertAll(vars, s =>int.Parse(s));

    if (numbas.Length > 1) {
      Array.Sort(numbas);
      WriteLine("The numbers you provided were:\n" + string.Join(",", numbas));
      int gcdValue = numbas[0];
      foreach(int numba in numbas) {
        int a,
        b;
        a = numba;
        gcdValue = gcd(a, gcdValue);
        WriteLine("For " + numba + ":");
        WriteLine("1 is a prime factor 1 time!");
        for (b = 2; a > 1; b++) {
          if (a % b == 0) {
            int x = 0;
            while (a % b == 0) {
              a /= b;
              x++;
            }
            WriteLine("{0} is a prime factor {1} times!", b, x);

          }
        }

      }

      WriteLine("The greatest common divisor is " + gcdValue);

    } else {
      WriteLine("Not enough numbers\nUsage:\ngcd.exe [your numbers here]");
    }

  }

  static int gcd(int a, int b) {
    while (a != 0 && b != 0) {
      if (a > b) a %= b;
      else b %= a;
    }

    return a | b;
  }

}