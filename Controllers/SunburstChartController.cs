using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SFSample
{
    public class SunburstChartController : Controller
    {      
        public ActionResult SunburstChartFeatures()
        {         
	    ViewData["defaultData"] = DefaultData.GetDefaultData();  
            return View();
        }
    }
public class DefaultData
    {
        public string Category { get; set; }
        public string Country { get; set; }
        public string JobDescription { get; set; }
        public string JobGroup { get; set; }
        public string JobRole { get; set; }
        public int EmployeesCount { get; set; }
        public static List<DefaultData> GetDefaultData()
        {
            List<DefaultData> data = new List<DefaultData>();
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Sales", JobGroup = "Executive", EmployeesCount = 50 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Marketing", EmployeesCount = 40 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 35 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 175 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 70 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Management", EmployeesCount = 40 });
            data.Add(new DefaultData() { Category = "Employees", Country = "America", JobDescription = "Accounts", EmployeesCount = 60 });
            data.Add(new DefaultData() { Category = "Employees", Country = "India", JobDescription = "Technical2", JobGroup = "Testers1", EmployeesCount = 33 });
            data.Add(new DefaultData() { Category = "Employees", Country = "India", JobDescription = "Technical2", JobGroup = "Developers2", JobRole = "Windows1", EmployeesCount = 125 });
            data.Add(new DefaultData() { Category = "Employees", Country = "India", JobDescription = "Technical2", JobGroup = "Developers2", JobRole = "Web1", EmployeesCount = 60 });
            data.Add(new DefaultData() { Category = "Employees", Country = "India", JobDescription = "HR Executives", EmployeesCount = 70 });
            data.Add(new DefaultData() { Category = "Employees", Country = "India", JobDescription = "Accounts1", EmployeesCount = 45 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Sales2", JobGroup = "Executive2", EmployeesCount = 30 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Sales2", JobGroup = "Analyst2", EmployeesCount = 40 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Marketing2", EmployeesCount = 50 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Technical3", JobGroup = "Testers2", EmployeesCount = 40 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Technical3", JobGroup = "Developers3", JobRole = "Windows2", EmployeesCount = 65 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Technical3", JobGroup = "Developers3", JobRole = "Web2", EmployeesCount = 27 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Management2", EmployeesCount = 33 });
            data.Add(new DefaultData() { Category = "Employees", Country = "Germany", JobDescription = "Accounts2", EmployeesCount = 55 });
            data.Add(new DefaultData() { Category = "Employees", Country = "UK", JobDescription = "Technical4", JobGroup = "Testers3", EmployeesCount = 25 });
            data.Add(new DefaultData() { Category = "Employees", Country = "UK", JobDescription = "Technical4", JobGroup = "Developers4", JobRole = "Windows3", EmployeesCount = 96 });
            data.Add(new DefaultData() { Category = "Employees", Country = "UK", JobDescription = "Technical4", JobGroup = "Developers4", JobRole = "Web3", EmployeesCount = 55 });
            data.Add(new DefaultData() { Category = "Employees", Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60 });
            data.Add(new DefaultData() { Category = "Employees", Country = "UK", JobDescription = "Accounts3", EmployeesCount = 30 });
            return data; 
        }
    }
}
