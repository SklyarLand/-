﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace Builder
{
    public class Product: Tree                     //результат строительства
    {
        Tree tree { get; set; }
        public Product(Tree Tr)                    //конструктор
        {
            this.tree = Tr;
        }
        
        public void Show()                        //показывает дерево
        {
            string s="";
            tree.SetRecursion(ref tree.Node, ref s);
            Console.WriteLine(s);
        }
    }
}
