using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCreation001 {
    public partial class Form1 : Form {
        private static List<Color> wireColor = new List<Color> {
            Color.Red,
            Color.Black,
            Color.Blue,
            Color.White,
            Color.Yellow
        };

        private static List<Button> buttonList = new List<Button> { };

        private static Random random = new Random();                       // Instantiate a random number generator

        int redWires = 0;
        bool lastWireWhite = false;
        int blueWires = 0;
        int lastBlueWireIndex = 0;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            Button[] formButtons = {btnWire001,
                                    btnWire002,
                                    btnWire003,
                                    btnWire004,
                                    btnWire005 };

            buttonList.AddRange(formButtons);
        }

        private void timer1_Tick(object sender, EventArgs e) {

            if (this.progressBar001.Value < 100)
            {
                this.progressBar001.Increment(1);
            }
            else
            {
                StartResetGame("StopGame");
//                this.btnStartReset.Enabled = true;
            }
        }

        private void btnStartReset_MouseEnter(object sender, EventArgs e) {

            btnStartReset.BackColor = Color.LightGray;
        }

        private void btnStartReset_Click(object sender, EventArgs e) {

            if (btnStartReset.Text.Equals("Start Game"))
            {
                StartResetGame("StartGame");
                //btnStartReset.Text = "Reset Game";
                //btnStartReset.Enabled = false;
                //changeWireState("enable");

                //SetWireColors();
                //GetBombProperties();

                //timer1.Start();
            }
            else
            {
                StartResetGame("ResetGame");
                //btnStartReset.Text = "Start Game";
                //progressBar001.Value = 0;
                //changeWireState("disable");

                //timer1.Stop();
            }
        }

        private void StartResetGame (string stateRequest) {

            switch (stateRequest)
            {
                case "StartGame":
                    btnStartReset.Text = "Reset Game";
                    btnStartReset.Enabled = false;
                    changeWireState("enable");

                    SetWireColors();
                    GetBombProperties();

                    timer1.Start();

                    break;
                case "StopGame":
                    this.btnStartReset.Enabled = true;
                    changeWireState("disable");

                    timer1.Stop();

                    break;
                case "ResetGame":
                    btnStartReset.Text = "Start Game";
                    this.btnStartReset.Enabled = true;
                    progressBar001.Value = 0;
                    changeWireState("disable");
                    ResetWireColors();
                    
                    timer1.Stop();

                    break;
                default:
                    break;
            }
        }

        private void GetBombProperties() {

            redWires = CountRedWires();
            lastWireWhite = LastWireWhite();
            blueWires = CountBlueWires();
        }

        private void btnWire_Click(object sender, EventArgs e) {

            Button pressedButton = (Button)sender;

            bool winOrLoose = BombLogic(pressedButton);

            if (winOrLoose)
            {
                Console.WriteLine(pressedButton.Name);
                listBStatus.Items.Add("You Win");                
            }
            else
            {
                Console.WriteLine(pressedButton.Name);
                listBStatus.Items.Add("You Loose");
            }

            StartResetGame("StopGame");
        }

        private bool BombLogic(Button buttonClicked) {

            bool returnValue = false;

            if ((redWires == 0) && 
                (buttonClicked.Equals(buttonList[1])))
            {
                returnValue = true;
            }
            else if (
                    redWires > 0 && 
                    lastWireWhite &&
                    buttonClicked.Equals(buttonList[4])
                )
            {
                returnValue = true;
            }
            else if (
                    redWires > 0 &&
                    !lastWireWhite && 
                    blueWires > 1 && 
                    buttonClicked.Equals(buttonList[lastBlueWireIndex])
                )
            {
                returnValue = true;
            }
            else if (
                    redWires > 0 &&
                    !lastWireWhite &&
                    blueWires <= 1 &&
                    buttonClicked.Equals(buttonList[4])
                )
            {
                returnValue = true;
            }            

            return returnValue;
        }

        private void changeWireState(String statusRequest) {

            switch (statusRequest)
            {
                case "enable":
                    btnWire001.Enabled = true;
                    btnWire002.Enabled = true;
                    btnWire003.Enabled = true;
                    btnWire004.Enabled = true;
                    btnWire005.Enabled = true;

                    break;
                case "disable":
                    btnWire001.Enabled = false;
                    btnWire002.Enabled = false;
                    btnWire003.Enabled = false;
                    btnWire004.Enabled = false;
                    btnWire005.Enabled = false;

                    break;
                default:
                    break;
            }
        }

        private int CountRedWires() {

            int returnValue = 0;

            for (int i = 0; i < 5; i++)
            {
                if (buttonList[i].BackColor == Color.Red)
                    returnValue++;
            }

            return returnValue;
        }

        private bool LastWireWhite() {

            bool returnValue = false;

            if (buttonList[4].BackColor == Color.White)
                returnValue = true;

            return returnValue;
        }

        private int CountBlueWires() {

            int returnValue = 0;

            for (int i = 0; i < 5; i++)
            {
                if (buttonList[i].BackColor == Color.Blue)
                {
                    returnValue++;
                    lastBlueWireIndex = i;
                }
            }

            return returnValue;
        }

        private void ResetWireColors() {

            for (int i = 0; i < 5; i++)
            {
                buttonList[i].BackColor = Color.LightGray;
            }
        }

        private void SetWireColors() {

            for (int i = 0; i < 5; i++)
            {
                buttonList[i].BackColor = wireColor[RandomNumber(0,5)];
            }
        }

        private static int RandomNumber(int min, int max) {
            return random.Next(min, max);
        }
    }
}
