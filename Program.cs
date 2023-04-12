using Access_Modifiers___Encaptulation.Models;

Console.Write("Enter name:");
string name = Console.ReadLine();
Console.Write("Enter surname:");
string surname = Console.ReadLine();
Console.Write("Enter age:");
int age = int.Parse(Console.ReadLine());
Console.Write("Enter birthday:");
int birthday = int.Parse(Console.ReadLine());
Person person = new Person(name,surname,age,birthday);


//person.SetName(name);
//string name1 =person.GetName();
//person.SetAge(age);
//string age1 = person.GetName();
person.Print();


