using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;
namespace SFSample
{
    public partial class GanttController : Controller
    {
        public ActionResult GanttFeatures()
        {
            var DataSource = GanttData.GetData();
            ViewBag.datasource = DataSource;
	    ViewBag.resources = ResourceList.GetResources();
            return View();
        }
	public class Resource
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
        }
        public class ResourceList
        {
            public static List<Resource> GetResources()
            {
                List<Resource> ResourceCollection = new List<Resource>();
                ResourceCollection.Add(new Resource() { ResourceId = 1, ResourceName = "Project Manager" });
                ResourceCollection.Add(new Resource() { ResourceId = 2, ResourceName = "Software Analyst" });
                ResourceCollection.Add(new Resource() { ResourceId = 3, ResourceName = "Developer" });
                ResourceCollection.Add(new Resource() { ResourceId = 4, ResourceName = "Testing Engineer" });
                return ResourceCollection;
            }
        }
        public class GanttData
        {
            public static List<GanttFeatureData> GetData()
            {
                List<GanttFeatureData> list = new List<GanttFeatureData>();
                list.Add(new GanttFeatureData()
                {
                    Id = 1,
                    Name = "Parent Task 1",
                    StartDate = "02/23/2014",
                    BaselineStartDate = "02/23/2014",
                     BaselineEndDate = "02/25/2014",
                    Duration = 5,
                    PercentDone = 40,
                    Resources =new List<int>(){1,3},
                    Children = (new List<GanttFeatureData>()
                    {
                        new GanttFeatureData()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/23/2014",
                           BaselineStartDate = "02/23/2014",
                             BaselineEndDate = "02/25/2014",
                            Duration = 3,
                            PercentDone = 40,
                         Resources =new List<int>(){1,2},
                        },
                        new GanttFeatureData()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/26/2014",
                           BaselineStartDate = "02/26/2014",
                             BaselineEndDate = "02/29/2014",
                            Duration = 3,
                            PercentDone = 40,
                            Predescessor = "2"
                        },
                        new GanttFeatureData()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/23/2014",
                            BaselineStartDate = "02/23/2014",
                             BaselineEndDate = "02/25/2014",
                            Duration = 5,
                            PercentDone = 40,
                            Predescessor = "3SS"
                        }
                    })
                });
                list.Add(new GanttFeatureData()
                {
                    Id = 5,
                    Name = "Parent Task 2",
                    StartDate = "03/14/2014",
                     BaselineStartDate = "03/02/2014",
                     BaselineEndDate = "03/05/2014",
                    Duration = 5,
                    PercentDone = 40,
                     Resources =new List<int>(){3},
                    Children = (new List<GanttFeatureData>()
                    {
                        new GanttFeatureData()
                        {
                            Id = 6,
                            Name = "Child Task 1",
                            StartDate = "03/02/2014",
                              BaselineStartDate = "03/02/2014",
                             BaselineEndDate = "03/05/2014",
                            Duration = 5,
                          Resources =new List<int>(){2},
                            PercentDone = 40
                        },
                        new GanttFeatureData()
                        {
                            Id = 7,
                            Name = "Child Task 2",
                            StartDate = "03/02/2014",
                             BaselineStartDate = "03/02/2014",
                             BaselineEndDate = "03/05/2014",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new GanttFeatureData()
                        {
                            Id = 8,
                            Name = "Child Task 3",
                            StartDate = "03/02/2014",
                             BaselineStartDate = "03/02/2014",
                             BaselineEndDate = "03/05/2014",
                            Duration = 2,
                            PercentDone = 40,
                        },
                        new GanttFeatureData()
                        {
                            Id = 9,
                            Name = "Child Task 4",
                            StartDate = "03/02/2014",
                           BaselineStartDate = "03/02/2014",
                             BaselineEndDate = "03/05/2014",
                            Duration = 5,
                            PercentDone = 40,
                          Resources =new List<int>(){1,3},
                        }
                    })
                });
                list.Add(new GanttFeatureData()
                {
                    Id = 10,
                    Name = "Parent Task 3",
                    StartDate = "02/21/2014",
                      BaselineStartDate = "02/21/2014",
                      BaselineEndDate = "02/24/2014",    
                    Duration = 5,
                    PercentDone = 40,
                    Resources =new List<int>(){3},
                    Children = (new List<GanttFeatureData>()
                    {
                        new GanttFeatureData()
                        {
                            Id = 11,
                            Name = "Child Task 1",
                            StartDate = "02/21/2014",
                            BaselineStartDate = "02/21/2014",
                             BaselineEndDate = "02/24/2014",
                            Duration = 5,
                            PercentDone = 40
                        },
                        new GanttFeatureData()
                        {
                            Id = 12,
                            Name = "Child Task 2",
                            StartDate = "02/21/2014",
                             BaselineStartDate = "02/21/2014",
                             BaselineEndDate = "02/24/2014",
                            Duration = 5,
                            PercentDone = 40,
                        },
                        new GanttFeatureData()
                        {
                            Id = 13,
                            Name = "Child Task 3",
                            StartDate = "02/21/2014",
                             BaselineStartDate = "02/21/2014",
                             BaselineEndDate = "02/24/2014",
                            Duration = 5,
                            PercentDone = 40,
                        }
                    })
                });
                return list;
            }
        }
  public class GanttFeatureData
 {
         public object StartDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public int PercentDone { get; set; }
            public List<GanttFeatureData> Children { get; set; }
            public string Predescessor { get; set; }
            public string BaselineStartDate { get; set; }
            public string BaselineEndDate { get; set; }
            public List<int> Resources { get; set; }
  } 
 }
}
