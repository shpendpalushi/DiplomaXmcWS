using DiplomaXMCWS.Models;
using DiplomaXMCWS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiplomaXMCWS.Controllers
{
    public class UsersController : ApiController
    {
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
    }
}
