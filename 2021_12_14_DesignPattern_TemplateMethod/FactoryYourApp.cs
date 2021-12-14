class FactoryYourApp : IFactoryApp 
{
    public Application CreateApp()
    {
        return new YourApplication();
    }
}