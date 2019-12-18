using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Chanson
    {
        string _titreChanson;

        public Chanson ( string t )
        {
            _titreChanson = t;
        }

        public string TitreChanson
        {
            get { return _titreChanson;  }
            set { _titreChanson = value;  }
        }
    }
}
