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
Console.WriteLine("Nhap so tien: ");
int amount1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Nhap so % giam gia: ");
float vat = int.Parse(Console.ReadLine()!);
Console.WriteLine($"So tien giam gia la: {amount1 * discount / 100}");
Console.WriteLine($"So tien phai tra la: {amount1 + (amount1 * discount / 100)}");

//Bai tap 5
Console.WriteLine("Nhap so tien USD: ");
float usd = float.Parse(Console.ReadLine()!);
Console.WriteLine("Nhap ti gia: ");
float rate = float.Parse(Console.ReadLine()!);
Console.WriteLine($"So tien VND la: {usd * rate}");

//Bai tap 6
Console.WriteLine("Nhap so tien trong tai khoan: ");
float balance = float.Parse(Console.ReadLine()!);
Console.WriteLine("Nhap so tien muon rut: ");
float withdraw = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Rut tien thanh cong. So du con lai: {balance - withdraw}");

//Bai tap 7
Console.WriteLine("Nhap vao quang duong (km): ");
float distance = float.Parse(Console.ReadLine()!);
Console.WriteLine("Nhap vao thoi gian (gio): ");
float time = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Van toc trung binh la: {distance / time} km/h");

//Bai tap 8
Console.WriteLine("Nhap vao mot so: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Nhap vao 1 tong so: ");
int sum = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ti le % cua so tren tong so la: {number/sum * 100}%");

//Bai tap 9
Console.WriteLine("Nhap vao van toc km/h: ");
float speed = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Van toc m/s la: {speed * 0.27} m/s");

//Bai tap 10
Console.WriteLine("Nhap vao so phut da tap the duc: ");
int exerciseMinutes = int.Parse(Console.ReadLine()!);
Console.WriteLine($"So calo da dot chay khi chay la: {exerciseMinutes * 12} calos ," +
    $"So calo da dot chay khi boi la: {exerciseMinutes * 55} calos ");
