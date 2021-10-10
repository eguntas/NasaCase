using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaCase
{
    public interface IPosition
    {
        void StartMove(List<int> duzlemkordinat , string hareketler);
    }
}
