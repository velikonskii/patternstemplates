using System;

namespace StoffdPatterns.Builder {
    public class HouseBuilderTypeB : HouseBuilder {
        public override void SetGarden(bool hasGarden) {
            House.GardenType = "^^^^^^^";
            House.HasGarden = hasGarden;
        }

    }
}