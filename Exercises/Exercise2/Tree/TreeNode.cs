using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercise2.Tree;

namespace Exercise2.Tree
{
    public class TreeNode
    {
        private IList<TreeNode> Nodes;
        public int level = 0;
        private Country Value { get; set; }

        public TreeNode(Country pValue)
        {
            Nodes = new List<TreeNode>();
            Value = pValue;
        }

        public Country GetNodeValue()
        {
            return Value;
        }

        public int GetNodeCount()
        {
            return Nodes.Count();
        }

        public void AddNode(TreeNode tn)
        {
            Nodes.Add(tn);
        }

        public IList<TreeNode> GetNodes()
        {
            return Nodes;
        }

        public TreeNode GetNode(int index)
        {
            TreeNode tn = null;

            if (Nodes.Count()>= index+1)
                tn = Nodes[index];

            return tn;
        }

        public override string ToString()
        {
            string output = string.Empty;

            output += "Value: " + Value.ToString(); 
            output += ", Level: " + level.ToString();

            return output;
        }
    }
}
