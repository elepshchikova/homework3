System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int d1 = n / 10000;
n -= d1 * 10000;
int d2 = n / 1000;
n -= d2 * 1000;
int d3 = n / 100;
n -= d3 * 100;
int d4 = n / 10;
n -= d4 * 10;
int d5 = n % 10;
if (d1 == d5 && d2 == d4){
    System.Console.WriteLine("палиндром");
}
else{
    System.Console.WriteLine("не палиндром");
}