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
    
/*************************************************************************************
WebAPI default Convention for Binding parameters

If the parameter is a simple type like int, bool, double etc., 
WebAPI tries to get values from the URI (Either from route data or from QueryString).

If a parameter is a complex type like customer, product, employee etc., 
WebAPI tries to get values from request body.

To change the default parameter binding process use [FormBody] and[FormUri] attributes.
***************************************************************************************/

    public class UserController : ApiController
    {

        [HttpPost]
        public bool TestAction([FromBody]string userId)
        {
            return new UserDAL().ValidateUser(userId, "");
        }
        [HttpPost]
        public bool ValidateUser(Users credential)
        {
            return new UserDAL().ValidateUser(credential.UserId,credential.Password);
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
