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
        [HttpPost]
        public bool ValidateUser(string userId,string pwd)
        {
            return new UserDAL().ValidateUser(userId,pwd);
        }

        #region WebApi Controller behaviour
        /*
        public List<Users> GetUser(int userId, string name)
        {
            return new UserDAL().ValidateUser("Nilesh","");
        }

        public List<Users> GetUser()
        {
            return new UserDAL().ValidateUser("Nilesh","");
        }

        [ActionName("LocationUser")]
        public List<Users> GetUser(int userId,string name,string location="Default")
        {
            return new UserDAL().ValidateUser("Nilesh","");
        }
        */
        #endregion
    }
}
