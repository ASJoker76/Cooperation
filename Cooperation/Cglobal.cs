using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cooperation
{
    class Cglobal
    {
        static string _username;
        public static string username
        {
            get { return _username; }
            set { _username = value; }
        }
    }
}
