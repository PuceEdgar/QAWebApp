using QAwebApp.Models;
using System.Collections.Generic;

namespace QAwebApp.ViewModels
{
    public class FormViewModel
    {
        public string Title { get; set; }
        public string AppUser { get; set; }
        public List<FormModel> Forms { get; set; }

        public FormModel Form { get; set; }

        public List<UnitResponsibleModel> UnitResponsibles { get; set; }
        public UnitResponsibleModel UnitResponsible { get; set; }

        public UserModel User { get; set; }


        public AdminModel Admin { get; set; }

        public List<AdminModel> Admins { get; set; }

    }
}
