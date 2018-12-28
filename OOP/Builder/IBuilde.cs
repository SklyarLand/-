using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace Builder
{
    public interface IBuilder                //он русский
    {
        void Build();                       //строит
        Tree GetResult();                    //отдает дерево
    }
}
