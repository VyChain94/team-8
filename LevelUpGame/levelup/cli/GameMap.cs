public class GameMap
{
    public int numPositions = 100;

public GameMap() {
    CreateMap(10,10);
}

public static Dictionary<int,int> CreateMap(int GridUp, int GridOver)
{
    // Console.WriteLine(GridUp);
    Dictionary<int,int> GridLocations = new Dictionary<int,int>();
    for (int I = 0; I < GridUp; I++ )
    {
        for(int H = 0; H < GridOver; H++ )
        {
            GridLocations.Add(I,H);
        }       
    }
    return GridLocations;
}
}
