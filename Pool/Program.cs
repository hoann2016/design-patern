using Pool;

Factory fa = new Factory();
Student myStu = fa.GetStudent();
Console.WriteLine("First object");
Student myStu1 = fa.GetStudent();
Console.WriteLine("Second object");
Student myStu2 = fa.GetStudent();
Console.WriteLine("Third object");
Student myStu3 = fa.GetStudent();
Console.WriteLine("Four object");
Student myStu4 = fa.GetStudent();
Console.WriteLine("fith object");
Console.Read();