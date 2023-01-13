namespace StoffdPatterns.Builder {
    public class HouseBuilder {

        protected House House = new House();

        public virtual void Reset() {
            House.GardenType = "______";
            House.Walls.Clear();
            House.Floors.Clear();
            House.DoorType = "none";
            House.HasGarden = false;
            House.HasFence= false;
        }

        public virtual void SetFloor(int number) {
            House.Floors.Add(number);
        }

        public virtual void SetWalls(string side) {
            House.Walls.Add(side);
        }

        public virtual void SetDoor(string type) {
            House.DoorType = type;
        }

        public virtual void SetGarden(bool hasGarden) {
            House.HasGarden = hasGarden;
        }

        public virtual void SetFence(bool hasFence) {
            House.HasFence = hasFence;
        }

        public House GetResult() {
            return House;
        }
    }

}