using DiplomaXMCWS.Models;
using DiplomaXMCWS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DiplomaXMCWS.Controllers
{
    public class TasksController : ApiController
    {
        public IHttpActionResult GetAllTasks()
        {
            IList<Tasks> tasks = null;
            using (XMCEntities db = new XMCEntities())
            {
                tasks = db.XMCTasks.Select(t => new Tasks()
                {
                    XMCTask_Id = t.XMCTask_Id,
                    Task_Name = t.Task_Name,
                    Task_Description = t.Task_Description,
                    Creator_Id = t.Creator_Id,
                    Referencer_Id = t.Referencer_Id,
                    XMCPune_Id = t.XMCPune_Id,
                    XMCProjekt_Id = t.XMCProjekt_Id,
                    XMCTipologjia_Id = t.XMCTipologjia_Id
                }).ToList<Tasks>();
                return Ok(tasks);
            }
        }
    }
}
