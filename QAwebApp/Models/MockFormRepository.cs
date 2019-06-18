using System.Collections.Generic;
using System.Linq;

namespace QAwebApp.Models
{
    public class MockFormRepository
    {
        private List<FormModel> _forms;

        public MockFormRepository()
        {
            if (_forms == null)
            {
                InitializeForms();
            }
        }

        private void InitializeForms()
        {
            _forms = new List<FormModel>
            {
                new FormModel {Division = "Business Support", Bul1 = "level 1 latvia", Bul2 = "level 2 latvia", Bul3 = "level 3 latvia", Country = "Latvia", BCMScore = 4, IRHScore = 2, NPAPScore = "4", ORSARTSAScore = "1", KRIScore = 2, ICCScore = 3 },
                new FormModel { Division = "Finance", Bul1 = "level 1 sweden", Bul2 = "level 2 sweden", Bul3 = "level 3 sweden", Country = "Sweden", BCMScore = 2, IRHScore = 2, NPAPScore = "2", ORSARTSAScore = "2", KRIScore = 2, ICCScore = 2 },
                new FormModel { Division = "ISD", Bul1 = "level 1 Germany", Bul2 = "level 2 Germany", Bul3 = "level 3 Germany", Country = "Germany", BCMScore = 1, IRHScore = 1, NPAPScore = "1", ORSARTSAScore = "1", KRIScore = 1, ICCScore = 1 }

            };
        }

        public IEnumerable<FormModel> GetAllForms()
        {
            return _forms;
        }

        public FormModel GetForm(int? id)
        {
            return _forms.FirstOrDefault(f => f.Id == id);
        }

        public void AddForm(FormModel form)
        {

        }

        public void RemoveForm(FormModel form)
        {

        }

        public void ModifyForm(FormModel form)
        {

        }
    }
}
