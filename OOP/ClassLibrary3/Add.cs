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
            Console.WriteLine("Число:");
            int Input = Int32.Parse(Console.ReadLine());
            Unit.Add(Input);
            ts.Add(new Add());
            Console.WriteLine("добавлен элемент");
        }

        public override string ToString()
        {
            return "\tдобавать элемент";
        }
    }
}
