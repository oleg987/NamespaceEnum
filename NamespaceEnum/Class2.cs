using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class Account
    {
        string name;
        string type;

        public Account()
        {
            name = "John Doe";
            type = "Finance info";
        }

        public override string ToString()
        {
            return $"{name} {type}";
        }
    }
    }
