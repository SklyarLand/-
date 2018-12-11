using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using System.IO;

namespace Commands
{
    public class Print : ICommand //команда строит дерево и выводит его
    {
        public void Execute(List<ICommand> ts, List<int> Unit)
        {
            Director director = new Director();             //строительство дерева
            IBuilder b1 = new BuildTree(Unit);
            director.Construct(b1);
            Product _product = new Product(b1.GetResult());
            Console.WriteLine(_product.ToString());

            ts.Add(new Print());
 
            FileStream FileWriter = new FileStream(@"Result.txt", FileMode.Create);
            byte[] array = System.Text.Encoding.Default.GetBytes("Обход в глубину:"+_product.ToString());
            FileWriter.Write(array,0,array.Length);

        }
        public override string ToString()
        {
            return "\tвывести элемент";
        }
    }
}
