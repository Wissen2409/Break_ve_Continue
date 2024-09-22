
// Break ve Contiune, bir döngü içerisinde kullanılan yapılardır.

// Break : Belirli bir şart sağlandığında, döngüden çıkmak için kullanılır
// Continue : Belirli bir şart sağlandığında, döngünün başa dönmesini sağlar.

// Örnek : 1den 100'a kadar olan bir döngüde, 3 sayısına bölünen bir sayı olduğunda uygulama kapansın!!

/*for(int i = 1; i < 100;i++)
{
    Console.WriteLine(i);
    if(i%3==0){
        Console.WriteLine("{0} sayısı 3 sayısına direk bölündü",i);
        break;
        // break ifadesi, çalıştırıldığında, eğer bir döngü var ise, bu döngüden çıkılır.

    }

}
*/

/*for(int i = 0; i < 10;i++){

    for(int j = 0;j<i;j++){

        Console.Write("*");
        if(j==5){
            break;
        }

    }
    Console.WriteLine("-");
}
*/


// Break çalıştığında, kendisini kapsayan döngüden çıkar. İç içe döngü varsa, break sadece kendini kapsayan döngüden çıkacaktır.


// Continue : 
/*
for(int i =0;i<100;i++){

    if(i==10)
    {
        continue;

        // Continue ifadesi, çalıştığı zaman, döngü continue ifadesini gördüğü anda, alt satırları çalıştırmaya devam etmez, direk i'nin değerini bir artırır, 
        //sonrasında dönmeye devam eder.
    }
    Console.WriteLine(i);

    // bir örnek 
    // yukarı-aşağı oyununu, break kullanarak tekrar yazınız!!
}*/

Random rnd = new Random();
int random =rnd.Next(1,100);
bool kazanarakBitti = false;
for(int i = 0; i < 10;i++)
{

    Console.WriteLine("Bir sayı giriniz");
    int tahmin = int.Parse(Console.ReadLine());
    if(tahmin<random){
        Console.WriteLine("Yukarı");
    }
    else if(tahmin>random){
        Console.WriteLine("Aşağı");
    }
    else if(tahmin==random){
        kazanarakBitti=true;
        break;
    }


}
if(kazanarakBitti){
    Console.WriteLine("Tebrikler Kazandınız");
}
else{
    Console.WriteLine("Kaybettiniz");
}




