using RacingGame.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        Cars[] car = new Cars[4]; // cars array
        Punter[] myPunter = new Punter[3]; //  Punters array

        //stores the winner
        private string Winner;
        public Form1()
        {
            InitializeComponent();
            LoadCars();  // load cars method
            LoadPunters();// loadpunter method
            LoadMoney(); // load money method
            lblWinner.Hide();
            btnback.Hide();
        }
        public void LoadCars()
        {
            car[0] = new Cars { Length = 0, myPB = pictureBox1, Name = "Audi" }; 
            car[1] = new Cars { Length = 0, myPB = pictureBox2, Name = "Mustang" };
            car[2] = new Cars { Length = 0, myPB = pictureBox3, Name = "Dodge" };
            car[3] = new Cars { Length = 0, myPB = pictureBox4, Name = "Porche" };
        }
        public void LoadPunters() // loads the punters by the factory while factory gets the data from individual class
        {
            for (int i = 0; i < 3; i++)
            {
                
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblWinner;
            }
        }

        private void lblWinner_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtFera.Visible = true;
            txtLambo.Visible = true;
            txtTes.Visible = true;

            StartRace();
        }
        private void FindWinner(string CarWinner)  // find winner
        {

            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Car == CarWinner)
                {
                    myPunter[i].Money += myPunter[i].Bet;
                    myPunter[i].LabelWinner.Text += CarWinner + " and " + myPunter[i].PunterName + " Has Won ... Congratulations!";

                }

                else
                {
                    myPunter[i].Money -= myPunter[i].Bet;
                    myPunter[i].LabelWinner.Text += "" + myPunter[i].PunterName + " Has Lost better luck next time.";
                }
                myPunter[i].Bet = 0; // resets the punters bet so that it doesnt repeat when they are out of money
            }
            LoadMoney();

            if (myPunter[0].Money == 0) // disables the radiobutton when the punter runs out of money
            {
                rbPrabh.Enabled = false;
                txtFera.Text = " Prabh is out of Money";
            }
            if (myPunter[1].Money == 0)
            {
                rbRahul.Enabled = false;
                txtLambo.Text = "Rahul is out of Money";
            }
            if (myPunter[2].Money == 0)
            {
                rbAkash.Enabled = false;
                txtTes.Text = " Akash is out of Money";
            }

            // sees if all the requirements gameover requirements are met
            if (myPunter[0].Money == 0 && myPunter[1].Money == 0 || myPunter[0].Money == 0 && myPunter[2].Money == 0 || myPunter[1].Money == 0 && myPunter[2].Money == 0)
            {
                rbPrabh.Enabled = false;
                rbRahul.Enabled = false;
                rbAkash.Enabled = false;
                pnlGameOver.Visible = true;
              
            }
           
        }
        private void LoadMoney() // i did it like this even though i could put it in the findwinner method because i wanted it to show in the textbox straight away right when the game is started 
        {   // shows the amount of money the punter has in the textbox
            txtFera.Text = myPunter[0].PunterName + " Has $" + myPunter[0].Money;
            txtLambo.Text = myPunter[1].PunterName + " Has $" + myPunter[1].Money;
            txtTes.Text = myPunter[2].PunterName + " Has $" + myPunter[2].Money;
        }
        public void StartRace()
        {
            var myRandom = new Random();

            bool end = false;

            while (end != true)
            {
                int distance = Form1.ActiveForm.Width - pictureBox1.Width - 30;

                for (int i = 0; i < car.Length; i++)
                {
                    Thread.Sleep(2);
                    car[i].myPB.Left += myRandom.Next(1, 7); //  car move (random distance)



                    if (car[i].myPB.Left > distance)
                    {
                        end = true;
                        Winner = car[i].Name;
                        this.Text = Winner;

                        //find the winner 
                        FindWinner(Winner);
                        lblWinner.Show();
                        btnback.Show();
                        btnStart.Enabled = false;
                        btnBet.Enabled = false;
                    }
                    
                }
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
           

            if (rbPrabh.Checked == true)
            {
                myPunter[0].Bet = (float)numUDbet.Value;

                if (numUDCarNumber.Value == 1) // if a number is picked it returns a car to the punter
                {
                    myPunter[0].Car = car[0].Name;
                }
                if (numUDCarNumber.Value == 2)
                {
                    myPunter[0].Car = car[1].Name;
                }
                if (numUDCarNumber.Value == 3)
                {
                    myPunter[0].Car = car[2].Name;
                }
                if (numUDCarNumber.Value == 4)
                {
                    myPunter[0].Car = car[3].Name;
                }
            }


            if (rbRahul.Checked == true)
            {
                myPunter[1].Bet = (float)numUDbet.Value;

                if (numUDCarNumber.Value == 1)
                {
                    myPunter[1].Car = car[0].Name;
                }
                if (numUDCarNumber.Value == 2)
                {
                    myPunter[1].Car = car[1].Name;
                }
                if (numUDCarNumber.Value == 3)
                {
                    myPunter[1].Car = car[2].Name;
                }
                if (numUDCarNumber.Value == 4)
                {
                    myPunter[1].Car = car[3].Name;
                }
            }


            if (rbAkash.Checked == true)
            {
                myPunter[2].Bet = (float)numUDbet.Value;

                if (numUDCarNumber.Value == 1)
                {
                    myPunter[2].Car = car[0].Name;
                }
                if (numUDCarNumber.Value == 2)
                {
                    myPunter[2].Car = car[1].Name;
                }
                if (numUDCarNumber.Value == 3)
                {
                    myPunter[2].Car = car[2].Name;
                }
                if (numUDCarNumber.Value == 4)
                {
                    myPunter[2].Car = car[3].Name;
                }

            }

            UpdateDetails();
        }
        private void UpdateDetails()
        {

            txtFera.Text = myPunter[0].PunterName + " has betted $" + myPunter[0].Bet + " on " + myPunter[0].Car; // shows how much the punter has bet on the text box and which car he chose
            txtLambo.Text = myPunter[1].PunterName + " has betted $" + myPunter[1].Bet + " on " + myPunter[1].Car;
            txtTes.Text = myPunter[2].PunterName + " has betted $" + myPunter[2].Bet + " on " + myPunter[2].Car;

        }

        private void rbPrabh_CheckedChanged(object sender, EventArgs e)
        {
           
            lblWinner.Hide();
            RadioButton rbF = (RadioButton)sender;

            if (rbF.Checked == true) //if the radiobutton is checked then it gets a punter through the factory to return data
            {
                Factory.GetAPunter(0);
                txtFera.Visible = true;
                txtFera.Text = myPunter[0].PunterName + " Has $" + myPunter[0].Money;
                txtLambo.Visible = false;
                txtTes.Visible = false;
            }
            numUDbet.Maximum = (decimal)myPunter[0].Money;//sets maximum equal to the punters money 
            myPunter[0].Bet = (float)numUDbet.Value;

        }

        private void rbRahul_CheckedChanged(object sender, EventArgs e)
        {
            lblWinner.Hide();
            RadioButton rbL = (RadioButton)sender;

            if (rbL.Checked == true) //if the radiobutton is checked then it gets a punter through the factory to return data
            {
                Factory.GetAPunter(1);
                txtFera.Visible = false;
                txtLambo.Visible = true;
                txtLambo.Text = myPunter[1].PunterName + " Has $" + myPunter[1].Money;
                txtTes.Visible = false;
            }
            numUDbet.Maximum = (decimal)myPunter[1].Money;
            myPunter[1].Bet = (float)numUDbet.Value;

        }

        private void rbAkash_CheckedChanged(object sender, EventArgs e)
        {
            lblWinner.Hide();
            RadioButton rbT = (RadioButton)sender;

            if (rbT.Checked == true)//if the radiobutton is checked then it gets a punter through the factory to return data
            {
                Factory.GetAPunter(2);
                txtFera.Visible = false;
                txtLambo.Visible = false;
                txtTes.Visible = true;
                txtTes.Text = myPunter[2].PunterName + " Has $" + myPunter[2].Money;
            }
            numUDbet.Maximum = (decimal)myPunter[2].Money;//sets maximum equal to the punters money 
            myPunter[2].Bet = (float)numUDbet.Value;

        }

        private void numUDCarNumber_ValueChanged(object sender, EventArgs e)
        {
            numUDCarNumber.Maximum = 4;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtLambo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 4; i++)
            {
                car[i].myPB.Left = 5;
              
            }
            lblWinner.Hide();
            btnback.Hide();
            btnStart.Enabled = true;
            btnBet.Enabled = true;
        }
    }
}
