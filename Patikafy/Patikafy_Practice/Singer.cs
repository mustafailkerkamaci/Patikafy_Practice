using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy_Practice
{
    public class Singer // sarkicilarin eklenecegi liste icin singer adinda yeni bir class olusturuyorum buraya singerin almasi gereken ozellikleri eklyecegim.
    {
        public string Name { get; set; }
        public string MusicGenre { get; set; }
        public int ReleaseYear { get; set; }
        public long AlbumSale { get; set; }

        //singer sinifinin constructor'ini olusturuyorum. Singer sinifindan bir nesne olusturuldugunda bu constructor calisacak ve parametre olarak verilen degerleri alacak.

        public Singer(string name, string musicGenre, int releaseYear, long albumSale)
        {
            Name = name;
            MusicGenre = musicGenre;
            ReleaseYear = releaseYear;
            AlbumSale = albumSale;

        }

        public string FormattedAlbumeSale() // album satici degerini bize verdigimiz degere gore yaklasik ... milyon seklinde verecek olan metot string donmesinin sebebi listede verdigimiz degeri bize yaklasik ... milyon seklinde donecek olmasi. Geminiden yardim aldim.
        {
            if (AlbumSale >= 1_000_000 && AlbumSale % 1_000_000 == 0)
            {
                return $"Yaklaşık {AlbumSale / 1_000_000} milyon";
            }
            else // Eğer yukarıdaki if koşulu sağlanmazsa, bu blok çalışır ve bir değer döndürür.
            {
                return AlbumSale.ToString(" ");
            }

        }


    }
}
