using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication6.Models;
using WebApplication6.ModelsViews;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (DefaultDbContext context = new DefaultDbContext())
            {
                if (!context.Services.Any<Services>() && !context.Emplooyes.Any<Emplooyes>())
                {
                    List<Services> services = new List<Services>();

                    for (int i = 1; i < 7; i++)
                    {
                        services.Add(new Services()
                        {
                            Title = "Title - " + i,
                            Description = "Description - " + i
                        });
                    }

                    List<Emplooyes> emps = new List<Emplooyes>();
                    for (int i = 1; i < 4; i++)
                    {
                        emps.Add(new Emplooyes()
                        {
                            Name = "Name - " + i,
                            Profession = "Profession - " + i
                        });
                    }

                    context.AddRange(emps);
                    context.AddRange(services);

                    context.SaveChanges();

                    return View(new EmployeeServiceViewData
                    {
                        Emplooyes = emps,
                        Services = services
                    });
                }
                else
                {
                    return View(new EmployeeServiceViewData
                    {
                        Emplooyes = context.Emplooyes.ToList(),
                        Services = context.Services.ToList()
                    });
                }
            }
        }
    }
}
