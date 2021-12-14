class Application 
{
    public Application() {}

    // Design Pattern: Template Method
    public void TemplateMethod()
    {
        Console.WriteLine("We are entering TemplateMethod");
        Step1();
        Step2();
        Step3();

    }

    protected virtual void Step1()
    {

    }

    protected virtual void Step2()
    {

    }

    protected virtual void Step3()
    {

    }

}