using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEnum
{
    class Account
    {
        string name;
        string type;

        public Account()
        {
            name = "John Doe";
            type = "User info";
        }

        public override string ToString()
        {
            return $"{name} {type}";
        }
    }
}
