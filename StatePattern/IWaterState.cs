namespace State; 

public interface IWaterState {

    void Heat(WaterContext water);
    void Frost(WaterContext water);

}