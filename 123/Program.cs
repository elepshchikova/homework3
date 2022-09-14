// // System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int d1 = n / 10000;
// n -= d1 * 10000;
// int d2 = n / 1000;
// n -= d2 * 1000;
// int d3 = n / 100;
// n -= d3 * 100;
// int d4 = n / 10;
// n -= d4 * 10;
// int d5 = n % 10;
// if (d1 == d5 && d2 == d4){
//     System.Console.WriteLine("палиндром");
// }
// else{
//     System.Console.WriteLine("не палиндром");
// }


// //int x1 = 7;
// int y1 = -5;
// int z1 = 0;

// int x2 = 1;
// int y2 = -1;
// int z2 = 9;

// double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// System.Console.WriteLine(distance);


// // int n = 5;
// for (int i = 1; i <= n; i++)
// {
//     System.Console.WriteLine(Math.Pow(i, 3));
// }

// //System.Console.WriteLine("Введите число a");
// double a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число b");
// int b = Convert.ToInt32(Console.ReadLine());
// double res = 1.0;
// static.doublepower3(double a, int b) {

//   if (b < 0);

//   { 
//     (a, b) = (1.0 / a, -b);
//   }
//   for (; b != 0; a *= a, b /= 2) {
//     if (b % 2 != 0)
//      { 
//         res *= a; }
//   }
//   return res;  
// }



  
  Console.Write("Введите число : ");
  int num = int.Parse(Console.ReadLine());
  
  Console.Write("Введите степень :  ");
  int n = int.Parse(Console.ReadLine());
 
  int num_n=1;
  for(int i=0; i<n; i++) {
   num_n*=num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
  Console.ReadKey();
  return 0;
 
