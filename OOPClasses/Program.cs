namespace OOPClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment Polymorphism
            Animal animal = new Animal();
            animal.Name = "Lion";
            animal.AnimalSound();


            Chef chef = new Chef();
            chef.specialDish = "Marcaroni bugeta";
            chef.MakeSpecialDishes();

            italianChef italianChef = new italianChef();
            italianChef.specialDish = "PAsta posto";
            italianChef.MakeSpecialDishes();

            Person person = new Person();
            person.Info();

            Student student = new Student();
            student.Info();

            Teacher teach = new Teacher();
            teach.Info();

            
        }
    }
    class Chef
    {
        public string specialDish { get; set; }
        public void MakeSpecialDishes()
        {
            Console.WriteLine($"Make Special Dishes: Name = {specialDish}");
        }
    }

    class italianChef: Chef
    {

    }

    class Person 
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public virtual void Info()
        {
            Console.WriteLine("I am a person");
        }

    }

    class Student: Person
    {
        public int studentId { get; set; }
        public string School { get; set; }

        public override void Info()
        {
            Console.WriteLine("I am a student");
        }
    }

    class Teacher: Student
    {
        public string TeachersName { get; set; }

        public override void Info()
        {
            Console.WriteLine("I am teacher");
        }
    }







}