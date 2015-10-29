using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TeerlingModel
    {
        int _aantalOgen;
        bool _isVast = false;

       


        public int aantalOgen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }
        public bool istVast
        {
            get
            {
                return _isVast;
            }
            set
            {
                _isVast = value;
            }
        }

        //bool isvast togle isvast --> clickevent op label ++ 1 buton voor 6 dobbelstenen

    }
}
