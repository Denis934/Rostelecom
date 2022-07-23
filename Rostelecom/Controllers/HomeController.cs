using Microsoft.AspNetCore.Mvc;

namespace RostelecomApplication.Controllers
{
    [Route("/api/[controller]")] // адрес запроса
    public class HomeController : Controller 
    {
        [HttpPost()] //  Set запрос 
        public IActionResult Set([FromBody] InputData inputData)
        {
            OutputData outputData = new OutputData(); // экземпляр InputData

            outputData.kod = Generetion.GetKod(inputData.lenght_kod); // пароль\код

            outputData.salt = Generetion.GetSalt(inputData.lenght_salt); //  соль

            outputData.hash = Generetion.GetSHA1(outputData.kod, outputData.salt); // хеш SHA1

            return Ok(outputData); // возвращаем InputData
        }    
    }
}
