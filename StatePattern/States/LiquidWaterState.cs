namespace State.States; 

public class LiquidWaterState : IWaterState {
    public void Heat(WaterContext water) {
        Console.WriteLine("turning from a liquid into gas");
        water.State = new GasWaterState();
    }

    public void Frost(WaterContext water) {
        Console.WriteLine("turning from a liquid into solid");
        water.State = new SolidWaterState();
    }
}