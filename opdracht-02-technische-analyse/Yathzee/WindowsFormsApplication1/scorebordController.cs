using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class scorebordController
    {
        List<Teerlingcontroller> teerlingen;        
        scorebordModel _model;
        ScoreBord _view;

        public scorebordController(List<Teerlingcontroller> Teerlingen)
        {
            _model = new scorebordModel();
            _view = new ScoreBord(this, _model);            
            teerlingen = Teerlingen;
           
        }


        public void TelTeerlingOp()
        {
            _model.Huidigeworp = 0;
            foreach (Teerlingcontroller teerling in teerlingen)
            {
                _model.Huidigeworp += teerling._model.aantalOgen;


            }
            if (_model.Huidigeworp != null && _model.Huidigeworp > _model.hoogsteScore)
            {
                _model.hoogsteScore = _model.Huidigeworp;
            }
            if (_model.Huidigeworp == 0)
            {
                _model.hoogsteScore = _model.Huidigeworp;
            }
            _view.updateHuidigeScore();

        }
   

        public ScoreBord getView()
        {
            return _view;
        }

    }

}
