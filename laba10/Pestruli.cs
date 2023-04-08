class Pestruli : DolphinFamily
{
    protected string kind;
    internal string Kind
    {
        set { kind = value; }
        get { return kind; }
    }
    protected Pestruli() : base()
    {
        Genus = "пёстрые дельфины";
        Kind = "unknown";
    }
}