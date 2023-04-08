class DolphinFamily : WaterMammals
{
    protected string genus;
    internal string Genus
    {
        set { genus = value; }
        get { return genus; }
    }
    protected DolphinFamily() : base()
    {
        Family = "дельфиновые";
        Genus = "unknown";
    }
}