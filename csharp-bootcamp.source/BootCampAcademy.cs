﻿using csharp_bootcamp.source;
using System.Numerics;

namespace csharp_bootcamp.source;



/*
Bootcamp Academy
1. As a student of the Academy I want to be able to add a specific course to my Learning Plan.
2. As a student of the Academy if I change my mind I want to be able to remove a course from my Learning Plan.
3. As a student of the Academy I'd like to know when my Learning plan is full, when I try to add another item (Course, Tutorial, Certification) to it.
4. As a manager at the Academy, I'd like to be able to change the capacity of Learning Plans.
5. As a student of the Academy, I'd like to know that if I try to remove an item that doesn't exist in my Learning Plan.
   
*/


public class BootCampAcademy
{
    private int maxNumberOfCourses = 5;

    public BootCampAcademy()
    {


    }

    public void SeedData()
    {
        this.Courses.Add(new BootCampCourse() { Name = "C#" });
        this.Courses.Add(new BootCampCourse() { Name = "Java" });
        this.Courses.Add(new BootCampCourse() { Name = "Ada" });
        this.Courses.Add(new BootCampCourse() { Name = "Cobol" });
    }

    public void AddCourse(BootCampCourse course1)
    {
        this.Courses.Add(course1);
    }

    public bool RemoveCourse(string name)
    {
        var itemToRemove = this.Courses.FirstOrDefault(x => x.Name == name);
        if (itemToRemove != null)
        {
            return this.Courses.Remove(itemToRemove) ? true : false;
        }
        return false;
    }
    
    public List<BootCampCourse> Courses { get; set; } = new List<BootCampCourse>();

    public int MaxNumberOfCourses { get => maxNumberOfCourses; }
}
