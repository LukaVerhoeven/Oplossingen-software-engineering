using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Teerlingcontroller
    {
        TeerlingView _view;
        public TeerlingModel _model;
        public bool showWerpbutton = false;
        static int timer = 0;
        Random random = new Random(timer++);

        public Teerlingcontroller()
        {
            _view = new TeerlingView(this, showWerpbutton);
            _model = new TeerlingModel();
        }


        public TeerlingView getView()
        {
            return _view;
        }

        public void werp()
        {
            if (_model.istVast == false)
            {
                werpTeerling();
                Teerling_veranderen();

            }

         }

        public void werpTeerling()
        {
            

                
                int teerlingGetal = random.Next(1, 7);
                _model.aantalOgen = teerlingGetal;     


        }

        public void toggleTerlingclick()
        {
            _view.teerlingclick();

        }
        public void Teerling_veranderen()
        {
            _view.Teelingen_aanpassen();
        }



    }
}
