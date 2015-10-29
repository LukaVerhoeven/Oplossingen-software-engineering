using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

       
        buttonmodel _model;
        
        List<Teerlingcontroller> teerlingen = new List<Teerlingcontroller>();
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
              {
            
            int aantalTeerlingen = 5;
            scorebordController scorecontroller = new scorebordController(teerlingen);
            ScoreBord scorebordview = scorecontroller.getView();
            Controls.Add(scorecontroller.getView());
            scorebordview.Location = new Point(0, 0);

            buttoncontroller buttoncontroler = new buttoncontroller(teerlingen, scorecontroller);
            UserControl1 buttonlocatie = buttoncontroler.getView();
            Controls.Add(buttoncontroler.getView());
            buttonlocatie.Location = new Point(0, 220);

            


            //maak instanties van de teerlingen aan voeg deze toe aan view
            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
           
                Teerlingcontroller nieuweTeerling = new Teerlingcontroller();
                teerlingen.Add(nieuweTeerling);
                //_model.Teerlingen.Add(nieuweTeerling);
                //_model.addTeerling(nieuweTeerling);

            }
   



            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {

                Teerlingcontroller huidigeTeerling = teerlingen[teerlingNummer];
                TeerlingView huidigeTeelingview = huidigeTeerling.getView();

                int xpos = huidigeTeelingview.Width * teerlingNummer;
                huidigeTeelingview.Location = new Point(xpos,80);

                Controls.Add(huidigeTeerling.getView());            


            }

         

            //_model.Aantal_teerlingen = aantalTeerlingen;

            //maakTeerlingen(aantalTeerlingen);

            //Teerlingcontroller nieuweTeerling = new Teerlingcontroller();

            //Controls.Add(nieuweTeerling.getView());

        }

        

        //private void maakTeerlingen(int aantal)
        //{

        //    for (int i = 0; i < aantal; i++)
        //    {
        //        Teerlingcontroller teerling = new Teerlingcontroller();
        //        _model.addTeerling(teerling);
        //    }
           
        //}
        

 

   
    }
}
