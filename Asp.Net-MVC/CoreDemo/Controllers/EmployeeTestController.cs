using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // Http istekleri atabilmesini sağlayan sınıftır.
            var httpClient = new HttpClient();
            // GetAsync-> Servisimizde istek yapacağımız adresi belirtiyoruz.
            var responseMessage = await httpClient.GetAsync("https://localhost:44304/api/Default");
            // ReadAsStringAsync-> (servisten bize dönen Json bilgisini almış oluyoruz)
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            //Serialization: Bir nesnenin saklanacak / transfer edilecek forma dönüştürülme işlemidir. Serileşmenin tersi olarak
            //Deserialization ifadesi kullanılır ve bu da Stream'in (Akış) nesne modeline dönüştürülme işlemidir.(DeserializeObject işe jsondan nesneye çeviriyor)
            //Veriyi apiye gönderirken serialize olarak göndeririz. Veriyi alırken deserialize yaparak alırız.
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);

            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient= new HttpClient();
            var jsonEmployee=JsonConvert.SerializeObject(p);
            StringContent content=new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44304/api/Default",content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);

        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44304/api/Default/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonEmployee = await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<Class1>(jsonEmployee);
                return View(values);
            }
            return RedirectToAction("Index");   

        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 p)
        {
            var httpClient=new HttpClient();
            var jsonEmployee=JsonConvert.SerializeObject(p);
            var content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44304/api/Default/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public async Task <IActionResult> DeleteEmployee(int id)
        {

            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44304/api/Default/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
           
        }
        
    }
    //class1 emloyee sınıfındaki propları karşılayabilmeli
    public class Class1{
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
