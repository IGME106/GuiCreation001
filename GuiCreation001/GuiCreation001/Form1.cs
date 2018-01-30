using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 5 - UI Events
/// Class Description   : This is the Form1 class for Practice Exercise 5
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : January 30, 2018
/// Filename            : Form1.cs
/// </summary>

namespace GuiCreation001 {
    public partial class Form1 : Form {
        /// <summary>
        /// Define list of colors to be used for dynamic wire allocation
        /// </summary>
        private static List<Color> wireColor = new List<Color> {
            Color.Red,
            Color.Black,
            Color.Blue,
            Color.White,
            Color.Yellow
        };

        private static List<Button> buttonList = new List<Button> { };      // List of button objects

        private static Random random = new Random();                        // Instantiate a random number generator

        /// <summary>
        /// The following variable values are calculated to assist in the
        ///     validation of the game rules.
        /// </summary>
        int redWires = 0;
        bool lastWireWhite = false;
        int blueWires = 0;
        int lastBlueWireIndex = 0;

        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Create an array of buttons (by name) to attach to the list
        /// </summary>
        /// <param name="sender">Object sending the event</param>
        /// <param name="e">Event details</param>
        private void Form1_Load(object sender, EventArgs e) {

            Button[] formButtons = {btnWire001,
                                    btnWire002,
                                    btnWire003,
                                    btnWire004,
                                    btnWire005 };

            buttonList.AddRange(formButtons);
        }

        /// <summary>
        /// Configure progress bar to run as countdown timer
        /// </summary>
        /// <param name="sender">Object sending the event</param>
        /// <param name="e">Event details</param>
        private void timer1_Tick(object sender, EventArgs e) {

            if (this.progressBar001.Value < 100)
            {
                this.progressBar001.Increment(1);                   // Increase progress bar by one every second
            }
            else
            {
                StartResetGame("StopGame");                         // Stop the game when time runs out
            }
        }
        /// <summary>
        /// Set the color of the button on "mouse-over (MouseEnter)" event
        /// </summary>
        /// <param name="sender">Object sending the event</param>
        /// <param name="e">Event details</param>
        private void btnStartReset_MouseEnter(object sender, EventArgs e) {

            btnStartReset.BackColor = Color.LightGray;
        }

        /// <summary>        
        /// Button click event indicating what game operation to do based on the 
        ///     text of the button.
        /// </summary>
        /// <param name="sender">Object sending the event</param>
        /// <param name="e">Event details</param>
        private void btnStartReset_Click(object sender, EventArgs e) {

            if (btnStartReset.Text.Equals("Start Game"))
            {
                StartResetGame("StartGame");
            }
            else
            {
                StartResetGame("ResetGame");
            }
        }

