using QAwebApp.Models;
using System.Collections.Generic;

namespace QAwebApp
{
    public class Authorization
    {
        private UserModel user;
        private readonly IFormRepository _formRepository;

        public Authorization(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        public UserModel GetAppUser()
        {
            var appUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            var appUserSid = appUser.Name.Substring(6);
            user = _formRepository.GetUser(appUserSid);
            return user;
        }

        public bool AdminCheck(UserModel user)
        {
            //bool found = false;

            //if (_formRepository.GetAdmin(user.Sid) != null)
            //{
            //    found = true;
            //}

            //return found;

           return _formRepository.GetAdmin(user.Sid) != null ? true : false;
        }
    }
}
