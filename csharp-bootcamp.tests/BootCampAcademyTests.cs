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
}