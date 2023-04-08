class BullShark : Seruli
{
    protected string name;
    protected int yo;
    internal string Name
    {
        set { name = value; }
        get { return name; }
    }
    internal int YO
    {
        set { yo = value; }
        get { return yo; }
    }
    protected const string nutrition = "хищник";
    protected const int lifeexpectancy = 30;
    internal BullShark() : base()
    {
        Kind = "тупорылая акула";
        Name = "NoName";
    }
    internal BullShark(string name, int age) : base()
    {
        Kind = "тупорылая акула";
        Name = name;
        YO = age;
    }
    override public void Kormlenie()
    {
        Sytost = true;
        Console.WriteLine($"{Kind} {Name} покормлен(а)!");
    }
    override internal string AllInfo()
    {
        if (Sytost is false)
            Golod = "голоден(а)";
        else Golod = "сыт(а)";
        return $"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^" +
            $"имя: {Name}, \n" +
            $"возраст: {YO} лет, \n" +
            $"группа животных: {Groupp}, \n" +
            $"семейство животных: {Family}, \n" +
            $"род животных: {Genus}, \n" +
            $"вид животных: {Kind}, \n" +
            $"тип питания: {nutrition}, \n" +
            $"сытость: {Golod}, \n" +
            $"продолжительность жизни: {lifeexpectancy} лет \n" +
            $"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
    }
}