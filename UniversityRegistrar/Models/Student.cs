using System;
using UniversityRegistrar;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    private int _id;
    private string _name;
    private string _enrollment;

    public Student(string newName, string newEnrollment, int id = 0)
    {
      _name = newName;
      _enrollment = newEnrollment;
      _id = id;
    }
    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetEnrollment()
    {
      return _entrollment;
    }
    public override bool Equals(System.Object otherObject)
    {
      if(!(otherObject is Student))
      {
        return false;
      }
      else
      {
        Student newStudent = (Student) otherObject;
        bool IdEquality = (this.GetId() == newStudent.GetId());
        bool NameEquality = (this.GetName() == newStudent.GetName());
        bool EnrollmentEquality = (this.GetEnrollment() == newStudent.GetEnrollment());
        return (IdEquality && NameEquality && EnrollmentEquality);
      }
    }
    public override int GetHasCode()
    {
      this.GetName().GetHasCode();
    }
    public void Save()
    {

    }
    public List<Student> GetAll()
    {

    }
    public void DeleteAll()
    {
      
    }


  }
}
