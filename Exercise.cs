using System;
namespace mohammed{
    public class Person{
    
    private String name ;
    public String _name{
        set{name=value;
        if(value == null || value == "" || value.Length >=32)
                {
                    throw new Exception("Invalid Name");
                }
        }
        get{ return name;}
    }
    private int age;
    public int _age{
        set{age =value;
        if(value <= 0 || value > 128)
                {
                    throw new Exception("Invalid Age");
                }
        }
        get{return age;}
    }
        public Person(String name ,int age){
            this._name=name;
            this._age=age;
        }
        public virtual void print(){
            
            Console.WriteLine("My name is "+ _name+ ",My age is "+_age);

        }
    }
    public class Student : Person{
        private int year;
        public int _year{
            set{year=value;
            if(value < 1 || value > 5)
                {
                throw new Exception("Invalid Year");
                }
            }
            get{return year;}
        }
        private float gpa;
        public float _gpa{
            set{gpa=value;
            if(value < 0 || value > 4)
                {
                throw new Exception("Invalid Gpa");
                }
            }
            get{return gpa;}
        }
        public Student(String name,int age , int year, float gpa) : base(name,age){
            this._year= year;
            this._gpa=gpa;
        }

        public override void print()
        {
            Console.WriteLine("My name is "+ _name  + ",My age is "+_age+",My gpa is "+_gpa);
        }
    }
    public class Staff : Person{
        private double salary ;
        public double _salary{
            set{salary=value;
            if(value < 0 || value > 120000)
                {
                    throw new Exception("Invalid Salary");
                }
            }
            get{return salary;}
        }
        private int joinYear;
        public int _joinYear{
            set{int current_age= (2022-(2022-_age));
            joinYear=current_age;
            if(current_age<21)
                {
                    throw new Exception("Invalid JoinYear ");
                }
            }
            get{return joinYear;}

        }
        public Staff(String name , int age ,double salary,int joinyear): base (name , age){
            this._salary=salary;
            this._joinYear=joinyear;

        }
        public override void print()
        {
        Console.WriteLine("My name is "+ _name + ",My age is "+_age+", and my salary is "+_salary );
        }
    }
    public class Database {
        private  int Index = 0;
        public int Size;
        
        public Person[] People =new Person[50];
        public Database(){
        }
        public void AddStudent(Student student){

            People[Index++]= student; 

        }
        public void AddStaff(Staff staff){

            People[Index++]= staff; 

        }
        public void AddPerson(Person person){

            People[Index++]= person;

        }
        public void print_everthing(){
            for (int i=0;i< Index ;i++){
                People[i].print();
            }

        }
    }
    class Exercise{
        public static void Main(String[]args){
            Database DB= new Database();
            while(true){
            Console.Write("1)Student   2)Staff   3)Person    4)Print All");
            int option = int.Parse(Console.ReadLine());
            switch(option) {
                case 1: 
                Console.WriteLine("Enter your Name :  ");
                String _Name = Console.ReadLine();
                Console.WriteLine("Enter your  Age :  ");
                int _Age = int.Parse( Console.ReadLine());
                Console.WriteLine("Enter your Year :  ");
                int _Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Gpa :  ");
                float _Gpa = float.Parse(Console.ReadLine());
                try{
                var student = new Student(_Name,_Age,_Year,_Gpa);
                DB.AddStudent(student);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
                case 2: 
                Console.WriteLine("Enter your Name :  ");
                String _Name2= Console.ReadLine();
                Console.WriteLine("Enter your Age :  ");
                int _Age2 = int.Parse( Console.ReadLine());
                Console.WriteLine("Enter your Salary :  ");
                double _Salary2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your JoinYear :  ");
                int _JoinYear2= int.Parse(Console.ReadLine());
                try{
                    var staff = new Staff(_Name2,_Age2,_Salary2,_JoinYear2);
                DB.AddStaff(staff);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
                case 3:
                Console.WriteLine("Enter your Name :  ");
                String _Name3 = Console.ReadLine();
                Console.WriteLine("Enter your Age :  ");
                int _Age3 = int.Parse( Console.ReadLine());
                try{
                var person =new Person(_Name3,_Age3);
                DB.AddPerson(person);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
                case 4:
                DB.print_everthing();
                break;
                default:
                Console.WriteLine("Error!!!!!!!!!!!!");
                break;
            
        }
    }
        }
    }
}