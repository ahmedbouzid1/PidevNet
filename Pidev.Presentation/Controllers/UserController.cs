using Pidev.data;
using Pidev.Service;
using Pidev.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Pidev.Presentation.Controllers
{
    public class UserController : Controller
    {
        IUserService service;

        public UserController()
        {
          
            service = new UserService();
        }
        // GET: User
        public ActionResult IndexUser()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("pidev-web/user").Result;

            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<user>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(User userr, HttpPostedFileBase Image)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:9080/pidev-web/user");
            string json = new JavaScriptSerializer().Serialize(new
            {
                addresse = userr.addresse,
                image = Image.FileName,
                cin = userr.cin,
                //dat_naiss = userr.dat_naiss,
                email = userr.email,
                login = userr.login,
                nom = userr.nom,
                password = userr.password,
                prenom = userr.prenom,
                role = userr.role
                
            }
                );
            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var path = Path.Combine(Server.MapPath("~/Content/Uploads/"), Image.FileName);
            Image.SaveAs(path);
            HttpResponseMessage response = client.SendAsync(requestMessage).GetAwaiter().GetResult();
            return RedirectToAction("IndexUser");
        }
        public ActionResult DeleteUser(int id)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            HttpResponseMessage response = Client.DeleteAsync("pidev-web/user/"+id).ContinueWith((postTask)=>postTask.Result.EnsureSuccessStatusCode()).GetAwaiter().GetResult();
            return RedirectToAction("IndexUser"); 
        }
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            int x = 0;
            x = x + 1;
            using(MyContext dc =new MyContext()) 
            {
                var user=  dc.user.Where(p => p.email.Equals(model.email)).FirstOrDefault();
                if(user!=null)
                {

                    if (model.password.Equals(user.password))
                    {
                    //    if(user.role.Equals("Employe"))
                    //    {
                    //        return RedirectToAction("IndexUser");
                    //    }
                    //    if (user.role.Equals("DirecteurRH"))
                    //    {
                    //        return RedirectToAction("Create");
                    //    }
                        return RedirectToAction("IndexUser");
                    }
                    else
                    {
                        return RedirectToAction("Login");
                    }
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
        }
        //public ActionResult CreateUser(user user)
        //{
        //    HttpClient client = new HttpClient();

        //    HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:9080/pidev-web/user");
        //    string json = new JavaScriptSerializer().Serialize(new
        //    {
        //        addresse = user.addresse,
        //        cin = user.cin,
        //        email = user.email,
        //        login = user.login,
        //        nom = user.nom,
        //        password = user.password,
        //        prenom = user.prenom,
        //        role = user.role



        //    }
        //        );
        //    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

        //    HttpResponseMessage response = client.SendAsync(requestMessage).GetAwaiter().GetResult();
        //    return RedirectToAction("IndexUser");
        //}

       
    }
    
}