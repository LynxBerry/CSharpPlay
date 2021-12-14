class FactoryMyApp : IFactoryApp 
{
    public Application CreateApp()
    {
        return new MyApplication();
    }
}