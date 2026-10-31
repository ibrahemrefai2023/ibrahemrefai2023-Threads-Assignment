namespace MenuViews;

public sealed class MenuViewCounter
{
    public int Views;
    private readonly Object _lock = new();
   

    public void RegisterView()
    {
        lock (_lock)
        {
            Views++;
        }  
    }
}
