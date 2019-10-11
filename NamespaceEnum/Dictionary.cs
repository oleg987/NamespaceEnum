using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEnum
{
    class Dictionary
    {
        public enum Genre
        {
            Комедия,
            Боевик,
            Исторический,
            Драма
        }

        public enum Seasons
        {
            Undefined,
            Winter,            
            Spring,
            Summer,
            Autumn
        }

        public enum Colours
        {
            Red = 0xFF0000,
            Green,
            Black,
        }
    }
}
