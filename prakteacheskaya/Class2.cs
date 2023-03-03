using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakteacheskaya
{
    class Man
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Man(string name)
        {
            _name = name;
        }
    }
}
