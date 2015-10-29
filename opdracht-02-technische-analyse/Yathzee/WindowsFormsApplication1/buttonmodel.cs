using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class buttonmodel
    {

        List<Teerlingcontroller> teerlingen = new List<Teerlingcontroller>();


        public List<Teerlingcontroller> Teerlingen
        {
            set
            {
                teerlingen = value;
            }
            get
            {
                return teerlingen;
            }
        }
        public void addTeerling(Teerlingcontroller teerling)
        {
            teerlingen.Add(teerling);
        }

    }
}
