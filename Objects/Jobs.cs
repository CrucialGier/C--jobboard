using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _description;
    private string _email;
    private string _name;
    private string _phoneNumber;
    private int _id;
    private static List<Job> _instances = new List<Job> {};

    public Job (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
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

    public int GetId()
    {
      return _id;
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Job Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
