using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class buttoncontroller
    {

        UserControl1 _view;
        buttonmodel _buttonmodel;
        List<Teerlingcontroller> teerlingen;
        int counter = 0;
        TeerlingModel _model;
        scorebordController _score;



        public buttoncontroller(List<Teerlingcontroller> Teerlingen, scorebordController score)
        {
            teerlingen = Teerlingen;
            _score = score;
            _view = new UserControl1(this, _score);
            _buttonmodel = new buttonmodel();
           
        }

        public void alleTeerlingenWerpen()
        {
            counter++;
            if (counter <= 3)
            {
                foreach (Teerlingcontroller teerling in teerlingen)
                {
                    teerling.werp();
                }
            }
            else
            {
                return;
            }

     
        }

        public void reset()
        {
            foreach (Teerlingcontroller teerling in teerlingen  )
            {
                
                if (teerling._model.istVast = true)
                {
                    teerling.toggleTerlingclick();
                }
                teerling._model.aantalOgen = 0;
                teerling.Teerling_veranderen();
                

            }

            _score.TelTeerlingOp();



            counter = 0;
        }

        public UserControl1 getView()
        {
            return _view;
        }

    }
}
