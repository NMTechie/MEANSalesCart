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
        public bool ValidateUser(string userId,string pwd)
        {
            var isValidUser = false;
            var p = GetDBFactory.CreateFactory(DBChoice.XML).
                CreateQueryProvider().GetDataFromSelection<XElement>("//user[@id='" + userId + "' and @password='" + pwd + "']");
            if (p != null && p.Any())
            {
                isValidUser = p.First().Attribute("name").Value.Length > 0 ? true : false;
            }
            return isValidUser; 
        }
    }
}
