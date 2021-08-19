using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
  public static class UserConverter
    {
        public static User Map(UserDTO user)
        {
            return new User
            {
                Address = user.Address,
                CellPhonNumber=user.CellPhonNumber
                 //...
            };
        }

        public static UserDTO Map(User user)
        {
            return new UserDTO
            {
                Address = user.Address,
                CellPhonNumber = user.CellPhonNumber
                //...
            };
        }


        public static List<UserDTO>  Map(List<User> users)
        {
            return users.Select(u => Map(u)).ToList();
        }



    }
}
