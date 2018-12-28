using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class PrintLog : ICommand //команда выводит журнал команд
    {
        public void Execute(List<ICommand> ts, List<int> Unit)
        {
            for (int i=0;i<ts.Count ;i++)
                Console.WriteLine(ts[i].ToString());
            Console.WriteLine("\n\nПорядок добавления элементов:" + Unit.ToString());
            ts.Add(new PrintLog());
        }
        public override string ToString()
        {
            return "вывести список";
        }
    }
}
