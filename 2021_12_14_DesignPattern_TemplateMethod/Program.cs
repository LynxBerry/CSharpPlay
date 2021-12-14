// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// IFactoryApp factory = new FactoryMyApp();
IFactoryApp factory = new FactoryYourApp();

Application app = factory.CreateApp();
app.TemplateMethod();