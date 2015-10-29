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
    public partial class UserControl1 : UserControl
    {



        buttoncontroller  _controller;
        scorebordController _score;


        public UserControl1(buttoncontroller controllers, scorebordController score)
        {
            _controller = controllers;
            _score = score;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _controller.alleTeerlingenWerpen();
          _score.TelTeerlingOp();


        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.reset();

        }
    }
}
