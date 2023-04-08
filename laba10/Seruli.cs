abstract class Seruli : GreySharkFamily
{
    protected string kind;
    internal string Kind
    {
        set { kind = value; }
        get { return kind; }
    }
    protected Seruli() : base()
    {
        Genus = "серые акулы";
        Kind = "unknown";
    }
}