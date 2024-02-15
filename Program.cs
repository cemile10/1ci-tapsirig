//ilk tapsiriq 
Console.WriteLine("ilk ucreqemli ededi daxil edin");
int ilk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci eded");
int ikinci = Convert.ToInt32(Console.ReadLine());
int ilk1 = ilk / 100;
int ilk2 = (ilk - (ilk1 * 100)) / 10;
int ilk3 = (ilk - ((ilk1*100)+(ilk2 * 10)));

int ikinci1 = ikinci / 100;
int ikinci2 = (ikinci - (ikinci1 * 100)) / 10;
int ikinci3 = (ikinci - ((ikinci1 * 100)+ (ikinci2 * 10)));

int yeni_ilk = ilk1 * 100 + ikinci2 * 10 + ilk3;
int yeni_ikinci = ikinci1 * 100 + ilk2 * 10 + ikinci3;
Console.WriteLine("ilk ededin deyisilmis formasi - " + yeni_ilk);
Console.WriteLine("ikinci ededin deyisilmis formasi - " + yeni_ikinci);