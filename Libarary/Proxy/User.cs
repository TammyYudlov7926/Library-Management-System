



























































using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Proxy
{
    internal class User
    {
        public string Name { get; }
        public bool HasPermission { get; }

        public User(string name, bool hasPermission)
        {
            Name = name;
            HasPermission = hasPermission;
        }
    }
}






