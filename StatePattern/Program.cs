using State;
using State.States;


var water = new WaterContext(new LiquidWaterState());

water.Heat();
water.Frost();
water.Frost();