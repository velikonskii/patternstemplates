namespace State; 

public class WaterContext {
    public IWaterState State { get; set; }

    public WaterContext(IWaterState state) {
        State = state;
    }

    public void Heat() {
        State.Heat(this);
    }

    public void Frost() {
        State.Frost(this);
    }

}