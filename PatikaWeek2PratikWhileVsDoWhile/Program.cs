// Burada while döngüsü ile kuruyorum.

int sayac = 1;
int limit;

Console.WriteLine("Lütfen bir limit yazınız.");
limit = Convert.ToInt32(Console.ReadLine());

while(sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    sayac++;
}

// Burada do-while döngüsü kullanıyorum.

int sayac2 = 1;
int limit2;

Console.WriteLine("Lütfen bir limit giriniz.");
limit2 = Convert.ToInt32(Console.ReadLine());

do
{ 
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
}while (sayac2 <= limit2);

// Örnek inputlardan -5'i girdiğimde while döngüsü direk programı sonlandırırken, do-while döngüsü bir kere gösterdikten sonra sonlandırıyor.
// Bu da do-while döngüsünde girilen koşul döngüye girildikten sonra kontrol edildiği için oluyor.