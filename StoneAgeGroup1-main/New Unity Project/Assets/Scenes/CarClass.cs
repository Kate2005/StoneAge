[System.Serializable]
public class CarClass : Transport
{
    public string name;
    public int hoursePower;
    public EngineType engineType;

    public CarClass()
    {
        name = "NULL";
        hoursePower = 0;
        engineType = EngineType.Gasoline;
    }

    public CarClass(string name)
    {
        this.name = name;

    } 
    
    public CarClass(string name, int horsePower, EngineType engineType)
    {
        this.name = name;
        this.hoursePower = horsePower;
        this.engineType = engineType;
    }


    public string GetInfo()
    {
        return ("Марка" + name + "Лошадей" + hoursePower + engineType + weight);
    }

}
public enum EngineType { Electro, Gasoline, Disel}
