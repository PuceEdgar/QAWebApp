using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using QAwebApp.Models;
using QAwebApp.ViewModels;
using System;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QAwebApp.Controllers
{
    public class FormController : Controller
    {

        //private readonly AppDbContext _appDbContext;


        private readonly IFormRepository _formRepository;

        public FormController(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        //public FormController(AppDbContext appDbContext)
        //{
        //    _appDbContext = appDbContext;
        //}


        public ViewResult List()
        {
            return View(_formRepository.GetAllForms());
        }

        Authorization authorization;
        UserModel appUser;
        bool isAdmin;



        // GET: /<controller>/
        public IActionResult Index()
        {

            var forms = _formRepository.GetAllForms().OrderBy(f => f.Division);
            var responsibles = _formRepository.GetAllResponsibles();
            var admins = _formRepository.GetAllAdmins();

            authorization = new Authorization(_formRepository);
            appUser = authorization.GetAppUser();
            isAdmin = authorization.AdminCheck(appUser);

            //isAdmin = false;
            //appUser = _formRepository.GetUser("S1321");

            if (appUser == null)
            {
                return View("NotAllowed");
            }

            var formViewModel = new FormViewModel()
            {
                Title = "QA Questionarie",
                AppUser = appUser.Name,
                //Forms = forms.ToList(),
                UnitResponsibles = responsibles.ToList(),
                //Admins = admins.ToList()

            };

            if (!isAdmin)
            {
                formViewModel.Forms = forms.Where(f => f.ManagerSid == appUser.Sid).ToList();
                return View("IndexManager", formViewModel);
            }
            else
            {
                formViewModel.Forms = forms.ToList();
            }




            return View(formViewModel);
        }

        // GET: Person/Details/5
        public ActionResult Details(int? id)
        {

            FormModel form = _formRepository.GetForm(id);
            form.UnitResponsible = _formRepository.GetUnitResponsible(form.UnitResponsibleId);
            //form.User = _formRepository.GetUser(form.UnitResponsible.Sid);



            //FormModel form = _appDbContext.Forms.Find(id);
            if (id == null)
            {
                return BadRequest();

            }
            ////Person person = db.Persons.Find(id);
            if (form == null)
            {
                return NotFound();
            }
            return View(form);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind(include: "Division, Country, AssessmentPeriod, DateOfAssessment")] FormModel form, IFormCollection fc)
        {
            FormViewModel model = new FormViewModel();


            //FormModel newForm = new FormModel();
            //newForm.Division = form.Division;
            //newForm.Country = form.Country;

            FormModel newForm = form;

            // _appDbContext.Forms = model.Forms;


            //newForm.Division = fc["model.Division"];
            //newForm.Country = fc["model.Country"];
            //newPerson.dob = Convert.ToDateTime(fc["personModel.dob"]);
            //newPerson.phone_number = fc["personModel.phone_number"];
            //newPerson.primary_address = al[radio].address1;
            //if (newPerson.primary_address == null)
            //{
            //    ViewBag.Message = "Please select primary address!";
            //    return PartialView("_AddPerson");
            //}



            if (ModelState.IsValid)
            {
                // model.Forms.Add(newForm);

                // db.Persons.Add(newPerson);
                //_appDbContext.Forms.Add(newForm);
                //_appDbContext.SaveChanges();
                _formRepository.AddForm(newForm);




                //model.Forms = _appDbContext.Forms.ToList();
                //model.SaveChanges();
                ModelState.Clear();

                return RedirectToAction("Index", "Form");
                //return JavaScript("success()");
            }

            //change to person if not working!
            return View(model);
        }





        // GET: Person/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            FormModel form = _formRepository.GetForm(id);
            if (form == null)
            {
                return NotFound();
            }
            return View(form);
        }

        // POST: 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(include: "Division, Country")] int id)
        {
            FormModel form = _formRepository.GetForm(id);
            authorization = new Authorization(_formRepository);
            appUser = authorization.GetAppUser();
            isAdmin = authorization.AdminCheck(appUser);


            if (isAdmin)
            {
                _formRepository.RemoveForm(form);
            }


            return RedirectToAction("Index");
        }


        //EDIT
        public ActionResult Edit(int? id)
        {

            authorization = new Authorization(_formRepository);
            appUser = authorization.GetAppUser();
            //appUser = _formRepository.GetUser("S13218");
            isAdmin = authorization.AdminCheck(appUser);
            if (!isAdmin)
            {
                return new BadRequestResult();
            }

            if (id == null)
            {
                return new BadRequestResult();
            }


            FormModel form = _formRepository.GetForm(id);
            form.UnitResponsible = _formRepository.GetUnitResponsible(form.UnitResponsibleId);
            if (form == null)
            {
                return NotFound();
            }

            if (!isAdmin)
            {

                return View("EditManager", form);
            }

            return View(form);
        }



        public ActionResult EditManager(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }


            FormModel form = _formRepository.GetForm(id);
            form.UnitResponsible = _formRepository.GetUnitResponsible(form.UnitResponsibleId);
            if (form == null)
            {
                return NotFound();
            }

            return View(form);
        }

        // POST: Person/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(include: "Division, Country, ManagerSid, Id, DateOfAssessment, AssessmentPeriod, Bul1, Bul2, Bul3")] FormModel form)
        {
            authorization = new Authorization(_formRepository);
            appUser = authorization.GetAppUser();
            //appUser = _formRepository.GetUser("S13218");
            isAdmin = authorization.AdminCheck(appUser);
            if (!isAdmin)
            {
                return new BadRequestResult();
            }
            FormModel Form = form;


            if (ModelState.IsValid)
            {

                if (Form == null)
                {
                    return NotFound();
                }

                if (isAdmin)
                {
                    _formRepository.ModifyForm(Form);
                    return RedirectToAction("Index", Form);
                }
                else
                {
                    if (Form.ManagerSid == appUser.Sid)
                    {
                        _formRepository.ModifyForm(Form);
                        return RedirectToAction("Index", Form);
                    }
                }

            }
            return View(Form);


        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditManager([Bind(include: "Id, Division, Country")] FormModel form, IFormCollection iForm)
        {

            FormModel Form = _formRepository.GetForm(form.Id);
            appUser = _formRepository.GetUser("S13218");


            //Form.ManagerSid = iForm["ManagerSid"].ToString();

            if (Form.ManagerSid != appUser.Sid)
            {
                return RedirectToAction("IndexManager");
            }

            Form.Division = iForm["Division"].ToString();
            Form.Country = iForm["Country"].ToString();



            if (ModelState.IsValid)
            {

                if (Form == null)
                {
                    return NotFound();
                }

                if (isAdmin)
                {
                    _formRepository.ModifyForm(Form);
                    return RedirectToAction("Index", Form);
                }
                else
                {
                    if (Form.ManagerSid == appUser.Sid)
                    {
                        _formRepository.ModifyForm(Form);
                        return RedirectToAction("Index", Form);
                    }
                }

            }
            return View(Form);


        }






        //find
        [HttpGet]
        public ActionResult Assign(int id)
        {
            FormModel form = _formRepository.GetForm(id);
            return View(form);
        }


        //assign
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Assign([Bind(include: "Id, ManagerSid")] FormModel form)
        {

            FormModel Form = _formRepository.GetForm(form.Id);
            if (_formRepository.GetUnitResponsibleSid(form.ManagerSid) == null)
            {
                UserModel user = _formRepository.GetUser(form.ManagerSid);
                UnitResponsibleModel newResponsible = new UnitResponsibleModel();
                newResponsible.Sid = user.Sid;
                newResponsible.Name = user.Name;
                newResponsible.Email = user.Email;
                _formRepository.AddResponsible(newResponsible);
                newResponsible.Id = _formRepository.GetUnitResponsibleSid(newResponsible.Sid).Id;
                Form.UnitResponsibleId = newResponsible.Id;
                Form.ManagerSid = newResponsible.Sid;
            }
            else
            {
                Form.UnitResponsibleId = _formRepository.GetUnitResponsibleSid(form.ManagerSid).Id;
                Form.ManagerSid = form.ManagerSid;
            }



            if (ModelState.IsValid)
            {

                if (Form == null)
                {
                    return NotFound();
                }

                _formRepository.ModifyForm(Form);



                return RedirectToAction("Index", Form);
            }
            return View(Form);
        }



        //get user
        public ActionResult GetUser(FormModel form)
        {

            var user = _formRepository.GetUser(form.ManagerSid);

            if (user == null)
            {
                ViewData["error"] = "User not found!";
                return PartialView("_Error");
            }

            FormModel f = new FormModel();
            f = _formRepository.GetForm(form.Id);
            //f.UnitResponsible = r;
            f.User = user;
            return PartialView("_GetUser", f);
        }

        public ActionResult SendEmail(int id)
        {



            FormModel f = _formRepository.GetForm(id);

            Email email = new Email();

            try
            {
                email.Send();
                f.EmailSent = "Sent";

                _formRepository.ModifyForm(f);

            }
            catch (Exception ex)
            {
                f.EmailSent = "Failed";
                _formRepository.ModifyForm(f);
            }


            return RedirectToAction("Index");
        }



        public ActionResult AdminList()
        {

            var admins = _formRepository.GetAllAdmins();
            FormViewModel formViewModel = new FormViewModel();
            formViewModel.Admins = admins.ToList();
            return View(admins);
        }

        public ActionResult AddAdmin()
        {
            return View();
        }


        public ActionResult GetAdmin(AdminModel admin)
        {
            var user = _formRepository.GetUser(admin.Sid);

            if (user == null)
            {
                ViewData["error"] = "User not found!";
                return PartialView("_Error");
            }

            admin.Name = user.Name;
            admin.Email = user.Email;
            admin.Sid = user.Sid;

            return PartialView("_GetAdmin", admin);
        }

        [HttpPost]
        public ActionResult AddAdmin([Bind(include: "Sid, Name, Email")] AdminModel admin)
        {

            var exist = _formRepository.GetAdmin(admin.Sid);

            if (exist != null)
            {
                ViewData["error"] = exist.Name + " is already in Admin List";
                return View();
            }

            if (ModelState.IsValid)
            {

                if (admin == null)
                {
                    return NotFound();
                }

                _formRepository.AddAdmin(admin);



                return RedirectToAction("AdminList", _formRepository.GetAllAdmins());
            }
            return View(admin);
        }



        [HttpPost]
        public ActionResult DeleteAdmin([Bind(include: "Id, Sid, Name, Email")] AdminModel admin, IFormCollection iForm, int id)
        {
            //System.Linq.Enumerable.Single<TSource>(IEnumerable<TSource> source)

            AdminModel adminToRemove = _formRepository.GetAdminById(Int32.Parse(iForm["item.Id"]));
            if (ModelState.IsValid)
            {

                if (admin == null)
                {
                    return NotFound();
                }

                _formRepository.RemoveAdmin(adminToRemove);
                return View("AdminList", _formRepository.GetAllAdmins());
            }
            return View(admin);
        }
    }
}
