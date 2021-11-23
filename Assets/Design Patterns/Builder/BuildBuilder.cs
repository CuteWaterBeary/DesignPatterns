public class BuildBuilder : BuilderBase
{
    public BuildBuilder()
    {
        building = new Build("Apartment");
        building.AddFloor();
        building.AddGarage();
        building.AddGarden();
    }
}
