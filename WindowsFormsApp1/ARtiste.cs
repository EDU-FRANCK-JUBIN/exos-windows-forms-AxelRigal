using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Artiste
    {

        string _nomArtiste { get; set; }
        private List<Chanson> _listChanson { get; set; }

        public Artiste(string a, List<Chanson> l)
        {
            _nomArtiste = a;
            _listChanson = l;
        }

        public string NomArtiste
        {
            get{ return _nomArtiste; }
            set{ _nomArtiste = value; }
        }

        public List<Chanson> ListChanson
        {
            get { return _listChanson; }
            set { _listChanson = value;  }
        }
    }
}