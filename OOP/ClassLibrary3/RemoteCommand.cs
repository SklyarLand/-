using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class RemoteControl  //класс связи пользователя и команд, содержит журналы, метод нажатия кнопки, метод назначения команды на кнопку
    {
        Dictionary<string, ICommand> _commands;  //словарь команд
        List<ICommand> _listCommand;            //журнал команд для ввода-вывода
        List<int> _list_int;                   //журнал значений для ввода-вывода
        public RemoteControl()                                            //конструктор пульта
        {
            _commands = new Dictionary<string, ICommand>();                  //создает словарь команд
            _listCommand = new List<ICommand>();    //создает журнал команд
            _list_int = new List<int>();            //создает журнал чисел
        }

        public void PushButton(string buttonId)                              // кнопка действия
        {
            if (_commands.ContainsKey(buttonId))                       //если есть такая команда
            {
                _commands[buttonId].Execute(_listCommand,_list_int);                          //команда работает
            }
        }

        public void SetCommandForButton(string buttonId, ICommand cmd)     //назначение команды на входящую строку
        {
            _commands[buttonId] = cmd;                                     
        } //
        public override string ToString()                              //часть интерфейса
        {
            var sb = new StringBuilder();
            foreach (var buttonId in _commands.Keys)
                sb.AppendFormat("{0} \t{1}\n", buttonId, _commands[buttonId]);

            sb.Append("exit\t\t Выход");

            return sb.ToString();
        }
    }
}
