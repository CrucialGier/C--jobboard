using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];
      Post["/job_added"] = _ => {
        Job newJob = new Job(Request.Form["new-job"]);
        newJob.SetEmail(Request.Form["contact-email"]);
        newJob.SetName(Request.Form["company-name"]);
        newJob.SetPhoneNumber(Request.Form["contact-number"]);
        newJob.Save();
        return View["job_added.cshtml", newJob];
      };
    }
  }
}