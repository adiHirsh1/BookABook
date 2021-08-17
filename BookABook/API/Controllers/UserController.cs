using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        UserBL userBL = new UserBL();
        [HttpGet]
        public IHttpActionResult GetAllUsers()
        {
            //Calls functions ob bll
            
            return Ok(userBL.GetAllUsers());
        }
        [HttpPost]
        public IHttpActionResult CreateUser(UserDTO user)
        {
            return Ok(userBL.CreateUser(user));
        }


    }
}
