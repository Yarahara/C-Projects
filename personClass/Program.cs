// See https://aka.ms/new-console-template for more information
using System;

namespace personClass{
    class Person{
    int nextID = 100;
    int population = 0;

    string name;
    int id;

    public Person(string _name){
        name = _name;
        id = nextID += 10;
        population += 1;
    }

    public string Name{
        get{ return name;}
        set{ name = value;}
    }

    public int ID{
        get{ return id;}
    }

    public int Population{
        get{ return population;}
    }
}

    class Student : Person{
        int bioMajors = 0;
        public string name;
        public string major;

        public Student(string _name, string _major) : base( _name)
        {
            major = _major;
            if (_major == "Biology"){
                bioMajors += 1;
            }
            name = _name;
        }

        public string Major{ get {return major;}}
        public int BioMajors{ get { return bioMajors;}}
    }
    class Program{
        static void Main(string[] args)
    {
        Person p1 = new Person("Sally");
        Console.WriteLine(p1.Name);
        Student s1 = new Student("Sam","Biology");
        Console.WriteLine("{0} {1}", s1.Major, s1.ID);
        Console.ReadKey();
    }
        
    }
    
}
