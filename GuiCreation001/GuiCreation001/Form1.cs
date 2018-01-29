using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCreation001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void LblRulesRules_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar001.Value < 100)
            {
                this.progressBar001.Increment(1);
            }
            else
            {                
                this.btnStartReset.Enabled = true;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartReset_Click(object sender, EventArgs e)
        {
            if (btnStartReset.Text.Equals("Start Game"))
            {
                btnStartReset.Text = "Reset Game";
                btnStartReset.Enabled = false;
                changeWireState("enable");

                timer1.Start();
            }
            else
            {
                btnStartReset.Text = "Start Game";
                progressBar001.Value = 0;
                changeWireState("disable");

                timer1.Stop();
            }
        }

        private void changeWireState (String statusRequest)
        {
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

        private void btnStartReset_MouseEnter(object sender, EventArgs e)
        {
            btnStartReset.BackColor = Color.LightGray;
        }
    }
}
