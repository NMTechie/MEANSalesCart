using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyClassicDTO;
using MyClassicDataAccess.User;


namespace MyWebApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public List<Users> ValidateUser()
        {
            return new UserDAL().ValidateUser("Nilesh");
        }

        #region WebApi Controller behaviour
        public List<Users> GetUser(int userId, string name)
        {
            return new UserDAL().ValidateUser("Nilesh");
        }

        public List<Users> GetUser()
        {
            return new UserDAL().ValidateUser("Nilesh");
        }

        [ActionName("LocationUser")]
        public List<Users> GetUser(int userId,string name,string location="Default")
        {
            return new UserDAL().ValidateUser("Nilesh");
        }
        #endregion
    }
}
