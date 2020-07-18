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
    public class PozicionController : ApiController
    {
        public IHttpActionResult GetAllPositions()
        {
            IList<Pozicion> positions = null;
            using (XMCEntities db = new XMCEntities())
            {
                positions = db.XMCPozicions.Select(p => new Pozicion()
                {
                    Id = p.XMCPozicion_Id,
                    Name = p.Pozicion_Name,
                    Description = p.Pozicion_Description

                }).ToList<Pozicion>();
            }
            return Ok(positions);
        }
    }
}
