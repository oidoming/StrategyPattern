// See https://aka.ms/new-console-template for more information

using StrategyPattern.Duck;
using StrategyPattern.Graznar;
using StrategyPattern.Nadar;
using StrategyPattern.Volar;


Duck duck;

int ReadOption(int options)
{
    int option;
    if (Int32.TryParse(Console.ReadLine(), out option))
    {
        return option;
    }
    else
    {
        Console.WriteLine("Ingrese solo numeros");
    }

    return 0;
}

int SelectBehavior()
{
    Console.WriteLine("Seleccione una accion:");
    Console.WriteLine("1. Graznar\n2. Nadar\n3. Volar\n");

    int option = ReadOption(3);
    return option;

}

void DoBehavior()
{
    int option = SelectBehavior();
    Console.Clear();

    if (option == 1)
    {
        duck.performGraznar();
    }
    else if (option == 2)
    {
        duck.performNadar();
    }
    else if (option == 3)
    {
        duck.performVolar();
    }

    System.Threading.Thread.Sleep(3000);
}

void ChangeBehavior()
{
    Console.WriteLine("Cambiar comportamiento");

    int option = SelectBehavior();
    Console.Clear();

    if (option == 1)
    {
        Console.WriteLine("1. Quack\n2. Squeeze\n3. Mute\n");
        int graznarOption = ReadOption(3);
        if (graznarOption == 1)
            duck.setGraznar(new Quack());
        else if (graznarOption == 2)
            duck.setGraznar(new Squeeze());
        else if (graznarOption == 3)
            duck.setGraznar(new Mute());
    }
    else if (option == 2)
    {
        Console.WriteLine("1. Float\n2. Front Crawl\n3. Swimming No Way\n");
        int nadarOption = ReadOption(3);
        if (nadarOption == 1)
            duck.setNadar(new Float());
        else if (nadarOption == 2)
            duck.setNadar(new FrontCrawl());
        else if (nadarOption == 3)
            duck.setNadar(new SwimmingNoWay());
        
    }
    else if (option == 3)
    {
        Console.WriteLine("1. Fly With Wings\n2. Levitate\n3. Fly No Way\n");
        int volarOption = ReadOption(3);
        if (volarOption == 1)
            duck.setVolar(new FlyWithWings());
        else if (volarOption == 2)
            duck.setVolar(new Levitate());
        else if (volarOption == 3)
            duck.setVolar(new FlyNoWay());
    }
}

void SelectDuck()
{
    Console.WriteLine("Seleccione una especie de pato (Duck):");
    Console.WriteLine("1. Mallard Duck\n2. RedHead Duck\n3. Decoy Duck\n4. Model Duck\n5. Rubber Duck\n");

    int option = ReadOption(5);

    if (option == 1)
    {
        duck = new MallardDuck();
    }
    else if (option == 2)
    {
        duck = new RedHeadDuck();
    }
    else if (option == 3)
    {
        duck = new DecoyDuck();
    }
    else if (option == 4)
    {
        duck = new ModelDuck();
    }
    else if (option == 5)
    {
        duck = new RubberDuck();
    }
    else
    {
        Console.WriteLine("Opcion invalida. Se usara Mallard Duck por defecto.");
        duck = new MallardDuck();
    }
}

void App()
{
    SelectDuck();
    Console.Clear();
    while (true)
    {
        duck.display();
        Console.WriteLine("\nQue deasea hacer?");
        Console.WriteLine("1. Hacer un comportamiento\n2. Cambiar un comportamiento\n3. Elegir otro pato\n");
        int option = ReadOption(3);
        Console.Clear();

        if (option == 1)
        {
            DoBehavior();
            Console.Clear();
        }
        else if (option == 2)
        {
            ChangeBehavior();
            Console.Clear();
        }
        else if (option == 3)
        {
            SelectDuck();
            Console.Clear();
        }
    }
}

App();