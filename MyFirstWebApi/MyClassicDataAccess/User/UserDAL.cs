using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassicDTO;
using System.Xml.Linq;

namespace MyClassicDataAccess.User
{
    public class UserDAL
    {
        public List<Users> ValidateUser(string userId)
        {
            var p =  GetDBFactory.CreateFactory(DBChoice.XML).
                CreateQueryProvider().GetDataFromSelection<XElement>("//user[@id='Nilesh']");
            return new List<Users>();
        }
    }
}
