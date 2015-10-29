using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class scorebordModel
    {
        int HuidigeWorp;
        int HoogsteScore;



        public int Huidigeworp
        {
            get
            {
                return HuidigeWorp;
            }
            set
            {
                HuidigeWorp = value;
            }
        }

        public int hoogsteScore
        {
            get
            {
                return HoogsteScore;
            }
            set
            {
                HoogsteScore = value;
            }
        }

    }
}
