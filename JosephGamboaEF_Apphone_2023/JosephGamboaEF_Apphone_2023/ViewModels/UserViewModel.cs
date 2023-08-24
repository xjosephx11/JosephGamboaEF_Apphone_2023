using JosephGamboaEF_Apphone_2023.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JosephGamboaEF_Apphone_2023.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public User MyUser { get; set; }
        public UserRole MyUserRole { get; set; }
        public UserDTO MyUserDTO { get; set; }

        public UserViewModel()
        {
                MyUser = new User();   
            MyUserRole = new UserRole();
            MyUserDTO = new UserDTO();
        }

        public async Task<List<UserRole>> GetUserRolesAsync()
        {
            try
            {
                List<UserRole> roles = new List<UserRole>();
                roles = await MyUserRole.GetAllUserRolesAsync();
                if (roles == null)
                {
                    return null;
                }
                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
