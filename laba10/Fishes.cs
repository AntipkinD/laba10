abstract class Fishes : WaterAnimals
{
    protected string family;
    internal string Family
    {
        set { family = value; }
        get { return family; }
    }
    protected Fishes() : base()
    {
        Groupp = "рвбы";
        Family = "unknown";
    }
    override public void Kormlenie()
    {
        Sytost = true;
    }
}