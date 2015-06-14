using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercise2.Tree;
using System.IO;

namespace Exercises.Exercise2
{
    public class Exercise2
    {
        private TreeNode root = null;
        private TreeNode modRoot = null;
        private StringBuilder sb = new StringBuilder();
        private bool done = false;
        
        public Exercise2()
        {
            Console.WriteLine("Exercise 2:");
            Console.WriteLine("Serialize a tree so it can be reconstructed");
            root = BuildTree();
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 2..");

            SerializeDeserializeTree();

            Console.WriteLine("Exercise 2 is completed!");
        }

        private void SerializeDeserializeTree()
        {
            ShowTree(root);
            WriteToFile();
            IList<string> fileContents = ReadFile();
            BuildTree(fileContents);
        }

        private void BuildTree(IList<string> fileContents)
        {

        }

        private TreeNode GetNode(string line)
        {
            string[] contents = line.Split(',');
            string[] capital = contents[0].Split(':');
            string[] country = contents[1].Split(':');
            string[] level = contents[2].Split(':');

            Country curCountry = new Country(capital[1].Trim(),
                                                country[1].Trim());
            TreeNode tn = new TreeNode(curCountry);
            tn.level = Convert.ToInt32(level[1].Trim());

            return tn;
        }
        
        private IList<string> ReadFile()
        {         
            IList<string> lines = new List<string>();
            string line = string.Empty;
            StreamReader sr = null;
            string path = Environment.CurrentDirectory + "\\tree.txt";

            try
            {
                sr = new StreamReader(path);

                while(sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    line = line.Trim(',');
                    lines.Add(line);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                    sr = null;
                }
            }

            return lines;
        }

        private void ShowTree(TreeNode root)
        {
            ShowNode(root);
        }
        private void ShowNode(TreeNode node)
        {
            sb.AppendLine(AddDepthAndValue(node));

            foreach (TreeNode child in node.GetNodes())
                ShowNode(child);
        }

        private void WriteToFile()
        {
            StreamWriter sw = null;
            string path = Environment.CurrentDirectory + "\\tree.txt";

            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                sw = new StreamWriter(path);
                sw.WriteLine(sb.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    sw = null;
                }
            }
        }
        private string AddDepthAndValue(TreeNode tn)
        {
            int ctr = 0;
            string output = string.Empty;

            while(ctr<tn.level)
            {
                output += ",";

                ctr++;
            }

            output += tn.GetNodeValue() + ", Level: " + tn.level.ToString();

            return output;
        }
        protected TreeNode BuildTree()
        {
            Console.WriteLine("Building Tree...");

            TreeDriver td = new TreeDriver(PopulateCountries());
            TreeNode root = td.GetRootTreeNode();

            return root;
        }
        protected IList<Country> PopulateCountries()
        {
            IList<Country> countries = new List<Country>();

            countries.Add(new Country("Capital 1", "Country 1"));
            countries.Add(new Country("Capital 2", "Country 2"));
            countries.Add(new Country("Capital 3", "Country 3"));
            countries.Add(new Country("Capital 4", "Country 4"));
            countries.Add(new Country("Capital 5", "Country 5"));
            countries.Add(new Country("Capital 6", "Country 6"));
            countries.Add(new Country("Capital 7", "Country 7"));
            countries.Add(new Country("Capital 8", "Country 8"));
            countries.Add(new Country("Capital 9", "Country 9"));
            countries.Add(new Country("Capital 10", "Country 10"));

            //countries.Add(new Country("Capital 11", "Country 11"));
            //countries.Add(new Country("Capital 12", "Country 12"));
            //countries.Add(new Country("Capital 13", "Country 13"));
            //countries.Add(new Country("Capital 14", "Country 14"));
            //countries.Add(new Country("Capital 15", "Country 15"));
            //countries.Add(new Country("Capital 16", "Country 16"));
            //countries.Add(new Country("Capital 17", "Country 17"));
            //countries.Add(new Country("Capital 18", "Country 18"));
            //countries.Add(new Country("Capital 19", "Country 19"));
            //countries.Add(new Country("Capital 20", "Country 20"));

            //countries.Add(new Country("Capital 31", "Country 31"));
            //countries.Add(new Country("Capital 32", "Country 32"));
            //countries.Add(new Country("Capital 33", "Country 33"));
            //countries.Add(new Country("Capital 34", "Country 34"));
            //countries.Add(new Country("Capital 35", "Country 35"));
            //countries.Add(new Country("Capital 36", "Country 36"));
            //countries.Add(new Country("Capital 37", "Country 37"));
            //countries.Add(new Country("Capital 38", "Country 38"));
            //countries.Add(new Country("Capital 39", "Country 39"));
            //countries.Add(new Country("Capital 40", "Country 40"));

            //countries.Add(new Country("Capital 41", "Country 41"));
            //countries.Add(new Country("Capital 42", "Country 42"));
            //countries.Add(new Country("Capital 43", "Country 43"));
            //countries.Add(new Country("Capital 44", "Country 44"));
            //countries.Add(new Country("Capital 45", "Country 45"));
            //countries.Add(new Country("Capital 46", "Country 46"));
            //countries.Add(new Country("Capital 47", "Country 47"));
            //countries.Add(new Country("Capital 48", "Country 48"));
            //countries.Add(new Country("Capital 49", "Country 49"));
            //countries.Add(new Country("Capital 50", "Country 50"));

            return countries;
        }
    }
}
