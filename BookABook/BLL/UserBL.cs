using BLL.Converters;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class UserBL
    {
        UserDAL userDAL = new UserDAL();
        public  List<UserDTO> GetAllUsers()
        {
            return UserConverter.Map(userDAL.GetAllUsers());
            
        }
   
        public bool CreateUser(UserDTO user)
        {
            return userDAL.CreateUser(UserConverter.Map(user));
        }

    }
}
