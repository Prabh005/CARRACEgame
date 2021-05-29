using RacingGame.AllClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    class PlayGame
    {
        Cars[] car = new Cars[4]; // cars array
        Punter[] myPunter = new Punter[3]; // punter array


        // method to load the cars into the picture box
        public Cars[] LoadCars(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4)
        {
            UDPunter1Value1();
            car[0] = new Cars { Length = 0, myPB = pictureBox1, Name = "Audi" }; // identifies which array/picture box to put the car image into
            car[1] = new Cars { Length = 0, myPB = pictureBox2, Name = "Mustang" };
            car[2] = new Cars { Length = 0, myPB = pictureBox3, Name = "Dodge" };
            car[3] = new Cars { Length = 0, myPB = pictureBox4, Name = "Porche" };

            return car;
            
        }
        public Punter[] LoadPunters(Label lblWinner)
        {
            for (int i = 0; i < 3; i++)
            {
                //static dont need to instantiate
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblWinner;
            }

            return myPunter;
        }


        public void UDPunter1Value1()
        {
            myPunter[0].Car = car[0].Name;
        }

        public void UDPunter1Value2()
        {
            myPunter[0].Car = car[1].Name;
        }
        public void UDPunter1Value3()
        {
            myPunter[0].Car = car[2].Name;
        }
        public void UDPunter1Value4()
        {
            myPunter[0].Car = car[3].Name;
        }


    }
}
