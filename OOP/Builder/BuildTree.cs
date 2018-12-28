using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace Builder
{
    public class BuildTree : IBuilder              //конкретный строитель дерева
    {
        List<int> unit;                            //лист значений
        Tree TREE;                                 //здесь будет построенное дерево
        public void Build()
        {
            TREE = new Tree();                     //строит дерево по значениям
            foreach (int i in unit)
                TREE.Create(ref TREE.Node, i);
        }

        public BuildTree(List<int> Unit)             //конструктор
        {
            this.unit = Unit;
        }

        public Tree GetResult()
        {
            return TREE;
        }
    }
}
