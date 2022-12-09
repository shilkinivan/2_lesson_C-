Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string i =Convert.ToString(n);
if (n>99)
{
Console.WriteLine(i[2]); 
}
else
{
Console.WriteLine("Третьей цифры нет");
}