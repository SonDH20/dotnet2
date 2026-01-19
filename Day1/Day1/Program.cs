// See https://aka.ms/new-console-template for more information
// Bai tap 1

Console.WriteLine("Nhap so ngay: ");
int days = int.Parse(Console.ReadLine()!);
Console.WriteLine($"So tuan la: {days / 7}, so ngay con lai la: {days % 7}");


//Bai tap 2

Console.WriteLine("Nhap so tien: ");
int amount = int.Parse(Console.ReadLine()!);
Console.WriteLine("Nhap so % giam gia: ");
float discount = int.Parse(Console.ReadLine()!);
Console.WriteLine($"So tien giam gia la: {amount * discount / 100}");
Console.WriteLine($"So tien phai tra la: {amount - (amount * discount / 100)}");

//Bai tap 3

Console.WriteLine("Nhap vao so phut: ");
int totalMinutes = int.Parse(Console.ReadLine()!);
Console.WriteLine($"So tuan la: {totalMinutes / 60}, so ngay con lai la: {totalMinutes % 60}");


//Bai tap 4

