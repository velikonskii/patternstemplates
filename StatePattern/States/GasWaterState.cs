namespace State.States; 

public class GasWaterState : IWaterState {
    public void Heat(WaterContext water) {
        Console.WriteLine("nothig happened (gas)");
    }

    public void Frost(WaterContext water) {
        Console.WriteLine("turning from gas into liquid");
        water.State = new LiquidWaterState();
    }
}