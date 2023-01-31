using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    //HashSet is an unordered collection of unique items
    class MyHashSet
    {
        string name;
        int id;
        string department;

        public MyHashSet(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }
        //static void Main(string[] args)
        //{
        //    MyHashSet hashSet = new MyHashSet("Jay", 234, "Tech");
        //    MyHashSet hashSet2 = new MyHashSet("Allan", 456, "Statistics");
        //    MyHashSet hashSet3 = new MyHashSet("Evan", 789, "Business");

        //    //Dictionary type to store the employees by ID
        //    Dictionary<int, MyHashSet> employeesByID = new Dictionary<int, MyHashSet>();
        //    //to add to the dictionary
        //    employeesByID.Add(hashSet.id, hashSet);
        //    employeesByID.Add(hashSet2.id, hashSet2);
        //    employeesByID.Add(hashSet3.id, hashSet3);

        //    MyHashSet e;//if the key has a value it will be stored in e
        //    if (employeesByID.TryGetValue(456, out e))
        //    {
        //        Console.WriteLine(e.name + ":" + e.department);
        //    }

        //}
    }
}
