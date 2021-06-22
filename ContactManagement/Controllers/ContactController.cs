using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;
using System.Net.Http;
using Newtonsoft.Json;
using ContactManagement.Controllers.Api;
using System.Text;

namespace ContactManagement.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<Contact> _model = null;

            using (var client = new HttpClient())
            {
                var request = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

                client.BaseAddress = new Uri(request + "/api/");

                var responseTask = client.GetAsync("contactapi/getAllContact");
                responseTask.Wait();


                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    string readTask = await result.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<IList<Contact>>(readTask);
                    _model = value;
                }
                else
                {
                    _model = Enumerable.Empty<Contact>();
                }
            }
            return View(_model);

        }

       
        public IActionResult Create()
        {           
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> create(Contact contacts)
        {
            using (var client = new HttpClient())
            {
                var request = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                client.BaseAddress = new Uri(request + "/api/");
              
                var postTask = await client.PostAsync("contactapi/addContact", new StringContent(JsonConvert.SerializeObject(contacts), Encoding.UTF8, "application/json"));             
                var result =postTask.EnsureSuccessStatusCode();             
              
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }          

            return View(contacts);
        }

       [HttpDelete]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                var request = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                client.BaseAddress = new Uri(request + "/api/");

                var deleteTask = client.DeleteAsync("contactapi/deleteContact" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }


    }
}
