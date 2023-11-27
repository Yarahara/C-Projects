// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;

//Console.WriteLine("Hello, World!");
namespace nameIdDictionary{
    class Program{
        
        public static void Main(string[] args)
        {/*
            //1
            Dictionary<string, string> empDict= new();
            Console.WriteLine("Enter ID and name: ");
            string uId = Console.ReadLine();
            string[] uIDList = uId.Split(' ');

            empDict.Add(uIDList[0], uIDList[1]);
            foreach(var (key, value) in empDict)
            {
                Console.WriteLine($"{key} {value}");
            }

            

            //3
            Console.WriteLine("Enter name: ");
            string cName=Console.ReadLine();
            bool check = false;
            foreach(var (key, value) in empDict)
            {
                if (empDict[key] == cName)
                {
                    check = true;
                }
            }

            Console.WriteLine($"Name found {check}");

            //4
            Console.WriteLine("Enter ID to be deleted: ");
            string cId= Console.ReadLine();
            bool inEmpDict = empDict.ContainsKey(cId);
            if (inEmpDict == true)
            {
                empDict.Remove(cId);
            }
            else
            {
                Console.WriteLine("Not deleted -- ID not found");
            }

            //5
            Console.WriteLine("Enter ID to update: ");
            string nId = Console.ReadLine();
            inEmpDict = empDict.ContainsKey(nId);
            if (inEmpDict == true)
            {
                Console.WriteLine("Enter a new name");
                string nName = Console.ReadLine();
                empDict[nId] = nName; 
            }
            else
            {
                Console.WriteLine("ID not in dictionary");
            }
            foreach(var (key, value) in empDict)
            {
                Console.WriteLine($"{key} {value}");
            }

            //6
            empDict.Add("456", "Jane");
            empDict.Add("559", "Jon");
            foreach(var (key, value) in empDict)
            {
                Console.WriteLine($"{key}\t{value}");
            }
*/
            //-----------------list----------------
            //1
            List<string> empList = new List<string>();
            Console.WriteLine("Enter ID and name: ");
            string ein = Console.ReadLine();

            //2
            string[] einS = ein.Split(' ');
            empList.Add(einS[0]);
            empList.Add(einS[1]);

            //3
            Console.WriteLine("Enter a name to check: ");
            string en = Console.ReadLine();
            if (en == empList[1])
            {
                Console.WriteLine(empList[0]);
            }
            else
            {
                Console.WriteLine("Name not found");
            }

            //4
            Console.WriteLine("Enter an ID to be deleted: ");
            string ei = Console.ReadLine();
            if (empList.Contains(ei))
            {
                 empList.Remove(ei);
            }
            else
            {
                Console.WriteLine("ID not found");
            }

            //5
            Console.WriteLine("Enter an ID to update: ");
            string ei2 = Console.ReadLine();
            if (empList.Contains(ei2))
            {
                Console.WriteLine("Enter a new full name: ");
                string nFullName = Console.ReadLine();
                empList[1] = nFullName;
                foreach(var ele in empList)
                {
                    Console.WriteLine(ele);
                }

            }
            else
            {
                Console.WriteLine("ID not found");
            }

            //6
            Console.WriteLine("ID\tName\n123\tJoe Brown\n235\tMary Smith");

            Console.ReadKey();
        }

}
}

