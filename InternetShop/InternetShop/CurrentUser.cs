namespace InternetShop;

public static class CurrentUser
{
    private static string name;

    public static string Name
    {
        get => name;
        set => name = value;
    }
}