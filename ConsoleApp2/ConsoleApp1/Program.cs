using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using BinaryTree;
using Commands;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;

            remote.SetCommandForButton("add",new Add());                 //назначение команд
            remote.SetCommandForButton("print", new Print());
            remote.SetCommandForButton("printlog", new PrintLog());
            remote.SetCommandForButton("undo", new UnDo());


            do
            {
                Console.Clear();
                Console.WriteLine("Выберите вариант ниже:");
                Console.WriteLine(remote);       //команды в интерфейсе
                Console.Write("\nВаш выбор: ");
                userInput = Console.ReadLine().ToLower();   //ввод не зависит от CAPSа
                remote.PushButton(userInput);
                Console.ReadKey();
            } while (userInput != "exit");
        }
    }
}
