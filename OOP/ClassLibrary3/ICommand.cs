using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public interface ICommand //шаблон команды принимает в аргументах журнал команд и журнал значений
    {
        void Execute(List<ICommand> ts,List<int> Unit);
    }
}
