using CarpetAss1.Properties;

using System;
using System.Windows.Forms;

namespace CarpetAss1
{
    public partial class Form1 : Form
    {
        CarpetCalc carpetCalc;
        public Form1()
        {
            InitializeComponent();
            carpetCalc = new CarpetCalc();

        }

        //all button clicks for carpet selection using switch statement
        private void btnAllCarpetButtons_Click(object sender, EventArgs e)
        {
            Button fakeButton = new Button();
            fakeButton = (Button)sender;

            switch (fakeButton.Text)
            {
                case "Cheap":

                    pbxCarpetImage.Image = Resources.Windsor;
                    carpetCalc.CarpetCost = (float)32.50;
                    break;

                case "Home":

                    pbxCarpetImage.Image = Resources.Kennedy;
                    carpetCalc.CarpetCost = (float)84.40;
                    break;

                case "Luxurious":

                    pbxCarpetImage.Image = Resources.Hilton;
                    carpetCalc.CarpetCost = (float)99.75;
                    break;

                default:
                    // code block
                    break;

            }


            lblCarpetCost.Text = "$" + carpetCalc.CarpetCost.ToString();
            Calculation();
        }


        private void cbxAllBoxes_CheckedChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void AllUpDown_ValueChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void Calculation()
        {
            float InstallCost = 0;
            float UnderlayCost = 0;
            float CarpetRolls = 0;
            float CarpetCost = 0;

            carpetCalc.RoomWidth = (float)numRoomWidth.Value;
            carpetCalc.RoomLength = (float)numRoomLength.Value;
            carpetCalc.UnderlayCost = (float)numUnderlayCost.Value;
            carpetCalc.InstallationCost = (float)numInstallCost.Value;

            var RoomArea = carpetCalc.CalcRoomSqMtr(carpetCalc.RoomLength, carpetCalc.RoomWidth);

            if (cbxInstall.Checked)
            {
                InstallCost = carpetCalc.CalcInstallCost(RoomArea, carpetCalc.InstallationCost);
            }
            if (cbxUnderlay.Checked)
            {
                UnderlayCost = carpetCalc.CalcUnderlayCost(RoomArea, carpetCalc.UnderlayCost);
            }
            if (cbxCarpet.Checked)
            {
                CarpetCost = RoomArea * carpetCalc.CarpetCost;

                CarpetRolls = carpetCalc.CalcCarpetRolls(carpetCalc.RoomLength, carpetCalc.RoomWidth);

            }

            var RoomCost = InstallCost + UnderlayCost + CarpetCost;

            lblRoomCost.Text = "$" + RoomCost.ToString();
            lblTotalCost.Text = "$" + carpetCalc.TotalCost(RoomCost).ToString();

            this.Text = "You need " + CarpetRolls + " carpet rolls";

            //using Ternery Operators to replace bool with yes / no
            string underlayword = cbxUnderlay.Checked ? "Yes" : "No";
            string carpetword = cbxCarpet.Checked ? "Yes" : "No";
            string installword = cbxInstall.Checked ? "Yes" : "No";

            if (RoomCost > 0)
            {
                lbxSummary.Items.Insert(0, carpetCalc.RoomSummary(carpetCalc.RoomLength, carpetCalc.RoomWidth, underlayword, carpetword, installword, RoomCost));
            }


        }

        //clear the summary listbox
        private void btnClearSummary_Click(object sender, EventArgs e)
        {
            lbxSummary.Items.Clear();
        }
    }
}
