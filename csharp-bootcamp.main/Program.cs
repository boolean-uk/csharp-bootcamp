// See https://aka.ms/new-console-template for more information



using csharp_bootcamp.source;

BootCampAcademy academy = new BootCampAcademy();

academy.SeedData();




Console.WriteLine("Enter course name:");
//write code here




foreach (BootCampCourse x in academy.Courses)
{

    Console.WriteLine(x.Name);

}