        /// <summary>
        /// Start or reset the game based on input
        /// </summary>
        /// <param name="stateRequest">Calling method specifies the required action to take</param>
        private void StartResetGame (string stateRequest) {

            // Performed the specified list of functions based on the parameter passed in
            //  from the calling method
            switch (stateRequest)
            {
                case "StartGame":
                    btnStartReset.Text = "Reset Game";
                    btnStartReset.Enabled = false;
                    changeWireState("enable");                      // Enable the wires

                    SetWireColors();                                // Generate and set random wire colors
                    GetBombProperties();                            // Get properties (wire colors) as applied

                    timer1.Start();                                 // Start the timer

                    break;
                case "StopGame":
                    this.btnStartReset.Enabled = true;
                    changeWireState("disable");                     // Disable the wires

                    timer1.Stop();                                  // Stop the timer

                    break;
                case "ResetGame":
                    btnStartReset.Text = "Start Game";
                    this.btnStartReset.Enabled = true;
                    progressBar001.Value = 0;                       // Reset the progress bar
                    changeWireState("disable");                     // Disable the wires
                    ResetWireColors();                              // Clear wire colors
                    listBStatus.Items.Clear();                      // Clear the contents of the status box

                    timer1.Stop();                                  // Stop the timer

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Extracts the associated properties from the bomb.
        /// </summary>
        private void GetBombProperties() {

            redWires = CountRedWires();
            lastWireWhite = LastWireWhite();
            blueWires = CountBlueWires();
        }

        /// <summary>
        /// Determine which wire (button) was clicked
        /// </summary>
        /// <param name="sender">Object sending the event</param>
        /// <param name="e">Event details</param>
        private void btnWire_Click(object sender, EventArgs e) {

            Button pressedButton = (Button)sender;

            bool winOrLoose = BombLogic(pressedButton);

            if (winOrLoose)                                         // If the game logic was successfully
            {                                                       //  followed, you win
                Console.WriteLine(pressedButton.Name);
                listBStatus.Items.Add("You Win");
            }
            else                                                    // alternatively you loose.
            {
                Console.WriteLine(pressedButton.Name);
                listBStatus.Items.Add("You Loose");
            }

            StartResetGame("StopGame");                             // Stop the game once a result is found
        }

        /// <summary>
        /// Logic for defusing the bomb as specified in the blueprint.
        /// </summary>
        /// <param name="buttonClicked">reference to Button object that was clicked</param>
        /// <returns>True or False.  True if you win the game, false if you loose.</returns>
        private bool BombLogic(Button buttonClicked) {

            bool returnValue = false;                               // Default returnValue is false

            if ((redWires == 0) &&      // If there are no red wires, cut the second wire
                (buttonClicked.Equals(buttonList[1])))
            {
                returnValue = true;
            }
            else if (                   // Otherwise, if the last wire is white, cut the last wire
                    redWires > 0 && 
                    lastWireWhite &&
                    buttonClicked.Equals(buttonList[4])
                )
            {
                returnValue = true;
            }
            else if (                   // Otherwise, if there is more than one blue wire, cut the last blue wire
                    redWires > 0 &&
                    !lastWireWhite && 
                    blueWires > 1 && 
                    buttonClicked.Equals(buttonList[lastBlueWireIndex])
                )
            {
                returnValue = true;
            }
            else if (                   // Otherwise, cut the last wire
                    redWires > 0 &&
                    !lastWireWhite &&
                    blueWires <= 1 &&
                    buttonClicked.Equals(buttonList[4])
                )
            {
                returnValue = true;
            }            

            return returnValue;         // Returns True or False based on logic outcome
        }

        /// <summary>
        /// Swap the wire states between enabled and disabled based on request
        /// </summary>
        /// <param name="statusRequest">"enable" or "disable" depending on requirement</param>
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

        /// <summary>
        /// Counts the number of red wires that were generated
        /// </summary>
        /// <returns>Number or red wires</returns>
        private int CountRedWires() {

            int returnValue = 0;                                    // Default return value is 0

            for (int i = 0; i < 5; i++)
            {
                if (buttonList[i].BackColor == Color.Red)
                    returnValue++;
            }

            return returnValue;
        }

        /// <summary>
        /// Determines if last wire is white
        /// </summary>
        /// <returns>true if wire is white, false if wire is not white</returns>
        private bool LastWireWhite() {

            bool returnValue = false;                               // Default returnValue is false

            if (buttonList[4].BackColor == Color.White)
                returnValue = true;

            return returnValue;
        }
        
        /// <summary>
        /// Count the number of blue wires allocated
        /// </summary>
        /// <returns>the number of blue wires</returns>
        private int CountBlueWires() {

            int returnValue = 0;

            for (int i = 0; i < 5; i++)
            {
                if (buttonList[i].BackColor == Color.Blue)
                {
                    returnValue++;
                    lastBlueWireIndex = i;                          // Determine the index of the last blue wire in the bomb
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Reset the wires to a default gray background
        /// </summary>
        private void ResetWireColors() {

            for (int i = 0; i < 5; i++)
            {
                buttonList[i].BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Randomly assign numbers to the wires
        /// </summary>
        private void SetWireColors() {

            for (int i = 0; i < 5; i++)
            {
                buttonList[i].BackColor = wireColor[RandomNumber(0,5)];
            }
        }

        /// <summary>
        /// Random number generator.  Generates a number between min and max specified values
        /// </summary>
        /// <param name="min">lowest value to include in random number generation</param>
        /// <param name="max">highest value to include in random number generation.  Please note, 
        ///                     the max number is always (max - 1), so if 5 is specified, the
        ///                     highest number that will be generated is 4.</param>
        /// <returns>A number between 0 and 5 (including 0 but not including 5)</returns>
        private static int RandomNumber(int min, int max) {
            return random.Next(min, max);
        }
    }
}
