using DiplomaXMCWS.Models;
using DiplomaXMCWS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public IHttpActionResult GetUserTasks(int userId)
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
                var usersTasks = from t in tasks
                                 where t.Creator_Id == userId
                                 select t;
                return Ok(usersTasks);
            }
        }

        [HttpPost]
        public IHttpActionResult PostNewTask( Tasks tasks)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data!");
            try
            {
                using (XMCEntities db = new XMCEntities())
                {
                    db.XMCTasks.Add(new XMCTask()
                    {
                        Task_Name = tasks.Task_Name,
                        Task_Description = tasks.Task_Description,
                        Creator_Id = tasks.Creator_Id,
                        Referencer_Id = tasks.Referencer_Id,
                        XMCPune_Id = tasks.XMCPune_Id,
                        XMCProjekt_Id = tasks.XMCProjekt_Id,
                        XMCTipologjia_Id = tasks.XMCTipologjia_Id
                    });
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            return Ok();

        }
    }


}
