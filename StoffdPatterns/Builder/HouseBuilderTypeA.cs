using System;

namespace StoffdPatterns.Builder {
    public class HouseBuilderTypeA : HouseBuilder {


        public override void SetFloor(int number) {
            if (number < 3) {
                House.Floors.Add(number);
            } else {
                throw new Exception("This type of house cannot be more then 3 floors");
            }
        }

        public override void SetGarden(bool hasGarden) {
            House.HasGarden = hasGarden;
            House.GardenType = "@@@@@@@@";
        }

    }
}