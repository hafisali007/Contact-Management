using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;
using System.Net.Http;
using Newtonsoft.Json;
using ContactManagement.Controllers.Api;

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
            
                var responseTask = client.GetAsync("contact/getAllContact");
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

       
    }
}
