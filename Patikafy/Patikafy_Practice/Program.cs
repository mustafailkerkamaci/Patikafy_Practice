using Patikafy_Practice;



//Singer tipinde bir liste olusturuyorum ve bu listeye Singer class'inda tanimladigim ozellikleri kullanarak sarkicilarin bilgilerini ekleyecegim.
List<Singer> Singers = new List<Singer> 
{
       new Singer("Ajda Pekkan", "Pop", 1968, 20_000_000),
       new Singer("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10_000_000),
       new Singer("Funda Arar", "Pop", 1999, 3_000_000),
       new Singer("Sertab Erener", "Pop", 1994, 5_000_000),
       new Singer("Sıla", "Pop", 2009, 3_000_000),
       new Singer("Serdar Ortaç", "Pop", 1994, 10_000_000),
       new Singer("Tarkan", "Pop", 1992, 40_000_000),
       new Singer("Hande Yener", "Pop", 1999, 7_000_000),
       new Singer("Hadise", "Pop", 2005, 5_000_000),
       new Singer("Gülben Ergen", "Pop / Türk Halk Müziği", 1997,10_000_000),
       new Singer("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2_000_000)
};

// Odevde Istenilen Sorgular...

//Oncelikle Tum Sarkicilarimi Goremek Istiyorum.
Console.WriteLine("-----Tum Sarkicilar-----\n" );
foreach (var singer in Singers)
{
    Console.WriteLine($"Sarkici: {singer.Name}, Muzik Turu: {singer.MusicGenre}, Cikis Yili: {singer.ReleaseYear}, Album Satisi: {singer.FormattedAlbumeSale()}\n"); // albumsatis verileri icin formattedAlbumeSale() metodunu kullaniyorum. Bu metot, album satisi degerini bize yaklasik ... milyon seklinde verecek.
}
//Adi 'S' ile Baslayan Sarkicilar
Console.WriteLine("----- Adi 'S' Ile Baslayan Sarkicilar-----\n");
var sIleBaslayan = Singers
    .Where(s => s.Name.StartsWith('S'));

foreach (var singer in sIleBaslayan)
{
    Console.WriteLine(singer.Name);
}

//Albüm satışları 10 milyon'un üzerinde olan şarkıcılar

Console.WriteLine("----- Album Satislari 10 Milyonun Uzerinde Olan Sarkicilar-----\n");

var ablumSatis10m = Singers
    .Where(s => s.AlbumSale > 10_000_000);
foreach (var singer in ablumSatis10m)
{
    Console.WriteLine($"Sarkici: {singer.Name}, Album Satisi: {singer.FormattedAlbumeSale()}");
}

//2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

Console.WriteLine("----- 2000 Yili Oncesi Cikis Yapmis ve Pop Muzik Yapan Sarkicilar-----\n");

var popMuzik2000Oncesi = Singers
    .Where(s => s.ReleaseYear < 2000 && s.MusicGenre.Contains("Pop"));
var popMuzik2000OncesiGruplu = popMuzik2000Oncesi
    .GroupBy(s => s.ReleaseYear)
    .OrderBy(g => g.Key);
foreach (var group in popMuzik2000OncesiGruplu)
{
    Console.WriteLine($"Cikis Yili: {group.Key}");
    foreach (var singer in group.OrderBy(s => s.Name))
    {
        Console.WriteLine($"Sarkici: {singer.Name}");
    }
}

// En cok album satan sarkici

Console.WriteLine("----- En Cok Album Satan Sarkici-----\n");

var enCokAlbumSatan = Singers
    .OrderByDescending(s => s.AlbumSale)
    .First();

if (enCokAlbumSatan != null)
{
    Console.WriteLine($"En cok album satan sarkici: {enCokAlbumSatan.Name}, Album Satisi: {enCokAlbumSatan.FormattedAlbumeSale()}");
}


//En yeni ve en eski cikis yapan sanatcilar
Console.WriteLine("----- En Yeni ve En Eski Cikis Yapan Sanatcilar-----\n");
var enYeniSarkici = Singers
    .OrderByDescending(s => s.ReleaseYear)
    .FirstOrDefault();
var enEskiSarkici = Singers
    .OrderBy(s => s.ReleaseYear)
    .FirstOrDefault();
if (enYeniSarkici != null && enEskiSarkici != null)
{
    Console.WriteLine($"En yeni çıkış yapan şarkıcı --> {enYeniSarkici.Name} (Çıkış Yılı: {enYeniSarkici.ReleaseYear})");
    Console.WriteLine($"En eski çıkış yapan şarkıcı --> {enEskiSarkici.Name} (Çıkış Yılı: {enEskiSarkici.ReleaseYear})");
}





