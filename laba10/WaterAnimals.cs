public abstract class WaterAnimals
{
    protected string golod;
    protected string groupp;
    protected bool sytost;
    internal string Golod
    {
        set { golod = value; }
        get { return golod; }
    }
    internal string Groupp
    {
        set { groupp = value; }
        get { return groupp; }
    }
    internal bool Sytost
    {
        set { sytost = value; }
        get { return sytost; }
    }
    protected WaterAnimals()
    {
        Groupp = "unknown";
        Sytost = false;
    }
    abstract public void Kormlenie();
    virtual internal string AllInfo()
    {
        return "буль буль";
    }
}