using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode // лист дерева
    {
        public int Value; // численное значение
        public TreeNode Left = null; // левое поддерево
        public TreeNode Right = null; // правое поддерево

        public TreeNode(int value)  //конструктор
        {
            this.Value = value;
        }
    }
}
