using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace QAwebApp.Models
{
    public class FormRepository : IFormRepository
    {
        private readonly AppDbContext _appDbContext;



        public FormRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<FormModel> GetAllForms()
        {
            return _appDbContext.Forms;

        }

        public FormModel GetForm(int? id)
        {
            return _appDbContext.Forms.FirstOrDefault(f => f.Id == id);
        }



        public void AddForm(FormModel form)
        {
            _appDbContext.Forms.Add(form);
            _appDbContext.SaveChanges();
        }

        public void RemoveForm(FormModel form)
        {
            _appDbContext.Forms.Remove(form);
            _appDbContext.SaveChanges();
        }

        public void ModifyForm(FormModel form)
        {
            _appDbContext.Entry(form).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        //unit reponsibles
        public IEnumerable<UnitResponsibleModel> GetAllResponsibles()
        {
            return _appDbContext.UnitResponsibleModel;
        }

        public UnitResponsibleModel GetUnitResponsible(int? id)
        {
            return _appDbContext.UnitResponsibleModel.FirstOrDefault(r => r.Id == id);

        }
        public UnitResponsibleModel GetUnitResponsibleSid(string sid)
        {
            return _appDbContext.UnitResponsibleModel.FirstOrDefault(r => r.Sid == sid);

        }

        public void AddResponsible(UnitResponsibleModel unitResponsible)
        {
            _appDbContext.UnitResponsibleModel.Add(unitResponsible);
            _appDbContext.SaveChanges();
        }

        public void RemoveResponsible(UnitResponsibleModel unitResponsible)
        {
            _appDbContext.UnitResponsibleModel.Remove(unitResponsible);
            _appDbContext.SaveChanges();
        }

        public void ModifyResponsible(UnitResponsibleModel unitResponsible)
        {
            _appDbContext.Entry(unitResponsible).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        //user
        public UserModel GetUser(string sid)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Sid == sid);
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            return _appDbContext.Users;
        }

        //admin
        public AdminModel GetAdminById(int? id)
        {
            return _appDbContext.Admins.FirstOrDefault(a => a.Id == id);
        }
        public AdminModel GetAdmin(string sid)
        {
            return _appDbContext.Admins.FirstOrDefault(a => a.Sid == sid);
        }

        public IEnumerable<AdminModel> GetAllAdmins()
        {
            return _appDbContext.Admins;
        }

        public void AddAdmin(AdminModel admin)
        {
            _appDbContext.Admins.Add(admin);
            _appDbContext.SaveChanges();
        }

        public void RemoveAdmin(AdminModel admin)
        {
            _appDbContext.Admins.Remove(admin);
            _appDbContext.SaveChanges();
        }
    }
}
