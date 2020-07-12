using DiplomaXMCWS.Models;
using DiplomaXMCWS.ViewModel;
using ServiceStack.Auth;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace DiplomaXMCWS.Controllers
{
    public class UsersController : ApiController
    {
    
        //GET
        public IHttpActionResult GetAllUsers()
        {
            IList<User> users = null;
            using (XMCEntities db = new XMCEntities())
            {
                users = db.XMCUsers.Select(u => new User()
                {
                    Id = u.XMCUsers_Id,
                    Full_Name = u.Users_Full_Name,
                    Email = u.Users_Email,
                    Description = u.Users_Description,
                    Username = u.Users_Username,
                    Password = u.Users_Password,
                    PozicionId = u.XMCPozicion_Id
                }
            ).ToList<User>();
                return Ok(users);
            }
        }

        //POST
        [HttpPost]
        public IHttpActionResult PostNewUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid");
            //try {
                using (XMCEntities db = new XMCEntities())
                {
                    db.XMCUsers.Add(new XMCUser()
                    {
                        Users_Full_Name = user.Full_Name,
                        Users_Email = user.Email,
                        Users_Username = user.Username,
                        Users_Description = user.Description,
                        Users_Password = user.Password,
                        XMCPozicion_Id = user.PozicionId,
                    });

                    db.SaveChanges();
                }
        //    }
        //    catch (DbEntityValidationException e)
        //    {
        //        foreach (var eve in e.EntityValidationErrors)
        //        {
        //            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
        //                eve.Entry.Entity.GetType().Name, eve.Entry.State);
        //            foreach (var ve in eve.ValidationErrors)
        //            {
        //                System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
        //                    ve.PropertyName, ve.ErrorMessage);
        //            }
        //    }
        //        //throw;
        //}
            return Ok();
        }

        //PUT
        public IHttpActionResult UpdateUser(User user)
        {

            if (!ModelState.IsValid)
                return BadRequest("Informacioni i deleguar eshte i pavlefshem. Kontrolloje dhe provo perseri!");
            using (XMCEntities db = new XMCEntities())
            {
                var checkExistingUser = db.XMCUsers.Where(u => u.XMCUsers_Id == user.Id).FirstOrDefault<XMCUser>();
                if(checkExistingUser !=null)
                {
                    checkExistingUser.Users_Full_Name = user.Full_Name;
                    checkExistingUser.Users_Email = user.Email;
                    checkExistingUser.Users_Username = user.Username;
                    checkExistingUser.Users_Description = user.Description;
                    checkExistingUser.Users_Password = user.Password;
                    checkExistingUser.XMCPozicion_Id = user.PozicionId;

                    db.SaveChanges();

                }
                else
                {
                    return NotFound();
                }
                return Ok();
            }
            

        }

        //DELETE
        public IHttpActionResult DeleteUser(int id=0)
        {
            if(id <= 0)
                return BadRequest("Ju lutem percaktoni id, perpara se te konsumoni kete sherbim!");

            using (XMCEntities db = new XMCEntities())
            {
                var user = db.XMCUsers.Where(u => u.XMCPozicion_Id == id).FirstOrDefault();
                db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }



                return Ok();

        }


    }
}
