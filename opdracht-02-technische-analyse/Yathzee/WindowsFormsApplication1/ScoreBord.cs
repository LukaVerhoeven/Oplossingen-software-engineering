using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ScoreBord : UserControl
    {

        scorebordController _controller;
        scorebordModel _model;
        public ScoreBord(scorebordController controller, scorebordModel model)
        {
            _controller = controller;
            _model = model;
            InitializeComponent();
        }

        public void updateHuidigeScore()
        {

            label2.Text = _model.Huidigeworp.ToString();
            label4.Text = _model.hoogsteScore.ToString();
        }

        private void ScoreBord_Load(object sender, EventArgs e)
        {


           // label2.Text = _controller.score.ToString();
            //TeerlingLabel.Text = _controller._model.aantalOgen.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
