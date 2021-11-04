using System.Collections.Generic;

namespace CarpetAss1
{
    class CarpetCalc
    {
        public float RoomWidth { get; set; }
        public float RoomLength { get; set; }
        public float RoomArea { get; set; }
        public float CarpetCost { get; set; }
        public float InstallationCost { get; set; }
        public float UnderlayCost { get; set; }

        private List<float> totalCost { get; set; }

        public CarpetCalc()
        {
            totalCost = new List<float>();

        }

        public float CalcRoomSqMtr(float roomLength, float roomWidth)
        {
            return roomLength * roomWidth;
        }

        public float CalcInstallCost(float RoomArea, float InstallationCost)
        {
            return InstallationCost * RoomArea;
        }

        public float CalcUnderlayCost(float RoomArea, float UnderlayCost)
        {
            return UnderlayCost * RoomArea;
        }

        public int CalcCarpetRolls(float roomLength, float roomWidth)
        {
            // carpet rolls are 1mtr wide by 4mtr long

            int carpetRollWidth = 1;
            int carpetRollLength = 4;

            //count how many times the width of the carpet goes into the width of the room
            int widthCounter = (int)(roomWidth / carpetRollWidth);

            //if there is anything left over, add 1 to the total width
            if (roomWidth % carpetRollWidth > 0)
            {
                widthCounter++;
            }
            //find the total length of the carpet you need to lay
            float totalLength = widthCounter * roomLength;

            //divide by the length of a carpet roll to find out how many rolls you need
            int carpetRolls = (int)totalLength / carpetRollLength;

            //if there is aything left over get another full roll
            if (totalLength % carpetRollLength > 0)
            {
                carpetRolls++;
            }

            return carpetRolls;
        }

        //return the cost of all the rooms
        public float TotalCost(float total)
        {

            totalCost.Add(total);

            float sumtotal = 0;

            foreach (var item in totalCost)
            {
                sumtotal += item;
            }


            return sumtotal;
        }
    }
}
