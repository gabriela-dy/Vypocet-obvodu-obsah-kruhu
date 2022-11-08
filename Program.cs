Console.WriteLine("Zadejte poloměr kruhu:");
int a = int.Parse(Console.ReadLine());

obvod = 2 * 3.1415 * a;
obsah = 3.1415 * Math.Pow(a,2);

Console.WriteLine("Obvod kruhu je:" + obvod);
Console.WriteLine("Obsah kruhu je:" + obsah);
Console.ReadKey();
