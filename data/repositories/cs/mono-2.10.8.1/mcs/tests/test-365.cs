public enum LiteralType
{
    Void,
}

class C
{
    public LiteralType LiteralType
    {
        set
        {
        }
    }

    private LiteralType[] widenSbyte = new LiteralType[]
    {
        LiteralType.Void
    };

    static void Main () {}
}

