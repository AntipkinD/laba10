class WaterMammals : WaterAnimals
{
    protected string family;
    internal string Family
    {
        set { family = value; }
        get { return family; }
    }
    protected WaterMammals() : base()
    {
        Groupp = "млекопитающие";
        Family = "unknown";
    }
    override public void Kormlenie()
        {
            Sytost = true;
        }
}