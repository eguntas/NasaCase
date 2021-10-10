using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Düzlem boyutları okunuyor.
                var duzlemKordinat = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                //Gezici koordinatları okunuyor.
                var geziciLocation = Console.ReadLine().Trim().Split(' ');
                //Gezici hareket komutları okunuyor.
                var hareketCommand = Console.ReadLine().ToUpper();
                //Posision nesnesi yaratılıyor.
                Position position = new Position();
                
                //Gezici koordinatları position nesnesine atanıyor.
                if (geziciLocation.Count() == 3)
                {
                    position.X = Convert.ToInt32(geziciLocation[0]);
                    position.Y = Convert.ToInt32(geziciLocation[1]);
                    position.Yon = (Yons)Enum.Parse(typeof(Yons), geziciLocation[2]);
                    position.StartMove(duzlemKordinat, hareketCommand);
                    Console.WriteLine(position.X+" "+position.Y+" "+position.Yon);
                }
                else
                {
                    Console.WriteLine("Gezici kordinatları yanlış girildi.");
                }                
            }catch(Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
        }
    }
}
