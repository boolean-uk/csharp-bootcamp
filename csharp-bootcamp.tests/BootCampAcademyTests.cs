using csharp_bootcamp.source;

namespace csharp_bootcamp.tests;

[TestFixture]
public class BootCampAcademyTests
{   

    [Test]
    public void AddCourseToBootCampTest()
    {
        BootCampAcademy academy = new BootCampAcademy();
        BootCampCourse course1 = new BootCampCourse();
        course1.Name = "C#";

        academy.AddCourse(course1);

        Assert.AreEqual(academy.Courses.Count, 1);

    }
    [Test]
    public void RemoveCourseFromBootCamp()
    {
        BootCampAcademy academy = new BootCampAcademy();
        academy.SeedData();
        int count = academy.Courses.Count;
        string name = "Ada";
        bool removeResult = academy.RemoveCourse(name);

        Assert.IsTrue(removeResult);
        Assert.AreEqual(academy.Courses.Count,count-1);
    }

}