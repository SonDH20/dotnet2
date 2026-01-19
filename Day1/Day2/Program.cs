// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Bai tap 1 - Day 2
Console.WriteLine("Nhap nhiet do ngoai troi: ");
float outsideTemp = float.Parse(Console.ReadLine()!);
switch (outsideTemp)
{
    case > 0:
        Console.WriteLine("Troi am");
        break;
    case < 0:
        Console.WriteLine("Troi lanh, co the co bang gia");
        break;
    default:
        Console.WriteLine("Troi rat lanh, dung 0 do C");
        break;
}

// Bai tap 2 - Day 2
Console.WriteLine("Nhap vao so tien thu nhap hang thang: ");
float monthlyIncome = float.Parse(Console.ReadLine()!);
switch (monthlyIncome)
{
    case < 5000000:
        Console.WriteLine("Mien thue");
        break;
    case >= 5000000 and < 10000000:
        Console.WriteLine("Thue suat 10%");
        Console.WriteLine($"So tien thue can nop la: {monthlyIncome * 10 / 100}");
        break;
    case >= 10000000:
        Console.WriteLine("Thue suat 20%");
        Console.WriteLine($"So tien thue can nop la: {monthlyIncome * 20 / 100}");
        break;
}

// Bai tap 3 - Day 2
Console.WriteLine("Nhap vao so thang trong nam: ");
int month = int.Parse(Console.ReadLine()!);
switch (month)
{
    case 1 or 2 or 3:
        Console.WriteLine("Mua Xuan");
        break;
    case 4 or 5 or 6:
        Console.WriteLine("Mua Ha");
        break;
    case 7 or 8 or 9:
        Console.WriteLine("Mua Thu");
        break;
    case 10 or 11 or 12:
        Console.WriteLine("Mua Dong");
        break;
    default:
        Console.WriteLine("Khong phai thang trong nam");
        break;
}

// Bai tap 4 - Day 2
Console.WriteLine("Nhap vao tuoi cua cong dan: ");
int age = int.Parse(Console.ReadLine()!);
switch (age)
{
    case < 18:
        Console.WriteLine("Chua du tuoi tham gia NVQS");
        break;
    case >= 18 and < 27:
        Console.WriteLine("Du tuoi tham gia NVQS");
        break;
    case > 18:
        Console.WriteLine("Qua tuoi tham gia NVQS");
        break;
}

// Bai tap 5 - Day 2
Console.WriteLine("Nhap vao so can kiem tra: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 2)
{
    Console.WriteLine("So khong hop le");
    return;
}
if (num == 2)
{
    Console.WriteLine($"{num} la so nguyen to");
    return;
}
if (num > 2)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine($"{num} khong phai la so nguyen to");
            return;
        }
    }
    Console.WriteLine($"{num} la so nguyen to");
}

else
{
    Console.WriteLine($"{num} khong la so nguyen to");
}


// Bai tap 6 - Day 2
Console.WriteLine("Nhap vao muc tieu thu dien cua gia dinh: ");
int consumption = int.Parse(Console.ReadLine()!);
float totalBill = 0;
switch (consumption)
{
    case < 100:
        totalBill = consumption * 1500;
        Console.WriteLine($"So tien dien phai tra la: {totalBill} VND");
        break;
    case > 100 and <= 200:
        totalBill = (100 * 1500) + ((consumption - 100) * 2000);
        Console.WriteLine($"So tien dien phai tra la: {totalBill} VND");
        break;
    case > 200:
        totalBill = (100 * 1500) + (100 * 2000) + ((consumption - 200) * 2500);
        Console.WriteLine($"So tien dien phai tra la: {totalBill} VND");
        break;
    default:
        Console.WriteLine($"So nhap vao khong hop le");
        break;

}

// Bai tap 7 - Day 2
Console.WriteLine("Nhap hang ghe can kiem tra: ");
string seatClass = Console.ReadLine().ToLower()!;
switch (seatClass)
{
    case "standard":
        Console.WriteLine("Ghe ngoi thuong, khong co do uong");
        break;
    case "premium":
        Console.WriteLine("Ghe ngoi thoai mai, co do uong mien phi");
        break;
    case "vip":
        Console.WriteLine("Ghe ngoi hang sang, co do uong va bong ngo mien phi");
        break;
    default:
        Console.WriteLine("Khong phai hang ghe hop le");
        break;

}

// Bai tap 8 - Day 2
Console.WriteLine("Nhap vao so km khach da di: ");
float km = float.Parse(Console.ReadLine()!);
switch (km)
{
    case 1:
        Console.WriteLine("So tien phai tra la: 10000 VND");
        break;
    case > 1 and <= 5:
        Console.WriteLine("So tien phai tra la: " + (10000 + (km - 1) * 8000) + " VND");
        break;
    case > 5:
        Console.WriteLine("So tien phai tra la: " + (10000 + 4 * 8000 + (km - 5) * 6000) + " VND");
        break;
    default:
        Console.WriteLine("So km khong hop le");
        break;
}

// Bai tap 9 - Day 2
Console.WriteLine("Nhap vao chu cai tieng anh: ");
char letter = char.Parse(Console.ReadLine()!.ToLower());
switch (letter)
{
    case 'a' or 'e' or 'i' or 'o' or 'u':
        Console.WriteLine($"{letter} la nguyen am");
        break;
    case >= 'b' and <= 'z':
        Console.WriteLine($"{letter} la phu am");
        break;
    default:
        Console.WriteLine("Khong phai chu cai trong bang chu cai tieng anh");
        break;
}


// Bai tap 10 - Day 2
Console.WriteLine("Nhap vao loai ve may bay da chon: ");
string ticketType = Console.ReadLine().ToLower()!;
switch (ticketType)
{
    case "economy":
        Console.WriteLine("Ghe thuong");
        break;
    case "business":
        Console.WriteLine("Ghe rong");
        break;
    case "first class":
        Console.WriteLine("Ghe sang trong");
        break;
    default:
        Console.WriteLine("Khong phai loai ve hop le");
        break;
}
