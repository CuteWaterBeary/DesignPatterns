public class HotelBuilder : BuilderBase
{
    public HotelBuilder()
    {
        building = new Build("Hotel");
        building.AddFloor();
        building.AddFloor();
        building.AddFloor();
    }
}
