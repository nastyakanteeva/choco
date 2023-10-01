int money = 15; int price = 1; int wrap = 3;

int a = money / price;
int b = a + (a - 1) / (wrap - 1);
Console.WriteLine(b);