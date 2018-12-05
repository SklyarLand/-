using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class UnDo : ICommand  //команда отмены действия
    {

        
        public void Execute(List<ICommand> ts, List<int> Unit)
        {
            Console.WriteLine("Удален элемент: {0}", Unit[Unit.Count() - 1]);
            ts.RemoveAt(ts.Count()-1);
            Unit.RemoveAt(Unit.Count() - 1);
        }
        public override string ToString()
        {
            return "\tотменить действие";
        }

    }
}
