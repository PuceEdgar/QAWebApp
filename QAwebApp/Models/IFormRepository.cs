using System.Collections.Generic;

namespace QAwebApp.Models
{
    public interface IFormRepository
    {
        IEnumerable<FormModel> GetAllForms();
        FormModel GetForm(int? id);

        void AddForm(FormModel form);

        void RemoveForm(FormModel form);

        void ModifyForm(FormModel form);

        //unit reponsibles
        IEnumerable<UnitResponsibleModel> GetAllResponsibles();

        UnitResponsibleModel GetUnitResponsible(int? id);
        UnitResponsibleModel GetUnitResponsibleSid(string sid);

        void AddResponsible(UnitResponsibleModel unitResponsible);

        void RemoveResponsible(UnitResponsibleModel unitResponsible);

        void ModifyResponsible(UnitResponsibleModel unitResponsible);


        //users
        UserModel GetUser(string sid);
        IEnumerable<UserModel> GetAllUsers();

        //admins
        AdminModel GetAdminById(int? id);
        AdminModel GetAdmin(string sid);

        IEnumerable<AdminModel> GetAllAdmins();

        void AddAdmin(AdminModel admin);

        void RemoveAdmin(AdminModel admin);
    }
}
