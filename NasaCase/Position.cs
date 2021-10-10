using NasaCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACase
{

    public enum Yons
    {
        N = 1, //NORTH
        E = 2, //EAST
        S = 3, //SOUTH
        W = 4  //WEST
    }
    public class Position : IPosition
        {
        public int X { get; set; }
        public int Y { get; set; }
        public Yons Yon { get; set; }

            public Position()
            {
                //Gezicinin varsayılan kordinatları
                X = Y = 0;
                Yon = Yons.N;
            }
            public void StartMove(List<int> int_list, string hareketler)
            {
            //Kullanıcıdan alınan hareket komutlarına göre fonksiyonlar çağırılır.
                foreach (var hareket in hareketler)
                {
                    switch (hareket)
                    {
                        case 'M':
                            Move();
                            break;
                        case 'R':
                            RotateRight();
                            break;
                        case 'L':
                            RotateLeft();
                            break;
                        default:
                            Console.WriteLine("Bilinmeyen karakter:" + hareket);
                            break;
                    }
                }
            }
            private void RotateRight()
            {
            //Gezicinin sağa hareketinde yeni yönü belirlenir.
                switch (Yon)
                {
                    case Yons.N:
                        Yon = Yons.E;
                        break;
                    case Yons.E:
                        Yon = Yons.S;
                        break;
                    case Yons.S:
                        Yon = Yons.W;
                        break;
                    case Yons.W:
                        Yon = Yons.N;
                        break;
                }
            }
            private void RotateLeft()
            {
            //Gezicinin sola hareketinde yeni yönü belirlenir.
            switch (Yon)
                {
                    case Yons.N:
                        Yon = Yons.W;
                        break;
                    case Yons.E:
                        Yon = Yons.N;
                        break;
                    case Yons.S:
                        Yon = Yons.E;
                        break;
                    case Yons.W:
                        Yon = Yons.S;
                        break;
                }
            }
            private void Move()
            {
            //Gezicinin ileri hareketinde kordinatındaki değişiklik belirlenir.
            switch (Yon)
                {
                    case Yons.N:
                        Y += 1;
                        break;
                    case Yons.S:
                        Y -= 1;
                        break;
                    case Yons.E:
                        X += 1;
                        break;
                    case Yons.W:
                        X -= 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    

