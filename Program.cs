// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Console.WriteLine("Hello, World!");
/////////////////////abstract
//int choice;
//Console.WriteLine("1.Child1 SayHello");
//Console.WriteLine("2.Child2 SayHello");
//Console.WriteLine("Select an option");
//choice = Convert.ToInt32(Console.ReadLine());
//Parent obj;
//switch (choice)
//{
//    case 1:
//        obj = new Child1();
//        obj.SayHello();
//        break;
//    case 2:
//        obj = new Child2();
//        obj.SayHello();
//        break;
//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}

//////////////////////////////////Interface
//IShape sh;
//int choice;
//Console.WriteLine("1.Area of Circle");
//Console.WriteLine("2.Area of Rectangle");
//Console.WriteLine("3.Area of Square");
//Console.WriteLine("Select an option");
//choice = Convert.ToInt32(Console.ReadLine());


//switch (choice)
//{
//    case 1:
//        sh = new Circle();
//        sh.GetDetails();
//        sh.CalculateArea();
//        sh.DisplayDetails();
//        break;
//    case 2:
//        sh = new Rectangle();
//        sh.GetDetails();
//        sh.CalculateArea();
//        sh.DisplayDetails();
//        break;
//    case 3:
//        sh = new Square();
//        sh.GetDetails();
//        sh.CalculateArea();
//        sh.DisplayDetails();
//        break;
//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}

///////////Multiple Inheritance
//Interface1 obj = new Class2();
//obj.Function1();
//Interface2 obj2 = new Class2();
//obj2.Function2();

////////////////explicit 
//Interface3 obj = new Class3();
//obj.Display();
//Interface4 obj2 = new Class3();
//obj2.Display();

/////////////////multilevel
//Interface7 obj = new Class5();
//obj.Hello();
//obj.World();


///////////Basic Inheritance
//Child obj = new Child();
//obj.Function2();



////////////passing data from child constructor to parent constructor
//Class7 obj = new Class7(10, 20, 30);
//obj.Display3();


///////////////////Virtual function, sealed, override functions
//Class8 obj = new Class8();
//obj.Display();

//Class9 obj2 = new Class9();
//obj2.Display();


/////////////////shadowing
//Class12 obj = new Class12();
//obj.Display();



///////////File Handling
Console.WriteLine("Hello, World!");

//Class13 obj = new Class13();
//
//obj.WriteToFile();
//obj.ReadFromFile();
//obj.WriteToFile();

Class14 obj= new Class14();


obj.DisplayDetails();










