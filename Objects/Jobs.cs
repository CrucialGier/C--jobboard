using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _description;
    private string _email;
    private string _name;
    private string _phoneNumber;
    private static List<Job> _instance = new List<Job> {};

    public Job (string description)
    {
      _description = description;
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string email)
    {
      _email = email;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }

    public static List<Job> GetAll()
    {
      return _instance;
    }

    public void Save()
    {
      _instance.Add(this);
    }

    public static void ClearAll()
    {
      _instance.Clear();
    }
  }
}
