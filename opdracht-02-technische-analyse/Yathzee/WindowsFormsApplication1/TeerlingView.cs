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
    public partial class TeerlingView : UserControl
    {
        Teerlingcontroller _controller;

        bool ShowWerpButton = false;

        public TeerlingView(Teerlingcontroller controller , bool showwerpButton)
        {
            ShowWerpButton = showwerpButton;
            _controller = controller;
            InitializeComponent();
        }

        private void Werpbutton_Click(object sender, EventArgs e)
        {

            _controller.werpTeerling();           

            TeerlingLabel.Text = _controller._model.aantalOgen.ToString();


        }

        public void Teelingen_aanpassen()
        {
            TeerlingLabel.Text = _controller._model.aantalOgen.ToString();
        }


        private void TeerlingView_Load(object sender, EventArgs e)
        {
            if (ShowWerpButton)
            {
                Werpbutton.Visible = true;
            }
            else
            {
                Werpbutton.Visible = false;
            }

        }


        private void TeerlingLabel_Click(object sender, EventArgs e)
        {




            _controller.toggleTerlingclick();



        }
        public void teerlingclick()
        {

            if (_controller._model.istVast == false)
            {
                TeerlingLabel.BackColor = Color.Red;
                _controller._model.istVast = true;
            }
            else
            {
                TeerlingLabel.BackColor = Color.WhiteSmoke;
                _controller._model.istVast = false;
            }
        }
    }
}
