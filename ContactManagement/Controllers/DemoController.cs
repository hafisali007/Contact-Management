using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;
using System.Linq.Dynamic;
using System.Net.Http;
using Newtonsoft.Json;

namespace ContactManagement.Controllers
{
    public class DemoController : Controller
    {
        private ContactAppContext _context;

        public DemoController(ContactAppContext context)
        {
            _context = context;
        }
        // GET: /<controller>/  
        public IActionResult ShowGrid()
        {
            return View();
        }

        public async Task<IActionResult> LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
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

                var customerData = (from tempcustomer in _model
                                    select tempcustomer);

                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.FirstName == searchValue);
                }

                //total number of rows count   
                recordsTotal = customerData.Count();
                //Paging   
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}