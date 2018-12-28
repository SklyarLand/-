using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree                     //класс дерево
    {
        public TreeNode Node;             // содержит корень
        public Tree()                     // конструктор
        {
            this.Node = null;
        }
        // создание нового листа рекурсивно (рекурсивно)
        public void Create(ref TreeNode node, int val)
        {
            if (node == null)
            {
                node = new TreeNode(val);
                return;

            }
            else
            {
                if (node.Value < val)
                    Create( ref node.Right, val);
                else
                    Create( ref node.Left, val);
            }
        }
        // печать дерева (рекурсивно) 
        public void SetRecursion(ref TreeNode node,ref string s)    //на вход корень и ссылка на строку
        {
            if (node != null)
            {
                if (node.Left != null)
                    SetRecursion(ref node.Left, ref s);
                s += node.Value.ToString() + " ";
                if (node.Right != null)
                    SetRecursion(ref node.Right, ref s);
            }
            
            

        }
    }
}
