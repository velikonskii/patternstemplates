namespace StoffdPatterns.Builder {
    public class Director {
        public void ConstructHouseTypeA2Floors(HouseBuilderTypeA builder) {
            builder.Reset();
            builder.SetFloor(1);
            builder.SetFloor(2);
            builder.SetWalls("left");
            builder.SetDoor("Wooden");
            builder.SetGarden(true);

        }

        public void ConstructHouseTypeA6Floors(HouseBuilderTypeA builder) {
            builder.Reset();
            builder.SetFloor(1);
            builder.SetFloor(2);
            builder.SetFloor(3);
            builder.SetFloor(4);
            builder.SetFloor(5);
            builder.SetFloor(6);
            builder.SetWalls("left");
            builder.SetDoor("Wooden");
            builder.SetGarden(true);
        }

        public void ConstructHouseTypeB(HouseBuilderTypeB builder) {
            builder.Reset();
            builder.SetDoor("Iron");
            builder.SetGarden(true);
        }
    }
}