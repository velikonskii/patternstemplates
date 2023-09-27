namespace State.States; 

public class SolidWaterState : IWaterState {
    public void Heat(WaterContext water) {
        Console.WriteLine("turning from a solid into liquid");
        water.State = new LiquidWaterState();
    }

    public void Frost(WaterContext water) {
        Console.WriteLine("nothing happening");
    }
}