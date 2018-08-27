using System;

namespace ConsoleAbstractClassTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to start!");
            Console.ReadKey(true);

            //ABSTRACT
            //AN ABSTRACT CLASS CANO'T INSTANCIADED
            //BUT WE CAN CALL YOUR METHODS IN EXTESIONS

            var connectionModel = new ConnectionModel();

            //this method is virtual
            Console.WriteLine(connectionModel.ConnectionString());
            Console.WriteLine(connectionModel.ConnectionStatus());

            //this method is abstract
            Console.WriteLine(connectionModel.ConnectionClose());

            Console.WriteLine("Press ENTER to final!");
            Console.ReadKey(true);

        }
    }
}
