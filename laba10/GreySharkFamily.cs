abstract class GreySharkFamily : Fishes
{
    protected string genus;
    internal string Genus
    {
        set { genus = value; }
        get { return genus; }
    }
    protected GreySharkFamily() : base()
    {
        Family = "серые акулы";
        Genus = "unknown";
    }
}