using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class Add : ICommand //команда добавления элемента
    {
        public void Execute(List<ICommand> ts,List<int> Unit)
        {
            Console.WriteLine("Число:");                                   //ввод эемента
            int Input = Int32.Parse(Console.ReadLine());
            Unit.Add(Input);                                               //добавление в лист значений
            ts.Add(new Add());                                             //добавление команды в журнал команд
            Console.WriteLine("добавлен элемент");
        }

        public override string ToString()
        {
            return "\tдобавать элемент";
        }
    }
}
