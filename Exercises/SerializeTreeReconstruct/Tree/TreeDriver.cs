using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Tree
{
    public class TreeDriver
    {
        private int level = 1;

        public void Run()
        {
            Console.WriteLine("Starting Tree Example");

            RunTreeExample();

            Console.WriteLine("Tree Example Completed!");
        }

        private void RunTreeExample()
        {
            if (values == null || values.Count < 1)
                throw new Exception("TreeDriver->values collection is null or has zero members");

            TreeNode root = BuildTree();
            ShowTree(root);

            Console.WriteLine("");

            SearchTree(root, "London");
        }

        #region Search Tree

        private void SearchTree(TreeNode root, string searchTerm)
        {
            SearchNode(root, searchTerm);
        }
        private void SearchNode(TreeNode node, string searchTerm)
        {
            string nodeValue = node.ToString();

            if (nodeValue.IndexOf(searchTerm) != -1)
                Console.WriteLine("Found result: " + nodeValue);
            else
            {
                foreach (TreeNode child in node.GetNodes())
                    SearchNode(child, searchTerm);
            }
        }
        #endregion

        #region Show Tree

        private void ShowTree(TreeNode root)
        {
            ShowNode(root);
        }
        private void ShowNode(TreeNode node)
        {
            Console.WriteLine(node.ToString());

            foreach (TreeNode child in node.GetNodes())
                ShowNode(child);
        }

        #endregion

        #region Build Tree

        private IList<TreeNode> nextRow = new List<TreeNode>();
        private bool done = false;
        private IList<Country> values = null;

        public TreeNode GetRootTreeNode()
        {
            TreeNode root = BuildTree();

            return root;
        }

        public TreeDriver(IList<Country> pValues)
        {
            values = pValues;
        }

        private TreeNode BuildTree()
        {
            TreeNode curParent = null;

            curParent = CreateTreeNode();
            curParent.level = level;
            level++;
            curParent = CreateNodeChildren(curParent);

            while (!done)
            {
                CreateChildNodes();
            }

            return curParent;
        }
        private void CreateChildNodes()
        {
            TreeNode curParent = null;
            IList<TreeNode> parents = new List<TreeNode>();
            foreach (TreeNode tn in nextRow)
                parents.Add(tn);
            
            level++;

            nextRow.Clear();

            foreach (TreeNode parent in parents)
            {
                curParent = CreateNodeChildren(parent);

                if (done)
                    break;
            }
        }
        private TreeNode CreateNodeChildren(TreeNode parent)
        {
            TreeNode child = null;

            while (parent.GetNodeCount() < 2)  //limit to two for a binary tree
            {
                child = CreateTreeNode();

                if (child == null)
                {
                    done = true;
                    break;
                }
                else
                {
                    child.level = level;
                    parent.AddNode(child);
                    nextRow.Add(child);
                }
            }

            return parent;
        }
        private TreeNode CreateTreeNode()
        {
            Country country = GetCountry();
            TreeNode tn = null;

            if (country != null)
            {
                tn = new TreeNode(country);
            }

            return tn;
        }
        private Country GetCountry()
        {
            Country country = null;

            if (this.values.Count > 0)
            {
                country = values[0];
                values.RemoveAt(0);
            }

            return country;
        }

        #endregion
    }
}
